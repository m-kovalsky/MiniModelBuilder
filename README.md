# Mini Model Builder

Mini Model Builder is a tool that allows you to customize a 'mini model' based on an existing tabular model. This tool runs inside of [Tabular Editor](https://tabulareditor.com/ "Tabular Editor")'s [Advanced Scripting](https://docs.tabulareditor.com/Advanced-Scripting.html "Advanced Scripting") feature. This tool is compatible for all destinations of tabular models - [SQL Server Analysis Services](https://docs.microsoft.com/analysis-services/ssas-overview?view=asallproducts-allversions "SQL Server Analysis Services"), [Azure Analysis Services](https://azure.microsoft.com/services/analysis-services/ "Azure Analysis Services"), and [Power BI Premium](https://powerbi.microsoft.com/power-bi-premium/ "Power BI Premium") (using the [XMLA 
endpoint](https://docs.microsoft.com/power-bi/admin/service-premium-connect-tools "XMLA R/W Endpoint")). This tool is also viable for both in-memory and direct query models.

## Purpose

Call them what you want - 'micro cubes', 'mini models', 'derivative models' - this tool is designed to simplify the process of creating a 'mini model'. It is also designed with the intention of being used by a broader audience than just the tabular developer community.

## Running the Tool

1.) Download the following file to your computer.

      MiniModelBuilder.cs

2.) Open [Tabular Editor](https://github.com/otykier/TabularEditor/releases/latest "Tabular Editor").

3.) Connect to your model.

4.) Paste the MiniModelBuilder.cs script inside the [Advanced Scripting](https://docs.tabulareditor.com/Advanced-Scripting.html "Advanced Scripting") window.

5.) Click the 'Play' button (or press F5).

## Creating the 'Mini Model'

After you set up a mini model using the Mini Model Builder tool and deploy your model to a server, you can generate the mini model. 

1.) Download the following file to your computer.
       
       MiniModelBuilder_Create.cs
       
2.) Run the following code in the command prompt below (filling in the \<parameters\>) according to the variety of tabular you are using.

Since each of the scripts below uses an Environment Variable (set miniModelName=<Mini Model Name>), there is no need to duplicate the MiniModelBuilder_Create.cs file for each mini model. The same MiniModelBuilder_Create.cs file can be referenced for creating all mini models. Setting the 'miniModelName' Environment Variable instructs the code which mini model to create.

## [SQL Server Analysis Services](https://docs.microsoft.com/analysis-services/ssas-overview?view=asallproducts-allversions "SQL Server Analysis Services")

    set miniModelName=<Mini Model Name>
    start /wait /d "C:\Program Files (x86)\Tabular Editor" TabularEditor.exe "<Server Name>" "<Database Name>" -S "<C# Script File Location (MiniModelBuilder_Create.cs)>"

## [Azure Analyis Services](https://azure.microsoft.com/services/analysis-services/ "Azure Analysis Services")

    set miniModelName=<Mini Model Name>
    start /wait /d "C:\Program Files (x86)\Tabular Editor" TabularEditor.exe "Provider=MSOLAP;Data Source=asazure://<AAS Region>.asazure.windows.net/<AAS Server Name>;User ID=<xxxxx>;Password=<xxxxx>;Persist Security Info=True;Impersonation Level=Impersonate" "<Database Name>" -S "<C# Script File Location (MiniModelBuilder_Create.cs)>"

## [Power BI Premium](https://powerbi.microsoft.com/power-bi-premium/ "Power BI Premium")

Running this in Power BI Premium requires enabling [XMLA R/W endpoints](https://docs.microsoft.com/power-bi/admin/service-premium-connect-tools "XMLA R/W Endpoints") for your Premium Workspace. An additional requirement is setting up a [Service Principal](https://tabulareditor.com/2020/06/02/PBI-SP-Access.html "Setting up a Service Principal").

    set miniModelName=<Mini Model Name>
    start /wait /d "C:\Program Files (x86)\Tabular Editor" TabularEditor.exe "Provider=MSOLAP;Data Source=powerbi://api.powerbi.com/v1.0/myorg/<Premium Workspace>;User ID=app:<Application ID>@<Tenant ID>;Password=<Application Secret>" "<Premium Dataset>" -S "<C# Script File Location (MiniModelBuilder_Create.cs)>" 

## Instructions for using the program

* For navigation, either use the 'Next' button or click directly on a particular step.
* Only Step 1 is necessary. All other steps are optional.
* Always click the 'Save' button after making a change. If the 'Save' button is not pressed, your changes will not be saved.

## Features

* Step 1: Select which objects you need in your mini model. Object dependencies are automatically added to your mini model.
* Step 2: Simply toggle to hide or unhide objects (tables, measures, columns, hierarchies) within your mini model. If an object shows as gray in this step it will be hidden in the mini model. If an object shows in black, it will be visible in the mini model.
* Step 3: Update the DAX for measures or calculated columns in your mini model.
* Step 4: Remove non-necessary partitions from multi-partitioned tables in your mini model.
* Step 5: Remove non-necessary perspectives.
* Step 6: Perform a find-and-replace within your partition queries. This allows you to easily repoint your tables/partitions to a different schema in your data warehouse.
* Step 7: Update role members and model permission for your mini model.
* Step 8: Update the row level security (RLS) for any role and table that has RLS filters within the original model.
* Step 9: Update tables to point to a different data source (choosing among the data sources within the original model).
* Step 10: Filter your model based on column values. The column filters should be placed on dimension tables. These filters will be applied to the related fact tables as well (based on existing relationships).
* Step 11: Set aggregations to minimize row counts in your mini model. Use the light bulb icon to recommend summarizations for each of the columns in your table. Aggregations are only for tables on the 'from-side' of a relationship (in other words, Fact tables).
* Summary: Shows a full summary of all the differences between the original model and the mini model.
* Blue icon indicates an object is different in the mini model as compared to the original model.
* Automatically updates perspectives and annotations to ensure your mini model is created exactly as specified.
* All relationships and model integrity is passed on from the original model to the mini model.
* In the Summary view, the 'Script' button will output a C# file to your desktop which contains all the instructions for creating your mini model. This can be executed in the 'Advanced Scripting' window against the original model.

## Requirements

* [Tabular Editor](https://tabulareditor.com/ "Tabular Editor") version 2.12.1 or higher.
* Compatible for SQL Server Analysis Services, Azure Analysis Services, and Power BI Premium models.
* Compatible for tabular models using Import-mode, Direct Query mode, and Composite models.
* Make sure to click the 'Save' button within each page of the Mini Model Builder after making changes.
* To use the 'Filter Column Values' step, you must be live-connected to an Analysis Services model.
* To use either the 'Filter Column Values' or 'Set Aggregations' steps, your data source must be a SQL-type source and partition queries must start with 'SELECT * FROM ...'.

## Version History

* 2020-12-01 Version 1.0.0 released on GitHub.com
* 2021-03-08 Version 1.0.1 released on GitHub.com
  * MiniModelBuilder_Create.cs now uses an Environment Variable so the script is completely reusable for all mini models.
