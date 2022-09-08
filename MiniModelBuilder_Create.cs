var version = System.Environment.GetEnvironmentVariable("miniModelName");

// Remove tables, measures, columns and hierarchies that are not part of the perspective:
foreach(var t in Model.Tables.ToList()) {
    if(!t.InPerspective[version]) t.Delete();
    else {
        foreach(var m in t.Measures.ToList()) if(!m.InPerspective[version]) m.Delete();   
        foreach(var c in t.Columns.ToList()) if(!c.InPerspective[version]) c.Delete();
        foreach(var h in t.Hierarchies.ToList()) if(!h.InPerspective[version]) h.Delete();
    }
}

string ann = string.Empty;

// ************** MODIFY DAX *************** //

ann = version+"_Expression";
foreach(var x in Model.AllMeasures.Where(a => a.HasAnnotation(ann))) 
{
    x.Expression = x.GetAnnotation(ann);
}

foreach(var x in Model.AllColumns.Where(a => a.Type.ToString() == "Calculated" && a.HasAnnotation(ann)).ToList())
{
    string tableName = x.Table.Name;
    string columnName = x.Name;
    (Model.Tables[tableName].Columns[columnName] as CalculatedColumn).Expression = x.GetAnnotation(ann);        
}

// ************* START HIDING/UNHIDING ************** //
string annH = version+"_Hide";
string annU = version+"_Unhide";

// Modify tables to unhide based on annotations
foreach(var x in Model.Tables.ToList()) 
{
    if (x.HasAnnotation(annH))
    {
        x.IsHidden = true;
    }
    else if (x.HasAnnotation(annU))
    {
        x.IsHidden = false;
    }
}

// Modify columns to unhide based on annotations
foreach(var x in Model.AllColumns) 
{
    if (x.HasAnnotation(annH))
    {
        x.IsHidden = true;
    }
    else if (x.HasAnnotation(annU))
    {
        x.IsHidden = false;
    }
}

// Modify measures to unhide based on annotations
foreach(var x in Model.AllMeasures) 
{
    if (x.HasAnnotation(annH))
    {
        x.IsHidden = true;
    }
    else if (x.HasAnnotation(annU))
    {
        x.IsHidden = false;
    }
}

// Modify hierarchies to unhide based on annotations
foreach(var x in Model.AllHierarchies) 
{
    if (x.HasAnnotation(annH))
    {
        x.IsHidden = true;
    }
    else if (x.HasAnnotation(annU))
    {
        x.IsHidden = false;
    }
}

// *************   END   ************** //

// *************  START REMOVALS ************** //

ann = version+"_Remove";

// Remove Data Sources based on annotations
foreach(var x in Model.DataSources.Where(a => a.HasAnnotation(ann)).ToList())
{
    x.Delete();
}

// Remove Roles based on annotations
foreach(var x in Model.Roles.Where(a => a.HasAnnotation(ann)).ToList())
{
    x.Delete();
}

// Remove Partitions based on annotations
foreach(var x in Model.AllPartitions.Where(a => a.HasAnnotation(ann))) 
{
    x.Delete();    
}

// Remove KPIs based on annotations
ann = version+"_RemoveKPI";
foreach(var x in Model.AllMeasures.Where(a => a.HasAnnotation(ann))) 
{
    x.KPI.Delete();
}

//   *************  END REMOVALS ************** //

// Set partition queries according to annotations
ann = version+"_UpdatePartitionQuery";
string sep = " ---- ";
foreach(var t in Model.Tables.Where(a => a.HasAnnotation(ann))) 
{
    string annValue = t.GetAnnotation(ann);
    int sepIndex = annValue.IndexOf(sep);
    string findValue = annValue.Substring(0,sepIndex);
    string replaceValue = annValue.Substring(sepIndex+6,annValue.Length - sepIndex - 6);

    foreach (var p in t.Partitions)
    {        
        p.Query = p.Query.Replace(findValue,replaceValue);
    }
}

//Set partition data sources according to annotations
ann = version+"_UpdateDataSource";
foreach(var t in Model.Tables.Where(a => a.HasAnnotation(ann))) 
{
    var dataSourceName = t.GetAnnotation(ann);
    
    // Loop through all partitions in this table:
    foreach(var p in t.Partitions) 
    {
        p.DataSource = Model.DataSources[dataSourceName];
    }
}

// Update RLS based on annotations
ann = version+"_UpdateRLS_";
foreach (var r in Model.Roles.ToList())
{
    string roleName = r.Name;

    foreach (var t in Model.Tables.Where(a => a.RowLevelSecurity[roleName] != null).ToList())
    {
        string tableName = t.Name;
        if (r.HasAnnotation(ann + tableName))
        {
            string rls = r.GetAnnotation(ann + tableName);
            Model.Tables[tableName].RowLevelSecurity[roleName] = rls;
        }
    }
}

// Update Role Members based on annotations
ann = version+"_UpdateRoleMembers";

foreach(var x in Model.Roles.Where(a => a.HasAnnotation(ann))) 
{
    x.RoleMembers = x.GetAnnotation(ann);
}

// Update Model Permission
ann = version+"_UpdateModelPermission";

foreach (var r in Model.Roles.Where(a => a.HasAnnotation(ann)))
{
    string roleName = r.Name;
    string mp = r.GetAnnotation(ann);

    if (mp == "None")
    {
        r.ModelPermission = ModelPermission.None;
    }
    else if (mp == "Read")
    {
        r.ModelPermission = ModelPermission.Read;
    }
    else if (mp == "ReadRefresh")
    {
        r.ModelPermission = ModelPermission.ReadRefresh;
    }
    else if (mp == "Refresh")
    {
        r.ModelPermission = ModelPermission.Refresh;
    }
    else if (mp == "Administrator")
    {
        r.ModelPermission = ModelPermission.Administrator;
    }
}

// Aggregate partition queries
ann = version+"_AggType";

foreach (var t in Model.Tables.Where(a => a.InPerspective[version] && a.Columns.Where(b => b.HasAnnotation(ann)).Count() > 0))
{
    string tableName = t.Name;
    
    foreach (var p in t.Partitions)
    {
        string partitionName = p.Name;
        string pQuery = p.Query;
        int fromIndex = pQuery.ToUpper().IndexOf("FROM");
        
        var sb = new System.Text.StringBuilder();
        var newLine = Environment.NewLine;
        sb.Append("SELECT " + newLine);
        
        foreach (var c in t.Columns.Where(a => a.InPerspective[version] && a.HasAnnotation(ann)))
        {
            string columnName = c.Name;                        
            string sc = (Model.Tables[tableName].Columns[columnName] as DataColumn).SourceColumn;
            string annValue = c.GetAnnotation(ann);
            string annValueCaps = annValue.ToUpper();

            int filterCount = Model.Tables[tableName].Columns[columnName].UsedInRelationships.Where(a => a.FromTable.Name == tableName && a.FromColumn.Name == columnName && Model.Tables[a.ToTable.Name].Columns.Where(b => b.HasAnnotation(version+"_FilterColumnValues")).Count() > 0).Count();
            
            if (annValue == "GroupBy")
            {
                if (filterCount > 0)
                {
                    sb.Append("a.");
                }
                sb.Append("["+sc+"],");
            }
            else
            {
                sb.Append(annValueCaps+"(["+sc+"]) AS ["+sc+"],");                
            }            
            sb.Append(newLine);
        }
        // remove last comma
        sb.Length -=3;
        sb.Append(newLine);
        sb.Append(pQuery.Substring(fromIndex));
        sb.Append(newLine + "GROUP BY " + newLine);

        foreach (var c in t.Columns.Where(a => a.InPerspective[version] && a.HasAnnotation(ann)))
        {
            string columnName = c.Name;
            string sc = (Model.Tables[tableName].Columns[columnName] as DataColumn).SourceColumn;
            string annValue = c.GetAnnotation(ann);            
            
            int filterCount = Model.Tables[tableName].Columns[columnName].UsedInRelationships.Where(a => a.FromTable.Name == tableName && a.FromColumn.Name == columnName && Model.Tables[a.ToTable.Name].Columns.Where(b => b.HasAnnotation(version+"_FilterColumnValues")).Count() > 0).Count();

            if (annValue == "GroupBy")
            {
                if (filterCount > 0)
                {
                    sb.Append("a.");
                }
                sb.Append("["+sc+"],");
                sb.Append(newLine);
            }            
        }    
        sb.Length -=3;
        sb.Append(newLine); 
        
        string newPQuery = sb.ToString();
        p.Query = newPQuery;
    }
}

// Add filters to tables with annotations
ann = version+"_FilterColumnValues";

foreach (var t in Model.Tables.Where(a => a.InPerspective[version]).ToList())
{
    string tableName = t.Name;
    foreach (var c in t.Columns.Where(a => a.InPerspective[version] && a.Type.ToString() == "Data" && a.HasAnnotation(ann)).ToList())        
    {
        string columnName = c.Name;
        string filterValue = c.GetAnnotation(ann);
                
        foreach (var p in t.Partitions.ToList())
        {
            string partitionName = p.Name;
            string pQuery = p.Query;
            
            if (pQuery.ToUpper().Contains("WHERE ") && p.Query.ToUpper().Contains("GROUP BY"))
            {
                int wIndex = pQuery.ToUpper().IndexOf("WHERE ");
                int gbIndex = pQuery.ToUpper().IndexOf("GROUP BY");

                p.Query = pQuery.Substring(0,gbIndex) + "AND " + filterValue + '\n' + pQuery.Substring(gbIndex);                
            }
            else if (pQuery.ToUpper().Contains("WHERE ") && !p.Query.ToUpper().Contains("GROUP BY"))
            {
                int wIndex = pQuery.ToUpper().IndexOf("WHERE ");
                
                p.Query = pQuery + '\n' + "AND " + filterValue;
            }
            else if (!pQuery.ToUpper().Contains("WHERE ") && p.Query.ToUpper().Contains("GROUP BY"))
            {
                int gbIndex = pQuery.ToUpper().IndexOf("GROUP BY");
                
                p.Query = pQuery.Substring(0,gbIndex) + "WHERE 1=1" + '\n' + "AND " + filterValue + '\n' + pQuery.Substring(gbIndex);
            }
            else if (!pQuery.ToUpper().Contains("WHERE ") && !p.Query.ToUpper().Contains("GROUP BY"))
            {
                p.Query = pQuery + '\n' + "WHERE 1=1" + '\n' + "AND " + filterValue;
            }
        }
    }    
}

// Add joins to related tables
foreach (var t in Model.Tables.Where(a => a.Columns.Where(b => b.HasAnnotation(ann)).Count() > 0))
{
    string tableName = t.Name;
    string tableSource = t.Source;
    string tableQuery = t.Partitions.First().Query;
    string pObject;
    int pFrom = tableQuery.ToUpper().IndexOf("FROM") + "FROM".Length;
    int pJ = tableQuery.ToUpper().IndexOf("JOIN");
    int pW = tableQuery.ToUpper().IndexOf("WHERE");
    int pG = tableQuery.ToUpper().IndexOf("GROUP BY");
    
    if (pJ != -1)
    {
        pObject = tableQuery.Substring(pFrom,pJ-pFrom).Trim();
    }
    else if (pW != -1)
    {
        pObject = tableQuery.Substring(pFrom,pW-pFrom).Trim();
    }
    else if (pG != -1)
    {
        pObject = tableQuery.Substring(pFrom,pG-pFrom).Trim();
    }
    else
    {
        pObject = tableQuery.Substring(pFrom).Trim();
    }
    
    foreach (var r in Model.Tables[tableName].UsedInRelationships.Where(a => a.ToTable.Name == tableName && Model.Tables[a.FromTable.Name].InPerspective[version]).ToList())
    {
        string fromTable = r.FromTable.Name;
        string toTable = r.ToTable.Name;
        string fromColumn = r.FromColumn.Name;
        string toColumn = r.ToColumn.Name;
                                
        string fromSC = (Model.Tables[fromTable].Columns[fromColumn] as DataColumn).SourceColumn;
        string toSC = (Model.Tables[toTable].Columns[toColumn] as DataColumn).SourceColumn;
        
        if (Model.Tables[fromTable].Source != tableSource)
        {
            Info("Unable to add joins to the '"+fromTable+"' table partition query since it uses a different source than the '"+tableName+"' table");
        }
        else
        {
            foreach (var p in Model.Tables[fromTable].Partitions.ToList())
            {
                string pQuery = p.Query;
                if (pQuery.ToUpper().Contains("JOIN ") && pQuery.ToUpper().Contains("WHERE "))
                {                
                    int jIndex = pQuery.ToUpper().IndexOf("JOIN ");
                    int wIndex = pQuery.ToUpper().IndexOf("WHERE ");
                    int jCount = (pQuery.Length - pQuery.Replace("JOIN ", "").Length) / "JOIN ".Length;
                    jCount = jCount+1;
                    
                    p.Query = pQuery.Substring(0,wIndex) + '\n' + "JOIN " + pObject + " AS a" + jCount.ToString() + " on a.[" + fromSC + "] = a" + jCount.ToString() + ".[" + toSC + "]" + '\n' + pQuery.Substring(wIndex);
                    
                }
                else if (pQuery.ToUpper().Contains("JOIN ") && !pQuery.ToUpper().Contains("WHERE ") && pQuery.ToUpper().Contains("GROUP BY"))
                {    
                    int jIndex = pQuery.ToUpper().IndexOf("JOIN ");                
                    int gbIndex = pQuery.ToUpper().IndexOf("GROUP BY");
                    int jCount = (pQuery.Length - pQuery.Replace("JOIN ", "").Length) / "JOIN ".Length;
                    jCount = jCount+1;
                    
                    p.Query = pQuery.Substring(0,gbIndex) + '\n' + "JOIN " + pObject + " AS a" + jCount.ToString() + " on a.[" + fromSC + "] = a" + jCount.ToString() + ".[" + toSC + "]" + '\n' + pQuery.Substring(gbIndex);
                }
                else if (pQuery.ToUpper().Contains("JOIN ") && !pQuery.ToUpper().Contains("WHERE ") && !pQuery.ToUpper().Contains("GROUP BY"))
                {
                    int jIndex = pQuery.ToUpper().IndexOf("JOIN ");
                    int jCount = (pQuery.Length - pQuery.Replace("JOIN ", "").Length) / "JOIN ".Length;
                    jCount = jCount+1;
                    
                    p.Query = pQuery + '\n' + "JOIN " + pObject + " AS a" + jCount.ToString() + " on a.[" + fromSC + "] = a" + jCount.ToString() + ".[" + toSC + "]";
                    
                }
                else if (!pQuery.ToUpper().Contains("JOIN ") && pQuery.ToUpper().Contains("WHERE "))
                {
                    int wIndex = pQuery.ToUpper().IndexOf("WHERE ");
                    p.Query = pQuery.Substring(0,wIndex) + " AS a" + '\n' + "JOIN " + pObject + " AS a1 on a.[" + fromSC + "] = a1.[" + toSC + "]" + '\n' + pQuery.Substring(wIndex);
                    
                }
                else if (!pQuery.ToUpper().Contains("JOIN ") && !pQuery.ToUpper().Contains("WHERE ") && pQuery.ToUpper().Contains("GROUP BY"))
                {
                    int gbIndex = pQuery.ToUpper().IndexOf("GROUP BY");
                    p.Query = pQuery.Substring(0,gbIndex) + " AS a " + '\n' + "JOIN " + pObject + " AS a1 on a.[" + fromSC + "] = a1.[" + toSC + "]" + '\n' + pQuery.Substring(gbIndex);
                }
                else if (!pQuery.ToUpper().Contains("JOIN ") && !pQuery.ToUpper().Contains("WHERE ") && !pQuery.ToUpper().Contains("GROUP BY"))
                {
                    p.Query = pQuery + " AS a" + '\n' + "JOIN " + pObject + " AS a1 on a.[" + fromSC + "] = a1.[" + toSC + "]";
                }
            }    
        }                
    }
}

// Add filters to tables related to tables with annotations
foreach (var t in Model.Tables.Where(a => a.Columns.Where(b => b.HasAnnotation(ann)).Count() > 0))
{
    string tableName = t.Name;
    string tableSource = t.Source;
    string tableQuery = t.Partitions.First().Query;
    string pObject;
    int pFrom = tableQuery.ToUpper().IndexOf("FROM") + "FROM".Length;
    int pJ = tableQuery.ToUpper().IndexOf("JOIN");
    int pW = tableQuery.ToUpper().IndexOf("WHERE");
    int pG = tableQuery.ToUpper().IndexOf("GROUP BY");
    
    if (pJ != -1)
    {
        pObject = tableQuery.Substring(pFrom,pJ-pFrom).Trim();
    }
    else if (pW != -1)
    {
        pObject = tableQuery.Substring(pFrom,pW-pFrom).Trim();
    }
    else if (pG != -1)
    {
        pObject = tableQuery.Substring(pFrom,pG-pFrom).Trim();
    }
    else
    {
        pObject = tableQuery.Substring(pFrom).Trim();
    }

    int pObjectLen = pObject.Length + 5;
    
    foreach (var c in t.Columns.Where(a => a.HasAnnotation(ann)))
    {    
        string filterValue = c.GetAnnotation(ann);
    
        foreach (var r in Model.Tables[tableName].UsedInRelationships.Where(a => a.ToTable.Name == tableName && Model.Tables[a.FromTable.Name].InPerspective[version]).ToList())
        {
            string fromTable = r.FromTable.Name;
            
            if (Model.Tables[fromTable].Source != tableSource)
            {
                Info("Unable to add filters to the '"+fromTable+"' table partition query since it uses a different source than the '"+tableName+"' table");
            }
            else
            {
                foreach (var p in Model.Tables[fromTable].Partitions.ToList())
                {
                    string pQuery = p.Query;

                    if (!pQuery.ToUpper().Contains("WHERE ") && !p.Query.ToUpper().Contains("GROUP BY"))
                    {
                        string aNumber = "";
                        int pObjectIndex = pQuery.IndexOf(pObject);
                        
                        if (pQuery.Contains(pObject))
                        {
                            aNumber = pQuery.Substring(pObjectIndex+pObjectLen,1);
                        }
                        p.Query = pQuery + '\n' + "WHERE 1=1" + '\n' + "AND a" + aNumber + "." + filterValue;
                    }
                    else if (pQuery.ToUpper().Contains("WHERE ") && !p.Query.ToUpper().Contains("GROUP BY"))
                    {
                        int wIndex = pQuery.ToUpper().IndexOf("WHERE ");
                        string aNumber = "";
                        int pObjectIndex = pQuery.IndexOf(pObject);
                        if (pQuery.Contains(pObject))
                        {
                            aNumber = pQuery.Substring(pObjectIndex+pObjectLen,1);
                        }
                        
                        p.Query = pQuery + '\n' + "AND a" + aNumber + "." + filterValue;
                    }
                    else if (!pQuery.ToUpper().Contains("WHERE ") && p.Query.ToUpper().Contains("GROUP BY"))
                    {
                        int gbIndex = pQuery.ToUpper().IndexOf("GROUP BY");
                        string aNumber = "";
                        int pObjectIndex = pQuery.IndexOf(pObject);
                        if (pQuery.Contains(pObject))
                        {
                            aNumber = pQuery.Substring(pObjectIndex+pObjectLen,1);
                        }
                        
                        p.Query = pQuery.Substring(0,gbIndex) + "WHERE 1=1" + '\n' + "AND a" + aNumber + "." + filterValue + '\n' + pQuery.Substring(gbIndex);
                    }
                    else if (pQuery.ToUpper().Contains("WHERE ") && p.Query.ToUpper().Contains("GROUP BY"))
                    {
                        int gbIndex = pQuery.ToUpper().IndexOf("GROUP BY");
                        string aNumber = "";
                        int pObjectIndex = pQuery.IndexOf(pObject);
                        if (pQuery.Contains(pObject))
                        {
                            aNumber = pQuery.Substring(pObjectIndex+pObjectLen,1);
                        }
                        p.Query = pQuery.Substring(0,gbIndex) + '\n' + "AND a" + aNumber + "." + filterValue + '\n' + pQuery.Substring(gbIndex);
                    }
                } 
            }               
        }
    }
}

// Remove perspectives

ann = version+"_Remove";
// Remove Perspectives based on annotations
foreach(var x in Model.Perspectives.Where(a => a.HasAnnotation(ann)).ToList())
{
    x.Delete();
}
