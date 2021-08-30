#r "System.Drawing"

using System.Drawing;

// Start screen
System.Windows.Forms.Form newForm = new System.Windows.Forms.Form();
System.Windows.Forms.RadioButton newmodelButton = new System.Windows.Forms.RadioButton();
System.Windows.Forms.RadioButton existingmodelButton = new System.Windows.Forms.RadioButton();
System.Windows.Forms.ComboBox mmComboBox = new System.Windows.Forms.ComboBox();            
System.Windows.Forms.Button startstep1Button = new System.Windows.Forms.Button();
System.Windows.Forms.Label toolNameLabel = new System.Windows.Forms.Label();

// Main screen
System.Windows.Forms.Label modelnameLabel = new System.Windows.Forms.Label();
System.Windows.Forms.TextBox modelnameTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.Label infoLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Panel sidePanel = new System.Windows.Forms.Panel();
System.Windows.Forms.Panel topLeftPanel = new System.Windows.Forms.Panel();
System.Windows.Forms.Panel midPanel = new System.Windows.Forms.Panel();
System.Windows.Forms.Panel topMidPanel = new System.Windows.Forms.Panel();
System.Windows.Forms.Panel topRightPanel = new System.Windows.Forms.Panel();
System.Windows.Forms.Panel rightPanel = new System.Windows.Forms.Panel();
System.Windows.Forms.Button topButton = new System.Windows.Forms.Button();
System.Windows.Forms.Button step1Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step2Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step3Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step4Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step5Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step6Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step7Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step8Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step9Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step10Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step11Button = new System.Windows.Forms.Button();
System.Windows.Forms.Button step12Button = new System.Windows.Forms.Button();
System.Windows.Forms.ImageList imageList = new System.Windows.Forms.ImageList();
System.Windows.Forms.ImageList imageList2 = new System.Windows.Forms.ImageList();
System.Windows.Forms.Button saveButton = new System.Windows.Forms.Button();
System.Windows.Forms.Button exportscriptButton = new System.Windows.Forms.Button();
System.Net.WebClient w = new System.Net.WebClient();
System.Windows.Forms.ToolTip saveButtonToolTip = new System.Windows.Forms.ToolTip();
saveButtonToolTip.SetToolTip(saveButton, "Saves the changes back to the model");
System.Windows.Forms.ToolTip exportscriptButtonToolTip = new System.Windows.Forms.ToolTip();
exportscriptButtonToolTip.SetToolTip(exportscriptButton, "Saves a script with the mini model instructions to your desktop");

// Step 1
System.Windows.Forms.TreeView step1treeView = new System.Windows.Forms.TreeView();
System.Windows.Forms.Button nextstepButton = new System.Windows.Forms.Button();

// Step 2
System.Windows.Forms.TreeView step2treeView = new System.Windows.Forms.TreeView();

// Step 3
System.Windows.Forms.TreeView step3treeView = new System.Windows.Forms.TreeView();
System.Windows.Forms.TextBox oldDAXTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.TextBox newDAXTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.Label oldDAXLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Label newDAXLabel = new System.Windows.Forms.Label();

// Step 4
System.Windows.Forms.TreeView step4treeView = new System.Windows.Forms.TreeView();

// Step 5
System.Windows.Forms.TreeView step5treeView = new System.Windows.Forms.TreeView();

// Step 6
System.Windows.Forms.TreeView step6treeView = new System.Windows.Forms.TreeView();
System.Windows.Forms.TextBox oldqueryTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.TextBox newqueryTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.Label oldqueryLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Label newqueryLabel = new System.Windows.Forms.Label();
System.Windows.Forms.TextBox findTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.TextBox replaceTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.Label findLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Label replaceLabel = new System.Windows.Forms.Label();

// Step 7
System.Windows.Forms.TreeView step7treeView = new System.Windows.Forms.TreeView();
System.Windows.Forms.TextBox oldroleTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.TextBox newroleTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.Label oldroleLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Label newroleLabel = new System.Windows.Forms.Label();
System.Windows.Forms.ComboBox oldmpComboBox = new System.Windows.Forms.ComboBox();
System.Windows.Forms.ComboBox newmpComboBox = new System.Windows.Forms.ComboBox();
System.Windows.Forms.Label oldmpLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Label newmpLabel = new System.Windows.Forms.Label();

// Step 8
System.Windows.Forms.TreeView step8treeView = new System.Windows.Forms.TreeView();
System.Windows.Forms.TextBox oldrlsTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.TextBox newrlsTextBox = new System.Windows.Forms.TextBox();
System.Windows.Forms.Label oldrlsLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Label newrlsLabel = new System.Windows.Forms.Label();

// Step 9
System.Windows.Forms.TreeView step9treeView = new System.Windows.Forms.TreeView();
System.Windows.Forms.ComboBox olddsComboBox = new System.Windows.Forms.ComboBox();
System.Windows.Forms.ComboBox newdsComboBox = new System.Windows.Forms.ComboBox();
System.Windows.Forms.Label olddsLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Label newdsLabel = new System.Windows.Forms.Label();

// Step 10 
System.Windows.Forms.TreeView step10treeView = new System.Windows.Forms.TreeView();
System.Windows.Forms.Label filtersLabel = new System.Windows.Forms.Label();
System.Windows.Forms.TreeView filtersTreeView = new System.Windows.Forms.TreeView();

// Step 11
System.Windows.Forms.TreeView step11treeView = new System.Windows.Forms.TreeView();
System.Windows.Forms.Label aggLabel = new System.Windows.Forms.Label();
System.Windows.Forms.Button recoButton = new System.Windows.Forms.Button();
System.Windows.Forms.Button eraseButton = new System.Windows.Forms.Button();
System.Windows.Forms.Panel rightPanel2 = new System.Windows.Forms.Panel();
System.Windows.Forms.ToolTip recoButtonToolTip = new System.Windows.Forms.ToolTip();
saveButtonToolTip.SetToolTip(recoButton, "Recommends aggregation types for each column");
System.Windows.Forms.ToolTip eraseButtonToolTip = new System.Windows.Forms.ToolTip();
saveButtonToolTip.SetToolTip(eraseButton, "Clears aggregation types");

// Step 12 (Summary)
System.Windows.Forms.TreeView step12treeView = new System.Windows.Forms.TreeView();

// Colors
System.Drawing.Color sideColor =  ColorTranslator.FromHtml("#BFBFBF");
System.Drawing.Color bkgrdColor =  ColorTranslator.FromHtml("#F2F2F2");
System.Drawing.Color lighttextColor =  Color.White;
System.Drawing.Color darktextColor =  Color.Black;
System.Drawing.Color visibleColor = darktextColor;
System.Drawing.Color hiddenColor = Color.Gray;
System.Drawing.Color treeViewBkgrdColor = Color.White;

// Fonts
System.Drawing.Font sidePanelFont = new Font("Century Gothic", 10);
System.Drawing.Font topLeftPanelFont = new Font("Century Gothic", 14);
System.Drawing.Font toolNameFont = new Font("Century Gothic", 22);
System.Drawing.Font elegantFont = new Font("Century Gothic", 10, FontStyle.Italic);

// DAX Formatter Function (showing error)
// var myFormatDax = new Func<string, string>(orgDax => {
//     var result = TabularEditor.Dax.DaxFormatterProxy.FormatDax("[x]:=" + orgDax, useSemicolonsAsSeparators: false, shortFormat: true);
//     if(string.IsNullOrEmpty(result.FormattedDax)) throw new Exception("Unable to format DAX");
//     return result.FormattedDax.Substring(8);
// });

var sb_ExportScript = new System.Text.StringBuilder();

// Add images from web to Image List
var urlPrefix = "https://raw.githubusercontent.com/m-kovalsky/Tabular/master/Icons/";
var urlSuffix = "Icon.png";

string[] imageURLList = { "Table", "Column", "Measure", "Hierarchy", "CalculatedColumn", "ModifiedColumn", "ModifiedMeasure", "Partition", "Perspective", "ModifiedTable", "Role", "ModifiedRole", "Function", "ModifiedFunction", "Save", "SaveHighlight", "ExportScript", "ExportScriptHighlight", "Recommend", "RecommendHighlight", "Erase", "EraseHighlight" };
for (int i = 0; i < imageURLList.Count(); i++)
{
    var url = urlPrefix + imageURLList[i] + urlSuffix;      
    byte[] imageByte = w.DownloadData(url);
    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageByte);
    System.Drawing.Image im = System.Drawing.Image.FromStream(ms);

    if (i<14)
    {
        imageList.Images.Add(im);
    }
    else
    {
        imageList2.Images.Add(im);
    }
}    


// Add Images to Tree Views
imageList.ImageSize = new Size(16, 16); 
step1treeView.ImageList = imageList;
step2treeView.ImageList = imageList;
step3treeView.ImageList = imageList;
step4treeView.ImageList = imageList;
step5treeView.ImageList = imageList;
step6treeView.ImageList = imageList;
step7treeView.ImageList = imageList;
step8treeView.ImageList = imageList;
step9treeView.ImageList = imageList;
step10treeView.ImageList = imageList;
step11treeView.ImageList = imageList;
step12treeView.ImageList = imageList;

imageList2.ImageSize = new Size(23, 23); 
saveButton.ImageList = imageList2;
exportscriptButton.ImageList = imageList2;
recoButton.ImageList = imageList2;
eraseButton.ImageList = imageList2;

// Form parameters
int formWidth = 1000;
int formHeight = 700;
int stepButtonWidth = 200;
int stepButtonHeight = 49;
int topLeftPanelHeight = 63;
int gap = 10;
int treeViewWidth = (formWidth - stepButtonWidth - (gap*3)) / 2;
int treeViewHeight = 587;
int midPanelX = stepButtonWidth+gap;
int midPanelY = stepButtonHeight;
int midPanelWidth = treeViewWidth+gap;
int midPanelHeight = formHeight-topLeftPanelHeight;
int rightPanelX = midPanelX+midPanelWidth;
int rightPanelWidth = formWidth - midPanelWidth - stepButtonWidth - (3*gap)-6;
string asErrorMessage = "'Step 10: Filter Column Values' is only possible for models connected to Analysis Services";

// Form
newForm.TopMost = true;
newForm.Text = "Mini Model Builder";
newForm.Size = new Size(formWidth,formHeight);
newForm.MaximumSize = new Size(formWidth,formHeight);
newForm.MinimumSize = new Size(formWidth,formHeight);
newForm.Controls.Add(topLeftPanel);
newForm.Controls.Add(sidePanel);
newForm.Controls.Add(midPanel);
newForm.Controls.Add(topMidPanel);
newForm.Controls.Add(topRightPanel);
newForm.Controls.Add(rightPanel);
newForm.Controls.Add(rightPanel2);
newForm.Controls.Add(newmodelButton);
newForm.Controls.Add(toolNameLabel);
newForm.Controls.Add(existingmodelButton);
newForm.Controls.Add(mmComboBox);
newForm.Controls.Add(startstep1Button);
newForm.BackColor = bkgrdColor;

// Main Panel
midPanel.Size = new Size(midPanelWidth, formHeight-topLeftPanelHeight);
midPanel.Location = new Point(midPanelX,topLeftPanelHeight);
midPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
midPanel.BackColor = bkgrdColor;
midPanel.TabStop = false;
midPanel.Visible = false;

topMidPanel.Size = new Size(midPanelWidth,topLeftPanelHeight);
topMidPanel.Location = new Point(midPanelX,0);
topMidPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
topMidPanel.BackColor = bkgrdColor;
topMidPanel.TabStop = false;
topMidPanel.Visible = false;

rightPanel.Size = new Size(rightPanelWidth,treeViewHeight);
rightPanel.Location = new Point(rightPanelX,topLeftPanelHeight);
rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
rightPanel.BackColor = bkgrdColor;
rightPanel.TabStop = false;
rightPanel.Visible = false;

rightPanel2.Size = new Size(rightPanelWidth,treeViewHeight);
rightPanel2.Location = new Point(rightPanelX,topLeftPanelHeight);
rightPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
rightPanel2.BackColor = bkgrdColor;
rightPanel2.TabStop = false;
rightPanel2.Visible = false;
rightPanel2.AutoScroll = true;
rightPanel2.VerticalScroll.Enabled = true;
rightPanel2.VerticalScroll.Visible = true;
rightPanel2.HorizontalScroll.Visible = false;
rightPanel2.HorizontalScroll.Visible = false;


topRightPanel.Size = new Size(rightPanelWidth,topLeftPanelHeight);
topRightPanel.Location = new Point(rightPanelX,0);
topRightPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
topRightPanel.BackColor = bkgrdColor;
topRightPanel.TabStop = false;
topRightPanel.Visible = false;

topMidPanel.Controls.Add(modelnameLabel);
topMidPanel.Controls.Add(modelnameTextBox);
topMidPanel.Controls.Add(infoLabel);
topRightPanel.Controls.Add(saveButton);
topRightPanel.Controls.Add(exportscriptButton);
topRightPanel.Controls.Add(recoButton);
topRightPanel.Controls.Add(eraseButton);
topRightPanel.Controls.Add(nextstepButton);
topRightPanel.Controls.Add(oldDAXLabel);
topRightPanel.Controls.Add(oldqueryLabel);
topRightPanel.Controls.Add(oldroleLabel);
topRightPanel.Controls.Add(oldrlsLabel);
topRightPanel.Controls.Add(olddsLabel);
topRightPanel.Controls.Add(filtersLabel);
topRightPanel.Controls.Add(aggLabel);
midPanel.Controls.Add(step1treeView);
midPanel.Controls.Add(step2treeView);
midPanel.Controls.Add(step3treeView);
midPanel.Controls.Add(step4treeView);
midPanel.Controls.Add(step5treeView);
midPanel.Controls.Add(step6treeView);
midPanel.Controls.Add(step7treeView);
midPanel.Controls.Add(step8treeView);
midPanel.Controls.Add(step9treeView);
midPanel.Controls.Add(step10treeView);
midPanel.Controls.Add(step11treeView);
midPanel.Controls.Add(step12treeView);
rightPanel.Controls.Add(oldDAXTextBox);
rightPanel.Controls.Add(newDAXTextBox);
rightPanel.Controls.Add(newDAXLabel);
rightPanel.Controls.Add(newqueryLabel);
rightPanel.Controls.Add(oldqueryTextBox);
rightPanel.Controls.Add(newqueryTextBox);
rightPanel.Controls.Add(findLabel);
rightPanel.Controls.Add(replaceLabel);
rightPanel.Controls.Add(findTextBox);
rightPanel.Controls.Add(replaceTextBox);
rightPanel.Controls.Add(newroleLabel);
rightPanel.Controls.Add(oldroleTextBox);
rightPanel.Controls.Add(newroleTextBox);
rightPanel.Controls.Add(oldmpLabel);
rightPanel.Controls.Add(newmpLabel);
rightPanel.Controls.Add(oldmpComboBox);
rightPanel.Controls.Add(newmpComboBox);
rightPanel.Controls.Add(newrlsLabel);
rightPanel.Controls.Add(oldrlsTextBox);
rightPanel.Controls.Add(newrlsTextBox);
rightPanel.Controls.Add(newdsLabel);
rightPanel.Controls.Add(olddsComboBox);
rightPanel.Controls.Add(newdsComboBox);
rightPanel.Controls.Add(filtersTreeView);

// Top Left Panel
topLeftPanel.Size = new Size(stepButtonWidth, topLeftPanelHeight);
topLeftPanel.Location = new Point(0, 0);
topLeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
topLeftPanel.BackColor = bkgrdColor;
topLeftPanel.TabStop = false;
topLeftPanel.Visible = false;
topLeftPanel.Controls.Add(topButton);

// Side Panel
sidePanel.Size = new Size(stepButtonWidth,formHeight - topLeftPanelHeight - 50);
sidePanel.Location =  new Point(0, topLeftPanelHeight);
sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
sidePanel.BackColor = bkgrdColor;
sidePanel.Visible = false;
sidePanel.Controls.Add(step1Button);
sidePanel.Controls.Add(step2Button);
sidePanel.Controls.Add(step3Button);
sidePanel.Controls.Add(step4Button);
sidePanel.Controls.Add(step5Button);
sidePanel.Controls.Add(step6Button);
sidePanel.Controls.Add(step7Button);
sidePanel.Controls.Add(step8Button);
sidePanel.Controls.Add(step9Button);
sidePanel.Controls.Add(step10Button);
sidePanel.Controls.Add(step11Button);
sidePanel.Controls.Add(step12Button);

string[] infoLabelText = {
  "Select objects to include in the mini model.",
  "Select objects to hide or unhide.",
  "Set new DAX for measures or calculated columns.",
  "Select partitions to be removed.",
  "Select perspectives to be removed.",
  "Select tables to update their partition queries.",
  "Select a role to modify its members and permission.",
  "Select a table within a role to update the RLS.",
  "Select a table to update its data source.",
  "Select a column to filter its values.",
  "Select a table to set column aggregations.",
  "Here is a summary of your mini model."
};

string[] screenList = { 
  "Step 1: Select Model Objects", 
  "Step 2: Hide/Unhide Objects", 
  "Step 3: Update DAX", 
  "Step 4: Remove Partitions", 
  "Step 5: Remove Perspectives", 
  "Step 6: Update Table Partition Queries", 
  "Step 7: Update Roles", 
  "Step 8: Update Row Level Security", 
  "Step 9: Update Table Data Sources",
  "Step 10: Filter Column Values",
  "Step 11: Set Aggregations",
  "Summary"
};

// Top Left Button
topButton.Size = new Size(stepButtonWidth, topLeftPanelHeight);
topButton.Location = new Point(0, 0);
topButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
topButton.FlatAppearance.BorderSize = 0;
topButton.Text = "Mini Model Builder";
topButton.Font = topLeftPanelFont;
topButton.ForeColor = darktextColor;
topButton.BackColor = bkgrdColor;
topButton.FlatAppearance.MouseOverBackColor = bkgrdColor;
topButton.Cursor = System.Windows.Forms.Cursors.Hand;
topButton.TabStop = false;
topButton.Visible = false;

// Step Buttons
step1Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step1Button.Location = new Point(0, 0);
step1Button.BackColor = sideColor;
step1Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step1Button.ForeColor = lighttextColor;
step1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step1Button.FlatAppearance.BorderSize = 0;
step1Button.Text = screenList[0];
step1Button.Font = sidePanelFont;
step1Button.TextAlign = ContentAlignment.TopLeft;
step1Button.TabStop = false;
step1Button.Visible = false;

step2Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step2Button.Location = new Point(0, stepButtonHeight * 1);
step2Button.BackColor = sideColor;
step2Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step2Button.ForeColor = lighttextColor;
step2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step2Button.FlatAppearance.BorderSize = 0;
step2Button.Text = screenList[1];
step2Button.Font = sidePanelFont;
step2Button.TextAlign = ContentAlignment.TopLeft;
step2Button.TabStop = false;
step2Button.Visible = false;

step3Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step3Button.Location = new Point(0, stepButtonHeight * 2);
step3Button.BackColor = sideColor;
step3Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step3Button.ForeColor = lighttextColor;
step3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step3Button.FlatAppearance.BorderSize = 0;
step3Button.Text = screenList[2];
step3Button.Font = sidePanelFont;
step3Button.TextAlign = ContentAlignment.TopLeft;
step3Button.TabStop = false;
step3Button.Visible = false;

step4Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step4Button.Location = new Point(0, stepButtonHeight * 3);
step4Button.BackColor = sideColor;
step4Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step4Button.ForeColor = lighttextColor;
step4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step4Button.FlatAppearance.BorderSize = 0;
step4Button.Text = screenList[3];
step4Button.Font = sidePanelFont;
step4Button.TextAlign = ContentAlignment.TopLeft;
step4Button.TabStop = false;
step4Button.Visible = false;

step5Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step5Button.Location = new Point(0, stepButtonHeight * 4);
step5Button.BackColor = sideColor;
step5Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step5Button.ForeColor = lighttextColor;
step5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step5Button.FlatAppearance.BorderSize = 0;
step5Button.Text = screenList[4];
step5Button.Font = sidePanelFont;
step5Button.TextAlign = ContentAlignment.TopLeft;
step5Button.TabStop = false;
step5Button.Visible = false;

step6Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step6Button.Location = new Point(0, stepButtonHeight * 5);
step6Button.BackColor = sideColor;
step6Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step6Button.ForeColor = lighttextColor;
step6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step6Button.FlatAppearance.BorderSize = 0;
step6Button.Text = screenList[5];
step6Button.Font = sidePanelFont;
step6Button.TextAlign = ContentAlignment.TopLeft;
step6Button.TabStop = false;
step6Button.Visible = false;

step7Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step7Button.Location = new Point(0, stepButtonHeight * 6);
step7Button.BackColor = sideColor;
step7Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step7Button.ForeColor = lighttextColor;
step7Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step7Button.FlatAppearance.BorderSize = 0;
step7Button.Text = screenList[6];
step7Button.Font = sidePanelFont;
step7Button.TextAlign = ContentAlignment.TopLeft;
step7Button.TabStop = false;
step7Button.Visible = false;

step8Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step8Button.Location = new Point(0, stepButtonHeight * 7);
step8Button.BackColor = sideColor;
step8Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step8Button.ForeColor = lighttextColor;
step8Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step8Button.FlatAppearance.BorderSize = 0;
step8Button.Text = screenList[7];
step8Button.Font = sidePanelFont;
step8Button.TextAlign = ContentAlignment.TopLeft;
step8Button.TabStop = false;
step8Button.Visible = false;

step9Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step9Button.Location = new Point(0, stepButtonHeight * 8);
step9Button.BackColor = sideColor;
step9Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step9Button.ForeColor = lighttextColor;
step9Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step9Button.FlatAppearance.BorderSize = 0;
step9Button.Text = screenList[8];
step9Button.Font = sidePanelFont;
step9Button.TextAlign = ContentAlignment.TopLeft;
step9Button.TabStop = false;
step9Button.Visible = false;

step10Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step10Button.Location = new Point(0, stepButtonHeight * 9);
step10Button.BackColor = sideColor;
step10Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step10Button.ForeColor = lighttextColor;
step10Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step10Button.FlatAppearance.BorderSize = 0;
step10Button.Text = screenList[9];
step10Button.Font = sidePanelFont;
step10Button.TextAlign = ContentAlignment.TopLeft;
step10Button.TabStop = false;
step10Button.Visible = false;

step11Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step11Button.Location = new Point(0, stepButtonHeight * 10);
step11Button.BackColor = sideColor;
step11Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step11Button.ForeColor = lighttextColor;
step11Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step11Button.FlatAppearance.BorderSize = 0;
step11Button.Text = screenList[10];
step11Button.Font = sidePanelFont;
step11Button.TextAlign = ContentAlignment.TopLeft;
step11Button.TabStop = false;
step11Button.Visible = false;

step12Button.Size = new Size(stepButtonWidth, stepButtonHeight);
step12Button.Location = new Point(0, stepButtonHeight * 11);
step12Button.BackColor = sideColor;
step12Button.FlatAppearance.MouseOverBackColor = bkgrdColor;
step12Button.ForeColor = lighttextColor;
step12Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
step12Button.FlatAppearance.BorderSize = 0;
step12Button.Text = screenList[11];
step12Button.Font = sidePanelFont;
step12Button.TextAlign = ContentAlignment.TopLeft;
step12Button.TabStop = false;
step12Button.Visible = false;

// Save Button
saveButton.ImageIndex = 0;
saveButton.Size = new Size(25,25);
saveButton.Location = new Point(0,12);
saveButton.Visible = false;
saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
saveButton.FlatAppearance.BorderSize = 0;
saveButton.TabStop = false;

saveButton.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    saveButton.ImageIndex = 1;
    saveButton.FlatAppearance.BorderSize = 0;
};

saveButton.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    saveButton.ImageIndex = 0;
    saveButton.FlatAppearance.BorderSize = 0;
};

// Export Script Button
exportscriptButton.ImageIndex = 2;
exportscriptButton.Size = new Size(25,25);
exportscriptButton.Location = new Point(3,10);
exportscriptButton.Visible = false;
exportscriptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
exportscriptButton.FlatAppearance.BorderSize = 0;
exportscriptButton.TabStop = false;

exportscriptButton.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    exportscriptButton.ImageIndex = 3;
    exportscriptButton.FlatAppearance.BorderSize = 0;
};

exportscriptButton.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    exportscriptButton.ImageIndex = 2;
    exportscriptButton.FlatAppearance.BorderSize = 0;
};

// Reco Button
recoButton.ImageIndex = 4;
recoButton.Visible = false;
recoButton.Size = new Size(25,25);
recoButton.Location = new Point(25,12);
recoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
recoButton.FlatAppearance.BorderSize = 0;
recoButton.TabStop = false;

recoButton.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    recoButton.ImageIndex = 5;
    recoButton.FlatAppearance.BorderSize = 0;
};

recoButton.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    recoButton.ImageIndex = 4;
    recoButton.FlatAppearance.BorderSize = 0;
};

// Erase Button
eraseButton.ImageIndex = 6;
eraseButton.Visible = false;
eraseButton.Size = new Size(25,25);
eraseButton.Location = new Point(50,12);
eraseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
eraseButton.FlatAppearance.BorderSize = 0;
eraseButton.TabStop = false;

eraseButton.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    eraseButton.ImageIndex = 7;
    eraseButton.FlatAppearance.BorderSize = 0;
};

eraseButton.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    eraseButton.ImageIndex = 6;
    eraseButton.FlatAppearance.BorderSize = 0;
};

// Step Button Event Handlers
topButton.Click += (System.Object sender, System.EventArgs e) => {

    System.Diagnostics.Process.Start("http://www.elegantbi.com");
};

step1Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
      step1Button.ForeColor = darktextColor;
};

step1Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step1Button.BackColor == sideColor)
    {
        step1Button.ForeColor = lighttextColor;
    }
};

step2Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step2Button.ForeColor = darktextColor;
};

step2Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step2Button.BackColor == sideColor)
    {
        step2Button.ForeColor = lighttextColor;
    }
};

step3Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step3Button.ForeColor = darktextColor;
};

step3Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step3Button.BackColor == sideColor)
    {
        step3Button.ForeColor = lighttextColor;
    }
};

step4Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step4Button.ForeColor = darktextColor;
};

step4Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step4Button.BackColor == sideColor)
    {
        step4Button.ForeColor = lighttextColor;
    }
};

step5Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step5Button.ForeColor = darktextColor;
};

step5Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step5Button.BackColor == sideColor)
    {
        step5Button.ForeColor = lighttextColor;
    }
};

step6Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step6Button.ForeColor = darktextColor;
};

step6Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step6Button.BackColor == sideColor)
    {
        step6Button.ForeColor = lighttextColor;
    }
};

step7Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step7Button.ForeColor = darktextColor;
};

step7Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step7Button.BackColor == sideColor)
    {
        step7Button.ForeColor = lighttextColor;
    }
};

step8Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step8Button.ForeColor = darktextColor;
};

step8Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step8Button.BackColor == sideColor)
    {
        step8Button.ForeColor = lighttextColor;
    }
};

step9Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step9Button.ForeColor = darktextColor;
};

step9Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step9Button.BackColor == sideColor)
    {
        step9Button.ForeColor = lighttextColor;
    }
};

step10Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step10Button.ForeColor = darktextColor;
};

step10Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step10Button.BackColor == sideColor)
    {
        step10Button.ForeColor = lighttextColor;
    }
};

step11Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step11Button.ForeColor = darktextColor;
};

step11Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step11Button.BackColor == sideColor)
    {
        step11Button.ForeColor = lighttextColor;
    }
};

step12Button.MouseEnter += (System.Object sender, System.EventArgs e) => {
      
    step12Button.ForeColor = darktextColor;
};

step12Button.MouseLeave += (System.Object sender, System.EventArgs e) => {
      
    if (step12Button.BackColor == sideColor)
    {
        step12Button.ForeColor = lighttextColor;
    }
};

// Main Screen Parameters
int labelWidth = 55;
int labelHeight = 15;
int labelGap = 5;
int modelButtonWidth = 250;
int buttonWidth = 100;   
int buttonHeight = 40;    
int startScreenX = (formWidth / 2) - (modelButtonWidth / 2);
int startScreenY = (formHeight / 2) - (buttonHeight * 2); 
bool IsExpOrCol = false;
int thirdSectionX = (2*gap)+treeViewWidth;
int thirdSectionHeight = 280;
int thirdSectionWidth = treeViewWidth - 15;

// Tree Views
step1treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step1treeView.Location = new Point(0,0);
step1treeView.CheckBoxes = false;
step1treeView.StateImageList = new System.Windows.Forms.ImageList();
step1treeView.BackColor = treeViewBkgrdColor;
step1treeView.Visible = false;

step2treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step2treeView.Location = new Point(0,0);
step2treeView.CheckBoxes = false;
step2treeView.StateImageList = new System.Windows.Forms.ImageList();
step2treeView.BackColor = treeViewBkgrdColor;
step2treeView.Visible = false;

step3treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step3treeView.Location = new Point(0,0);
step3treeView.CheckBoxes = false;
step3treeView.BackColor = treeViewBkgrdColor;
step3treeView.Visible = false;
step3treeView.HideSelection = false;

step4treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step4treeView.Location = new Point(0,0);
step4treeView.CheckBoxes = false;
step4treeView.StateImageList = new System.Windows.Forms.ImageList();
step4treeView.BackColor = treeViewBkgrdColor;
step4treeView.Visible = false;

step5treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step5treeView.Location = new Point(0,0);
step5treeView.CheckBoxes = false;
step5treeView.StateImageList = new System.Windows.Forms.ImageList();
step5treeView.BackColor = treeViewBkgrdColor;
step5treeView.Visible = false;

step6treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step6treeView.Location = new Point(0,0);
step6treeView.CheckBoxes = false;
step6treeView.StateImageList = new System.Windows.Forms.ImageList();
step6treeView.BackColor = treeViewBkgrdColor;
step6treeView.Visible = false;
step6treeView.HideSelection = false;

step7treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step7treeView.Location = new Point(0,0);
step7treeView.CheckBoxes = false;
step7treeView.BackColor = treeViewBkgrdColor;
step7treeView.Visible = false;
step7treeView.HideSelection = false;

step8treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step8treeView.Location = new Point(0,0);
step8treeView.CheckBoxes = false;
step8treeView.BackColor = treeViewBkgrdColor;
step8treeView.Visible = false;
step8treeView.HideSelection = false;

step9treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step9treeView.Location = new Point(0,0);
step9treeView.CheckBoxes = false;
step9treeView.BackColor = treeViewBkgrdColor;
step9treeView.Visible = false;
step9treeView.HideSelection = false;

step10treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step10treeView.Location = new Point(0,0);
step10treeView.CheckBoxes = false;
step10treeView.BackColor = treeViewBkgrdColor;
step10treeView.Visible = false;

step11treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step11treeView.Location = new Point(0,0);
step11treeView.CheckBoxes = false;
step11treeView.BackColor = treeViewBkgrdColor;
step11treeView.Visible = false;
step11treeView.HideSelection = false;

step12treeView.Size = new Size(treeViewWidth ,treeViewHeight);
step12treeView.Location = new Point(0,0);
step12treeView.CheckBoxes = false;
step12treeView.BackColor = treeViewBkgrdColor;
step12treeView.Visible = false;
step12treeView.HideSelection = false;

// Filters Tree View
filtersTreeView.Size = new Size(thirdSectionWidth,treeViewHeight);
filtersTreeView.Location = new Point(0,0);
filtersTreeView.CheckBoxes = true;
filtersTreeView.BackColor = treeViewBkgrdColor;
filtersTreeView.Visible = false;
filtersTreeView.HideSelection = false;

// Add Images for Tri-State TreeView
string[] stateimageURLList = { "Unchecked", "Checked", "PartiallyChecked" };
for (int i = 0; i < stateimageURLList.Count(); i++)
{
    var url = urlPrefix + stateimageURLList[i] + urlSuffix;      
    byte[] imageByte = w.DownloadData(url);
    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageByte);
    System.Drawing.Image im = System.Drawing.Image.FromStream(ms);
    step1treeView.StateImageList.Images.Add(im);
    step2treeView.StateImageList.Images.Add(im);
    step4treeView.StateImageList.Images.Add(im);
    step5treeView.StateImageList.Images.Add(im);
    step6treeView.StateImageList.Images.Add(im);
}  

modelnameLabel.Size = new Size(labelWidth,labelHeight);
modelnameLabel.Location = new Point(0,topLeftPanelHeight-50);
modelnameLabel.Font = sidePanelFont;
modelnameLabel.TextAlign = ContentAlignment.MiddleLeft;
modelnameLabel.Text = "Name:";
modelnameLabel.Visible = false;

modelnameTextBox.Size = new Size(treeViewWidth - labelWidth - labelGap,labelHeight);
modelnameTextBox.Location = new Point(labelWidth + labelGap,topLeftPanelHeight-50);
modelnameTextBox.Font = sidePanelFont;
modelnameTextBox.Visible = false;

int infoLabelY = topLeftPanelHeight-22;
infoLabel.Size = new Size(treeViewWidth,20);
infoLabel.Location = new Point(0,infoLabelY);
infoLabel.Font = sidePanelFont;
infoLabel.Visible = false;

// New Model Button
newmodelButton.Size = new Size(modelButtonWidth,buttonHeight);
newmodelButton.Location = new Point(startScreenX,startScreenY);
newmodelButton.Text = "Create New Mini Model";
newmodelButton.Font = sidePanelFont;

// Existing Model Button
existingmodelButton.Size = new Size(modelButtonWidth,buttonHeight);
existingmodelButton.Location = new Point(startScreenX,startScreenY+30);
existingmodelButton.Text = "Modify Existing Mini Model";
existingmodelButton.Font = sidePanelFont;

// toolNameLabel
toolNameLabel.Size = new Size(400,60);
toolNameLabel.Location = new Point(345,130);
toolNameLabel.Text = "Mini Model Builder";
toolNameLabel.Font = toolNameFont;

// MM Combo Box
mmComboBox.Visible = false;
mmComboBox.Size = new Size(buttonWidth+70,buttonHeight+10);
mmComboBox.Location = new Point(startScreenX+14,startScreenY+80);
mmComboBox.Font = sidePanelFont;

// Start Step 1 Button (Go)
startstep1Button.Size = new Size(120,30);
startstep1Button.Text = "Go";
startstep1Button.Visible = false;
startstep1Button.Enabled = false; 

int startstepButtonX = 145;
int startstepButtonY = topLeftPanelHeight-50;
int startstepButtonWidth = 80;
int startstepButtonHeight = 25;
int topRightLabelY = 43;

// Next Step Button
nextstepButton.Size = new Size(startstepButtonWidth,startstepButtonHeight);
nextstepButton.Location = new Point(startstepButtonX,startstepButtonY);
nextstepButton.Visible = false;
nextstepButton.Enabled = true; 

// Old DAX Label
oldDAXLabel.Size = new Size(150,20);
oldDAXLabel.Location = new Point(0,topRightLabelY);
oldDAXLabel.Text = "Original DAX";
oldDAXLabel.Font = sidePanelFont;
oldDAXLabel.Visible = false;

// New DAX Label
newDAXLabel.Size = new Size(72,20);
newDAXLabel.Location = new Point(0,thirdSectionHeight+6);
newDAXLabel.Text = "New DAX";
newDAXLabel.Font = sidePanelFont;
newDAXLabel.Visible = false;

// Old DAX Text Box
oldDAXTextBox.Size = new Size(rightPanelWidth,thirdSectionHeight);
oldDAXTextBox.Location = new Point(0,0);
oldDAXTextBox.ReadOnly = true;
oldDAXTextBox.Multiline = true;
oldDAXTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
oldDAXTextBox.Visible = false;

// New DAX Text Box
newDAXTextBox.Size = new Size(rightPanelWidth,thirdSectionHeight);
newDAXTextBox.Location = new Point(0,thirdSectionHeight+26);
newDAXTextBox.ReadOnly = true;
newDAXTextBox.Multiline = true;
newDAXTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
newDAXTextBox.Visible = false;

int queryTextBoxHeight = thirdSectionHeight - 46;

// Old Query Label
oldqueryLabel.Size = new Size(180,20);
oldqueryLabel.Location = new Point(0,topRightLabelY);
oldqueryLabel.Text = "Original Partition Query";
oldqueryLabel.Font = sidePanelFont;
oldqueryLabel.Visible = false;

// New Query Label
newqueryLabel.Size = new Size(180,20);
newqueryLabel.Location = new Point(0,queryTextBoxHeight+5);
newqueryLabel.Text = "New Partition Query";
newqueryLabel.Font = sidePanelFont;
newqueryLabel.Visible = false;

// Old Query Text Box
oldqueryTextBox.Size = new Size(rightPanelWidth,queryTextBoxHeight);
oldqueryTextBox.Location = new Point(0,0);
oldqueryTextBox.ReadOnly = true;
oldqueryTextBox.Multiline = true;
oldqueryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
oldqueryTextBox.Visible = false;

// New Query Text Box
newqueryTextBox.Size = new Size(rightPanelWidth,queryTextBoxHeight);
newqueryTextBox.Location = new Point(0,25+queryTextBoxHeight);
newqueryTextBox.ReadOnly = true;
newqueryTextBox.Multiline = true;
newqueryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
newqueryTextBox.Visible = false;

int findLabelY = (queryTextBoxHeight*2)+30;
int findTextBoxHeight = 20;
// Find Label
findLabel.Size = new Size(150,20);
findLabel.Location = new Point(0,findLabelY);
findLabel.Text = "Find Text";
findLabel.Font = sidePanelFont;
findLabel.Visible = false;

// Replace Label
replaceLabel.Size = new Size(150,20);
replaceLabel.Location = new Point(0,findLabelY+45);
replaceLabel.Text = "Replace Text";
replaceLabel.Font = sidePanelFont;
replaceLabel.Visible = false;

// Find Text Box
findTextBox.Size = new Size(rightPanelWidth,findTextBoxHeight);
findTextBox.Location = new Point(0,findLabelY+20);
findTextBox.ReadOnly = true;
findTextBox.Visible = false;

// Replace Text Box
replaceTextBox.Size = new Size(rightPanelWidth,findTextBoxHeight);
replaceTextBox.Location = new Point(0,findLabelY+47+findTextBoxHeight);
replaceTextBox.ReadOnly = true;
replaceTextBox.Visible = false;

int roleTextBoxHeight = 235;
// Old Role Label
oldroleLabel.Size = new Size(180,20);
oldroleLabel.Location = new Point(0,topRightLabelY);
oldroleLabel.Text = "Original Role Members";
oldroleLabel.Font = sidePanelFont;
oldroleLabel.Visible = false;

// New Role Label
newroleLabel.Size = new Size(180,20);
newroleLabel.Location = new Point(0,roleTextBoxHeight+5);
newroleLabel.Text = "New Role Members";
newroleLabel.Font = sidePanelFont;
newroleLabel.Visible = false;

// Old Role Text Box
oldroleTextBox.Size = new Size(rightPanelWidth,roleTextBoxHeight);
oldroleTextBox.Location = new Point(0,0);
oldroleTextBox.ReadOnly = true;
oldroleTextBox.Multiline = true;
oldroleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
oldroleTextBox.Visible = false;

// New Role Text Box
newroleTextBox.Size = new Size(rightPanelWidth,roleTextBoxHeight);
newroleTextBox.Location = new Point(0,25+roleTextBoxHeight);
newroleTextBox.ReadOnly = true;
newroleTextBox.Multiline = true;
newroleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
newroleTextBox.Visible = false;

int oldmpLabelY = 31+(roleTextBoxHeight*2);
// Old MP Label
oldmpLabel.Size = new Size(220,20);
oldmpLabel.Location = new Point(0,oldmpLabelY);
oldmpLabel.Text = "Original Model Permission";
oldmpLabel.Font = sidePanelFont;
oldmpLabel.Visible = false;

// New MP Label
newmpLabel.Size = new Size(220,20);
newmpLabel.Location = new Point(0,oldmpLabelY+45);
newmpLabel.Text = "New Model Permission";
newmpLabel.Font = sidePanelFont;
newmpLabel.Visible = false;

// Old MP Combo Box
oldmpComboBox.Size = new Size(rightPanelWidth,findTextBoxHeight);
oldmpComboBox.Location = new Point(0,oldmpLabelY+20);
oldmpComboBox.Enabled = false;
oldmpComboBox.Visible = false;

// Old MP Combo Box
newmpComboBox.Size = new Size(rightPanelWidth,findTextBoxHeight);
newmpComboBox.Location = new Point(0,oldmpLabelY+65);
newmpComboBox.Enabled = false;
newmpComboBox.Visible = false;

// Old RLS Label
oldrlsLabel.Size = new Size(150,20);
oldrlsLabel.Location = new Point(0,topRightLabelY);
oldrlsLabel.Text = "Original RLS";
oldrlsLabel.Font = sidePanelFont;
oldrlsLabel.Visible = false;

// New RLS Label
newrlsLabel.Size = new Size(150,20);
newrlsLabel.Location = new Point(0,thirdSectionHeight+6);
newrlsLabel.Text = "New RLS";
newrlsLabel.Font = sidePanelFont;
newrlsLabel.Visible = false;

// Old RLS Text Box
oldrlsTextBox.Size = new Size(rightPanelWidth,thirdSectionHeight);
oldrlsTextBox.Location = new Point(0,0);
oldrlsTextBox.ReadOnly = true;
oldrlsTextBox.Multiline = true;
oldrlsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
oldrlsTextBox.Visible = false;

// New RLS Text Box
newrlsTextBox.Size = new Size(rightPanelWidth,thirdSectionHeight);
newrlsTextBox.Location = new Point(0,thirdSectionHeight+26);
newrlsTextBox.ReadOnly = true;
newrlsTextBox.Multiline = true;
newrlsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
newrlsTextBox.Visible = false;

// Old DS Label
olddsLabel.Size = new Size(220,20);
olddsLabel.Location = new Point(0,topRightLabelY);
olddsLabel.Text = "Original Data Source";
olddsLabel.Font = sidePanelFont;
olddsLabel.Visible = false;

// New DS Label
newdsLabel.Size = new Size(220,20);
newdsLabel.Location = new Point(0,25);
newdsLabel.Text = "New Data Source";
newdsLabel.Font = sidePanelFont;
newdsLabel.Visible = false;

// Old DS Combo Box
olddsComboBox.Size = new Size(rightPanelWidth,20);
olddsComboBox.Location = new Point(0,0);
olddsComboBox.Enabled = false;
olddsComboBox.Visible = false;

// New DS Combo Box
newdsComboBox.Size = new Size(rightPanelWidth,20);
newdsComboBox.Location = new Point(0,50);
newdsComboBox.Enabled = false;
newdsComboBox.Visible = false;

// Filters Label
filtersLabel.Size = new Size(390,20);
filtersLabel.Location = new Point(0,topRightLabelY);
filtersLabel.Text = "Uncheck a column value to filter it out of the model.";
filtersLabel.Font = sidePanelFont;
filtersLabel.Visible = false;

// Agg Label
aggLabel.Size = new Size(390,20);
aggLabel.Location = new Point(0,topRightLabelY);
aggLabel.Text = "Aggregation Column                            Summarization";
aggLabel.Font = sidePanelFont;
aggLabel.Visible = false;

string perspName = string.Empty;

// Lambda expression for all the steps to next page
System.Action<int> NextStep = stepNumber =>
{
    if (existingmodelButton.Checked == true)
    {
        perspName = mmComboBox.Text;
        modelnameTextBox.Text = mmComboBox.Text;
        modelnameTextBox.Enabled = false;
    }
    else
    {
        perspName = modelnameTextBox.Text;
    }
    if (stepNumber > 1 || perspName != string.Empty)
    {
        modelnameTextBox.Enabled = false;
    }
    nextstepButton.Visible = true;
    if (stepNumber < 12)
    {
        nextstepButton.Text = "Next";
        saveButton.Visible = true;
    }
    else
    {
        nextstepButton.Text = "Finish";
    }
    if (perspName == string.Empty && stepNumber > 1)
    {
        // Invalid perspective name
        Error("Must enter a name for your mini model.");
        modelnameTextBox.Enabled = true;
    }
    
    else
    {
        step1Button.BackColor = sideColor;
        step1Button.ForeColor = lighttextColor;
        step2Button.BackColor = sideColor;
        step2Button.ForeColor = lighttextColor;
        step3Button.BackColor = sideColor;
        step3Button.ForeColor = lighttextColor;
        step4Button.BackColor = sideColor;
        step4Button.ForeColor = lighttextColor;
        step5Button.BackColor = sideColor;
        step5Button.ForeColor = lighttextColor;
        step6Button.BackColor = sideColor;
        step6Button.ForeColor = lighttextColor;
        step7Button.BackColor = sideColor;
        step7Button.ForeColor = lighttextColor;
        step8Button.BackColor = sideColor;
        step8Button.ForeColor = lighttextColor;
        step9Button.BackColor = sideColor;
        step9Button.ForeColor = lighttextColor;
        step10Button.BackColor = sideColor;
        step10Button.ForeColor = lighttextColor;
        step11Button.BackColor = sideColor;
        step11Button.ForeColor = lighttextColor;
        step12Button.BackColor = sideColor;
        step12Button.ForeColor = lighttextColor;
        step1treeView.Visible = false;
        step2treeView.Visible = false;
        step3treeView.Visible = false;
        step4treeView.Visible = false;
        step5treeView.Visible = false;
        step6treeView.Visible = false;
        step7treeView.Visible = false;
        step8treeView.Visible = false;
        step9treeView.Visible = false;
        step10treeView.Visible = false;
        step11treeView.Visible = false;
        step12treeView.Visible = false;
        oldDAXLabel.Visible = false;
        newDAXLabel.Visible = false;
        oldDAXTextBox.Visible = false;
        newDAXTextBox.Visible = false;
        oldqueryLabel.Visible = false;
        newqueryLabel.Visible = false;
        oldqueryTextBox.Visible = false;
        newqueryTextBox.Visible = false;
        findLabel.Visible = false;
        replaceLabel.Visible = false;
        findTextBox.Visible = false;
        replaceTextBox.Visible = false;
        oldroleLabel.Visible = false;
        newroleLabel.Visible = false;
        oldroleTextBox.Visible = false;
        newroleTextBox.Visible = false;
        oldmpLabel.Visible = false;
        newmpLabel.Visible = false;
        oldmpComboBox.Visible = false;
        newmpComboBox.Visible = false;
        oldrlsLabel.Visible = false;
        newrlsLabel.Visible = false;
        oldrlsTextBox.Visible = false;
        newrlsTextBox.Visible = false;
        olddsLabel.Visible = false;
        newdsLabel.Visible = false;
        olddsComboBox.Visible = false;
        newdsComboBox.Visible = false;
        filtersLabel.Visible = false;
        filtersTreeView.Visible = false;
        aggLabel.Visible = false;
        rightPanel.Visible = true;
        rightPanel2.Visible = false;
        recoButton.Visible = false;
        eraseButton.Visible = false;

        if (stepNumber == 1)
        {
            infoLabel.Text = infoLabelText[0];
            newmodelButton.Visible = false;
            existingmodelButton.Visible = false;
            mmComboBox.Visible = false;
            midPanel.Visible = true;
            topMidPanel.Visible = true;
            sidePanel.Visible = true;
            topLeftPanel.Visible = true;            
            topRightPanel.Visible = true;
            rightPanel.Visible = true;
            modelnameLabel.Visible = true;
            modelnameTextBox.Visible = true;
            infoLabel.Visible = true;
            topButton.Visible = true;
            step1Button.Visible = true;
            step2Button.Visible = true;
            step3Button.Visible = true;
            step4Button.Visible = true;
            step5Button.Visible = true;
            step6Button.Visible = true;
            step7Button.Visible = true;
            step8Button.Visible = true;
            step9Button.Visible = true;
            step10Button.Visible = true;
            step11Button.Visible = true;
            step12Button.Visible = true;
            step1Button.BackColor = bkgrdColor;
            step1Button.ForeColor = darktextColor;
            step1treeView.Visible = true;    
            if (modelnameTextBox.Text == string.Empty)
            {
                modelnameTextBox.Enabled = true;
            }
            else
            {
                modelnameTextBox.Enabled = false;
            }       

            step1treeView.Nodes.Clear();
            // Add nodes to treeview
            foreach (var t in Model.Tables.Where(a => a.IsHidden == false).OrderBy(a => a.Name).ToList())
            {  
                // Add table nodes
                var tableName = t.Name;    
                var tn = step1treeView.Nodes.Add(tableName);
                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 0;
                tn.StateImageIndex = 0;    
                
                // Add column sub-nodes
                foreach (var c in t.Columns.Where(a => a.IsHidden == false).OrderBy(a => a.Name).ToList())
                {
                    var columnName = c.Name;
                    var x = tn.Nodes.Add(columnName);  

                    if (c.Type.ToString() == "Calculated")
                    {
                        x.ImageIndex = 4;
                        x.SelectedImageIndex = 4;
                    }
                    else
                    {
                        x.ImageIndex = 1;
                        x.SelectedImageIndex = 1;
                    }      

                    x.StateImageIndex = 0;        
                }
                
                // Add measure sub-nodes
                foreach (var m in t.Measures.Where(a => a.IsHidden == false).OrderBy(a => a.Name).ToList())
                {
                    var measureName = m.Name;
                    var x = tn.Nodes.Add(measureName);        
                    x.ImageIndex = 2;
                    x.SelectedImageIndex = 2;
                    x.StateImageIndex = 0;        
                }   
               
                // Add hierarchy sub-nodes
                foreach (var h in t.Hierarchies.Where(a => a.IsHidden == false).OrderBy(a => a.Name).ToList())
                {
                    string hierarchyName = h.Name;
                    var x = tn.Nodes.Add(hierarchyName); 
                    x.ImageIndex = 3;
                    x.SelectedImageIndex = 3;   
                    x.StateImageIndex = 0;            
                }        
            }    

            // Populate tree from perspective if modifying existing mini model
            if (perspName != string.Empty)
            {     
                foreach (System.Windows.Forms.TreeNode rootNode in step1treeView.Nodes)
                {
                     string tableName = rootNode.Text;             
                 
                     int childNodeCount = rootNode.Nodes.Count;   
                     int childNodeCheckedCount = 0;  
                     // Loop through checked child nodes (columns, measures, hierarchies)
                     foreach (System.Windows.Forms.TreeNode childNode in rootNode.Nodes)
                     {
                         var objectName = childNode.Text;
                         
                         if (childNode.ImageIndex == 1)
                         {
                             if (Model.Tables[tableName].Columns[objectName].InPerspective[perspName] == true)
                             {
                                 childNode.StateImageIndex = 1;
                                 childNodeCheckedCount+=1;
                             }
                         }
                         else if (childNode.ImageIndex == 2)
                         {
                             if (Model.Tables[tableName].Measures[objectName].InPerspective[perspName] == true)
                             {
                                 childNode.StateImageIndex = 1;
                                 childNodeCheckedCount+=1;
                             }
                         }
                         else if (childNode.ImageIndex == 3)
                         {
                             if (Model.Tables[tableName].Hierarchies[objectName].InPerspective[perspName] == true)
                             {
                                 childNode.StateImageIndex = 1;
                                 childNodeCheckedCount+=1;
                             }
                         }
                     }
                                 
                    // If all child nodes are checked, set parent node to checked
                    if (childNodeCheckedCount == childNodeCount)
                    {
                        rootNode.StateImageIndex = 1;
                    }
                    // If no child nodes are checked, set parent node to unchecked
                    else if (childNodeCheckedCount == 0)
                    {
                        rootNode.StateImageIndex = 0;
                    }
                    // If not all children nodes are selected, set parent node to partially checked icon
                    else if (childNodeCheckedCount < childNodeCount)
                    {
                        rootNode.StateImageIndex = 2;
                    }
                }
            }  
        }
        else if (stepNumber == 2)
        {
            infoLabel.Text = infoLabelText[1];
            step2Button.BackColor = bkgrdColor;
            step2Button.ForeColor = darktextColor;
            step2treeView.Visible = true;
            
            step2treeView.Nodes.Clear();
            // Create Tree View for Step 2
            int i=0;
            foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
            {  
                string annH = perspName+"_Hide";
                string annU = perspName+"_Unhide";
                string tableName = t.Name;    
                var tn = step2treeView.Nodes.Add(tableName);
                tn.ImageIndex = 0;        
                tn.SelectedImageIndex = 0;
                
                var tbl = Model.Tables[tableName];
                
                if (tbl.IsVisible == false)
                {
                    tn.ForeColor = hiddenColor;
                }

                if (tbl.HasAnnotation(annH))
                {
                    tn.StateImageIndex = 1;
                    tn.ForeColor = hiddenColor;
                } 
                else if (tbl.HasAnnotation(annU))
                {
                    tn.StateImageIndex = 1;
                    tn.ForeColor = visibleColor;
                }
                else
                {
                    tn.StateImageIndex = 0;
                }                  
                
                int childNodeCheckedCount = 0;        
                
                // Add column sub-nodes
                foreach (var c in t.Columns.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
                {
                    var columnName = c.Name;
                    var x = step2treeView.Nodes[i].Nodes.Add(columnName);  

                    if (c.Type.ToString() == "Calculated")
                    {
                        x.ImageIndex = 4;
                        x.SelectedImageIndex = 4;
                    }
                    else
                    {
                        x.ImageIndex = 1;
                        x.SelectedImageIndex = 1;
                    }
                    
                    var obj = Model.Tables[tableName].Columns[columnName];
                 
                    if (obj.IsVisible == false)
                    {
                        x.ForeColor = hiddenColor;
                    } 

                    if (obj.HasAnnotation(annH))
                    {
                        x.StateImageIndex = 1;
                        x.ForeColor = hiddenColor;
                        childNodeCheckedCount+=1;
                    }
                    else if (obj.HasAnnotation(annU))
                    {
                        x.StateImageIndex = 1;
                        x.ForeColor = visibleColor;
                        childNodeCheckedCount+=1;
                    }
                    else
                    {
                        x.StateImageIndex = 0;
                    }                         
                }
                
                // Add measure sub-nodes
                foreach (var m in t.Measures.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
                {
                    var measureName = m.Name;
                    var x = step2treeView.Nodes[i].Nodes.Add(measureName);        
                    x.ImageIndex = 2;
                    x.SelectedImageIndex = 2;            
                    
                    var obj = Model.Tables[tableName].Measures[measureName];
                    
                    if (obj.IsVisible == false)
                    {
                        x.ForeColor = hiddenColor;
                    } 

                    if (obj.HasAnnotation(annH))
                    {
                        x.StateImageIndex = 1;
                        x.ForeColor = hiddenColor;
                        childNodeCheckedCount+=1;
                    }
                    else if (obj.HasAnnotation(annU))
                    {
                        x.StateImageIndex = 1;
                        x.ForeColor = visibleColor;
                        childNodeCheckedCount+=1;
                    }
                    else
                    {
                        x.StateImageIndex = 0;
                    }                     
                }   
               
                // Add hierarchy sub-nodes
                foreach (var h in t.Hierarchies.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
                {
                    var hierarchyName = h.Name;
                    var x = step2treeView.Nodes[i].Nodes.Add(hierarchyName); 
                    x.ImageIndex = 3;
                    x.SelectedImageIndex = 3;   
                     
                    var obj = Model.Tables[tableName].Hierarchies[hierarchyName];
                    
                    if (obj.IsVisible == false)
                    {
                        x.ForeColor = hiddenColor;
                    } 

                    if (obj.HasAnnotation(annH))
                    {
                        x.StateImageIndex = 1;
                        x.ForeColor = hiddenColor;
                        childNodeCheckedCount+=1;
                    }
                    else if (obj.HasAnnotation(annU))
                    {
                        x.StateImageIndex = 1;
                        x.ForeColor = visibleColor;
                        childNodeCheckedCount+=1;
                    }
                    else
                    {
                        x.StateImageIndex = 0;
                    }       
                }  
                        
                int childNodeCount = step2treeView.Nodes[i].Nodes.Count;
                
                // If all child nodes are checked, set parent node to checked
                if (childNodeCheckedCount == childNodeCount)
                {
                    step2treeView.Nodes[i].StateImageIndex = 1;
                }
                // If no child nodes are checked, set parent node to unchecked
                else if (childNodeCheckedCount == 0)
                {
                    step2treeView.Nodes[i].StateImageIndex = 0;
                }
                // If not all children nodes are selected, set parent node to partially checked icon
                else if (childNodeCheckedCount < childNodeCount)
                {
                    step2treeView.Nodes[i].StateImageIndex = 2;
                }
                    
                i++;
            }      
        }

        else if (stepNumber == 3)
        {
            infoLabel.Text = infoLabelText[2];
            step3Button.BackColor = bkgrdColor;
            step3Button.ForeColor = darktextColor;
            step3treeView.Visible = true;
            oldDAXLabel.Visible = true;
            newDAXLabel.Visible = true;
            oldDAXTextBox.Visible = true;
            newDAXTextBox.Visible = true;    

            oldDAXTextBox.Text = string.Empty;
            newDAXTextBox.Text = string.Empty;
            step3treeView.Nodes.Clear();
            // Add nodes to treeview 
            string ann = perspName+"_Expression";      
            foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName] && (a.Measures.Where(b => b.InPerspective[perspName]).Count() > 0 || a.Columns.Where(b => b.InPerspective[perspName] && b.Type.ToString() == "Calculated").Count() > 0)).OrderBy(a => a.Name).ToList())
            {  
                // Add table nodes
                var tableName = t.Name;    
                var tn = step3treeView.Nodes.Add(tableName);
                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 0;

                var tbl = Model.Tables[tableName];
                    
                if (tbl.IsHidden)
                {
                    tn.ForeColor = hiddenColor;
                }
            
                // Add column sub-nodes
                foreach (var c in t.Columns.Where(a => a.InPerspective[perspName] && a.Type.ToString() == "Calculated").OrderBy(a => a.Name).ToList())
                {
                    var columnName = c.Name;
                    var x = tn.Nodes.Add(columnName);         
                              
                    var obj = Model.Tables[tableName].Columns[columnName];
                    
                    if (obj.IsHidden)
                    {
                        x.ForeColor = hiddenColor;
                    }
                    
                    if (obj.HasAnnotation(ann))
                    {
                        x.ImageIndex = 5;
                        x.SelectedImageIndex = 5; 
                    }
                    else
                    {
                        x.ImageIndex = 4;
                        x.SelectedImageIndex = 4;
                    }
                }
                    
                // Add measure sub-nodes
                foreach (var m in t.Measures.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
                {
                    var measureName = m.Name;
                    var x = tn.Nodes.Add(measureName);                    
                    
                    var obj = Model.Tables[tableName].Measures[measureName];
                    
                    if (obj.IsHidden)
                    {
                        x.ForeColor = hiddenColor;
                    } 
                    
                    if (obj.HasAnnotation(ann))
                    {
                        x.ImageIndex = 6;
                        x.SelectedImageIndex = 6; 
                    }
                    else
                    {
                        x.ImageIndex = 2;
                        x.SelectedImageIndex = 2;
                    }
                }  
            } 
        }

        else if (stepNumber == 4)
        {
            infoLabel.Text = infoLabelText[3];    
            step4Button.BackColor = bkgrdColor;
            step4Button.ForeColor = darktextColor;
            step4treeView.Visible = true;
            oldDAXLabel.Visible = false;
            newDAXLabel.Visible = false;
            oldDAXTextBox.Visible = false;
            newDAXTextBox.Visible = false;

            step4treeView.Nodes.Clear();
            string ann = perspName+"_Remove";
            // Add nodes to treeview      
            foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName] && a.Partitions.Count() > 1).OrderBy(a => a.Name).ToList())
            {  
                // Add table nodes
                string tableName = t.Name;    
                var tn = step4treeView.Nodes.Add(tableName);
                tn.StateImageIndex = 0;      
                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 0;
                
                int childNodeCheckedCount = 0;
                int childNodeCount = Model.Tables[tableName].Partitions.Count();
                
                // Add partition sub-nodes
                foreach (var p in t.Partitions.OrderBy(a => a.Name).ToList())
                {
                    string partitionName = p.Name;
                    var x = tn.Nodes.Add(partitionName);         
                    x.StateImageIndex = 0;
                    x.ImageIndex = 7;
                    x.SelectedImageIndex = 7;            
                                          
                    if (p.HasAnnotation(ann))
                    {
                        x.StateImageIndex = 1;  
                        childNodeCheckedCount+=1;
                    }
                }               
                          
                // Finish populating tree root nodes (tables)
                // If all child nodes are checked, set parent node to checked
                if (childNodeCheckedCount == childNodeCount)
                {
                    tn.StateImageIndex = 1;
                }
                // If no child nodes are checked, set parent node to unchecked
                else if (childNodeCheckedCount == 0)
                {
                    tn.StateImageIndex = 0;
                }
                // If not all children nodes are selected, set parent node to partially checked icon
                else if (childNodeCheckedCount < childNodeCount)
                {
                    tn.StateImageIndex = 2;
                } 
            }
        }

        else if (stepNumber == 5)
        {
            infoLabel.Text = infoLabelText[4];
            step5Button.BackColor = bkgrdColor;
            step5Button.ForeColor = darktextColor;
            step5treeView.Visible = true;    
            
            step5treeView.Nodes.Clear();
            string ann = perspName+"_Remove";
            // Add nodes to treeview            
            foreach (var p in Model.Perspectives.OrderBy(a => a.Name).ToList())
            {  
                // Add table nodes
                string pName = p.Name;    
                var tn = step5treeView.Nodes.Add(pName);
                tn.ImageIndex = 8;
                tn.SelectedImageIndex = 8;

                if (p.HasAnnotation(ann))
                {
                    tn.StateImageIndex = 1;
                }
                else
                {
                    tn.StateImageIndex = 0;
                }
            }
        }

        else if (stepNumber == 6)
        {
            infoLabel.Text = infoLabelText[5];
            step6Button.BackColor = bkgrdColor;
            step6Button.ForeColor = darktextColor;
            step6treeView.Visible = true;
            oldqueryLabel.Visible = true;
            newqueryLabel.Visible = true;
            oldqueryTextBox.Visible = true;
            newqueryTextBox.Visible = true;
            findLabel.Visible = true;
            findTextBox.Visible = true;
            replaceLabel.Visible = true;
            replaceTextBox.Visible = true;  
            
            oldqueryTextBox.Text = string.Empty;
            newqueryTextBox.Text = string.Empty;
            findTextBox.Text = string.Empty;
            replaceTextBox.Text = string.Empty;
            step6treeView.Nodes.Clear();
            string ann = perspName+"_UpdatePartitionQuery";
            // Build tree view
            foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
            {        
                string tableName = t.Name;                               
                var tn = step6treeView.Nodes.Add(tableName);             
                tn.StateImageIndex = 0;
                
                if (t.HasAnnotation(ann))
                {
                    tn.ImageIndex = 9;
                    tn.SelectedImageIndex = 9;               
                }
                else
                {
                    tn.ImageIndex = 0;
                    tn.SelectedImageIndex = 0;   
                }
            }
        }

        else if (stepNumber == 7)
        {
            infoLabel.Text = infoLabelText[6];
            step7Button.BackColor = bkgrdColor;
            step7Button.ForeColor = darktextColor;
            step7treeView.Visible = true;
            oldroleLabel.Visible = true;
            newroleLabel.Visible = true;
            oldroleTextBox.Visible = true;
            newroleTextBox.Visible = true;
            oldmpLabel.Visible = true;
            newmpLabel.Visible = true;
            oldmpComboBox.Visible = true;
            newmpComboBox.Visible = true;

            oldroleTextBox.Text = string.Empty;
            newroleTextBox.Text = string.Empty;
            oldmpComboBox.Text = string.Empty;
            newmpComboBox.Text = string.Empty;            
            step7treeView.Nodes.Clear();
            // Populate tree view    
            string ann = perspName+"_UpdateRoleMembers";
            string ann2 = perspName+"_UpdateModelPermission";            

            foreach (var r in Model.Roles.OrderBy(a => a.Name).ToList())
            {
                string roleName = r.Name;
                var obj = Model.Roles[roleName];
                
                // Add nodes
                var x = step7treeView.Nodes.Add(roleName);             
                
                if (obj.HasAnnotation(ann) || obj.HasAnnotation(ann2))
                {
                    x.ImageIndex = 11;
                    x.SelectedImageIndex = 11;
                }
                else
                {
                    x.ImageIndex = 10;
                    x.SelectedImageIndex = 10;
                }
            }   
        }

        else if (stepNumber == 8)
        {
            infoLabel.Text = infoLabelText[7];
            step8Button.BackColor = bkgrdColor;
            step8Button.ForeColor = darktextColor;
            step8treeView.Visible = true;
            oldrlsLabel.Visible = true;
            newrlsLabel.Visible = true;
            oldrlsTextBox.Visible = true;
            newrlsTextBox.Visible = true;

            oldrlsTextBox.Text = string.Empty;
            newrlsTextBox.Text = string.Empty;
            step8treeView.Nodes.Clear();
            string ann = perspName+"_UpdateRLS_";

            // Populate Tree View
            foreach (var r in Model.Roles.OrderBy(a => a.Name).ToList())
            {
                string roleName = r.Name;                
                var rt = step8treeView.Nodes.Add(roleName);
                rt.ImageIndex = 10;
                rt.SelectedImageIndex = 10;

                foreach (var t in Model.Tables.Where(a => a.RowLevelSecurity[roleName] != null).OrderBy(a => a.Name).ToList())
                {
                    string tableName = t.Name;            
                    var rc = rt.Nodes.Add(tableName);
                    
                    if (r.HasAnnotation(ann+tableName))
                    {
                        rc.ImageIndex = 13;
                        rc.SelectedImageIndex = 13;
                    }
                    else
                    {
                        rc.ImageIndex = 12;
                        rc.SelectedImageIndex = 12;
                    }
                }
            }
        }

        else if (stepNumber == 9)
        {
            infoLabel.Text = infoLabelText[8];
            step9Button.BackColor = bkgrdColor;
            step9Button.ForeColor = darktextColor;
            step9treeView.Visible = true;
            olddsLabel.Visible = true;
            newdsLabel.Visible = true;
            olddsComboBox.Visible = true;
            newdsComboBox.Visible = true;

            olddsComboBox.Text = string.Empty;
            newdsComboBox.Text = string.Empty;
            step9treeView.Nodes.Clear();
            string ann = perspName+"_UpdateDataSource";
            
            // Populate Tree View
            foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
            {
                string tableName = t.Name;                
                var x = step9treeView.Nodes.Add(tableName);
                
                if (t.HasAnnotation(ann))
                {
                    x.ImageIndex = 9;
                    x.SelectedImageIndex = 9;
                }
                else
                {
                    x.ImageIndex = 0;
                    x.SelectedImageIndex = 0;
                }                
            }

            // Add items to new combo box
            newdsComboBox.Items.Clear();
            foreach (var x in Model.DataSources.ToList())
            {
                string dsName = x.Name;
                newdsComboBox.Items.Add(dsName);
            }
        }

        else if (stepNumber == 10)
        {
            step10Button.BackColor = bkgrdColor;
            step10Button.ForeColor = darktextColor;            
            step10treeView.Visible = true;
            filtersLabel.Visible = true;
            filtersTreeView.Visible = true;
            infoLabel.Text = infoLabelText[9];
            string ann = perspName+"_FilterColumnValues";
            step10treeView.Nodes.Clear();

            foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName] && a.ObjectType.ToString() == "Table" && a.ObjectTypeName != "Calculated Table").OrderBy(a => a.Name).ToList())
            {
                string tableName = t.Name;                
                var tn = step10treeView.Nodes.Add(tableName);
                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 0;

                if (t.IsHidden)
                {
                    tn.ForeColor = hiddenColor;
                }

                foreach (var c in t.Columns.Where(a => a.InPerspective[perspName] && a.Type.ToString() == "Data").OrderBy(a => a.Name).ToList())
                {
                    string columnName = c.Name;
                    var x = tn.Nodes.Add(columnName);   

                    if (Model.Tables[tableName].Columns[columnName].HasAnnotation(ann))
                    {
                        x.ImageIndex = 5;
                        x.SelectedImageIndex = 5;
                    }   
                    else
                    {          
                        x.ImageIndex = 1;
                        x.SelectedImageIndex = 1;       
                    }

                    if (c.IsHidden)
                    {
                        x.ForeColor = hiddenColor;
                    }                             
                }
            }
        }
        else if (stepNumber == 11)
        {
            infoLabel.Text = infoLabelText[10];
            step11Button.BackColor = bkgrdColor;
            step11Button.ForeColor = darktextColor;
            step11treeView.Visible = true;
            aggLabel.Visible = true;
            rightPanel.Visible = false;
            rightPanel2.Visible = true;
            rightPanel2.Controls.Clear();
            recoButton.Visible = true;
            eraseButton.Visible = true;
            string ann = perspName+"_AggType";
            step11treeView.Nodes.Clear();

            foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName] && a.ObjectType.ToString() == "Table" && a.ObjectTypeName != "Calculated Table").OrderBy(a => a.Name).ToList())
            {
                string tableName = t.Name;   
                // Only show tables on the From side of relationships and not on the To side
                if (t.UsedInRelationships.Where(a => a.FromTable.Name == tableName).Count() > 0)        
                {
                    if (t.UsedInRelationships.Where(a => a.ToTable.Name == tableName).Count() == 0)
                    {
                        var tn = step11treeView.Nodes.Add(tableName);

                        if (t.Columns.Where(a => a.HasAnnotation(ann)).Count() > 0)
                        {
                            tn.ImageIndex = 9;
                            tn.SelectedImageIndex = 9;
                        }
                        else
                        {
                            tn.ImageIndex = 0;
                            tn.SelectedImageIndex = 0;
                        }

                        if (t.IsHidden)
                        {
                            tn.ForeColor = hiddenColor;
                        }
                    }
                }                                             
            }
        }
        else if (stepNumber == 12)
        {
            infoLabel.Text = infoLabelText[11];
            nextstepButton.Text = "Finish";
            step12Button.BackColor = bkgrdColor;
            step12Button.ForeColor = darktextColor;
            step12treeView.Visible = true;
            saveButton.Visible = false;
            exportscriptButton.Visible = true;

            step12treeView.Nodes.Clear();
            string ann = perspName;
            
            sb_ExportScript.Clear();            
            sb_ExportScript.Append("string perspName =\""+perspName+"\";");
            sb_ExportScript.Append(Environment.NewLine);
            sb_ExportScript.Append("Model.AddPerspective(perspName);");            

            for (int i=0; i < screenList.Length-1; i++)
            {
                var x = step12treeView.Nodes.Add(screenList[i]);
                x.ImageIndex = 30;
                x.SelectedImageIndex = 30;

                if (i == 0)
                {
                    foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
                    {
                        string tableName = t.Name;
                        var z = x.Nodes.Add(tableName);
                        z.ImageIndex = 0;
                        z.SelectedImageIndex = 0;

                        if (t.IsHidden)
                        {
                            z.ForeColor = hiddenColor;
                        }

                        sb_ExportScript.Append(Environment.NewLine);  
                        sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].InPerspective[perspName] = true;");

                        foreach (var o in t.Columns.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
                        {
                            string objectName = o.Name;
                            var y = z.Nodes.Add(objectName);

                            if (o.Type.ToString() == "Calculated")
                            {
                                y.ImageIndex = 4;
                                y.SelectedImageIndex = 4;
                            }
                            else
                            {
                                y.ImageIndex = 1;
                                y.SelectedImageIndex = 1;
                            }

                            if (o.IsHidden)
                            {
                                y.ForeColor = hiddenColor;
                            }

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Columns[\""+objectName+"\"].InPerspective[perspName] = true;");

                        }
                        foreach (var o in t.Measures.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
                        {
                            string objectName = o.Name;
                            var y = z.Nodes.Add(objectName);
                            y.ImageIndex = 2;
                            y.SelectedImageIndex = 2;

                            if (o.IsHidden)
                            {
                                y.ForeColor = hiddenColor;
                            }

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Measures[\""+objectName+"\"].InPerspective[perspName] = true;");
                        }
                        foreach (var o in t.Hierarchies.Where(a => a.InPerspective[perspName]).OrderBy(a => a.Name).ToList())
                        {
                            string objectName = o.Name;
                            var y = z.Nodes.Add(objectName);
                            y.ImageIndex = 3;
                            y.SelectedImageIndex = 3;

                            if (o.IsHidden)
                            {
                                y.ForeColor = hiddenColor;
                            }

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Hierarchies[\""+objectName+"\"].InPerspective[perspName] = true;");
                        }
                    }
                }
                if (i == 1)
                {
                    ann = perspName+"_Hide";
                    string ann2 = perspName+"_Unhide";

                    foreach (var t in Model.Tables.Where(a => a.HasAnnotation(ann) || a.HasAnnotation(ann2) || a.Columns.Any(b => b.HasAnnotation(ann) || b.HasAnnotation(ann2)) || a.Measures.Any(b => b.HasAnnotation(ann) || b.HasAnnotation(ann2)) || a.Hierarchies.Any(b => b.HasAnnotation(ann) || b.HasAnnotation(ann2))).OrderBy(a => a.Name).ToList())
                    {
                        string tableName = t.Name;      
                        string nodeNameT = string.Empty;
                        string annValue = "";
                        if (t.HasAnnotation(ann))
                        {
                            nodeNameT = tableName+": Hide";

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");
                        }      
                        else if (t.HasAnnotation(ann2))
                        {
                            nodeNameT = tableName+": Unhide";
                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].SetAnnotation(\""+ann2+"\",\""+annValue+"\");");
                        }
                        else
                        {
                            nodeNameT = tableName;
                        }

                        var z = x.Nodes.Add(nodeNameT);
                        z.ImageIndex = 0;
                        z.SelectedImageIndex = 0;

                        foreach (var o in t.Columns.Where(a => a.HasAnnotation(ann) || a.HasAnnotation(ann2)).OrderBy(a => a.Name).ToList())
                        {
                            string objectName = o.Name;
                            string nodeName = string.Empty;
                            
                            if (o.HasAnnotation(ann))
                            {
                                nodeName = objectName+": Hide";

                                sb_ExportScript.Append(Environment.NewLine);  
                                sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Columns[\""+objectName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");
                            }      
                            else if (o.HasAnnotation(ann2))
                            {
                                nodeName = objectName+": Unhide";

                                sb_ExportScript.Append(Environment.NewLine);  
                                sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Columns[\""+objectName+"\"].SetAnnotation(\""+ann2+"\",\""+annValue+"\");");
                            }
                            var y = z.Nodes.Add(nodeName);   

                            if (o.Type.ToString() == "Calculated")
                            {
                                y.ImageIndex = 4;
                                y.SelectedImageIndex = 4;
                            }
                            else
                            {
                                y.ImageIndex = 1;
                                y.SelectedImageIndex = 1;
                            }                 
                        }
                        foreach (var o in t.Measures.Where(a => a.HasAnnotation(ann) || a.HasAnnotation(ann2)).OrderBy(a => a.Name).ToList())
                        {
                            string objectName = o.Name;
                            string nodeName = string.Empty;
                            if (o.HasAnnotation(ann))
                            {
                                nodeName = objectName+": Hide";

                                sb_ExportScript.Append(Environment.NewLine);  
                                sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Measures[\""+objectName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");
                            }      
                            else if (o.HasAnnotation(ann2))
                            {
                                nodeName = objectName+": Unhide";

                                sb_ExportScript.Append(Environment.NewLine);  
                                sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Measures[\""+objectName+"\"].SetAnnotation(\""+ann2+"\",\""+annValue+"\");");
                            }
                            var y = z.Nodes.Add(nodeName);                    
                            y.ImageIndex = 2;
                            y.SelectedImageIndex = 2;
                        }
                        foreach (var o in t.Hierarchies.Where(a => a.HasAnnotation(ann) || a.HasAnnotation(ann2)).OrderBy(a => a.Name).ToList())
                        {
                            string objectName = o.Name;
                            string nodeName = string.Empty;

                            if (o.HasAnnotation(ann))
                            {
                                nodeName = objectName+": Hide";

                                sb_ExportScript.Append(Environment.NewLine);  
                                sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Hierarchies[\""+objectName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");
                            }      
                            else if (o.HasAnnotation(ann2))
                            {
                                nodeName = objectName+": Unhide";

                                sb_ExportScript.Append(Environment.NewLine);  
                                sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Hierarchies[\""+objectName+"\"].SetAnnotation(\""+ann2+"\",\""+annValue+"\");");
                            }
                            var y = z.Nodes.Add(nodeName);                    
                            y.ImageIndex = 3;
                            y.SelectedImageIndex = 3;                            
                        }
                    }
                }
                else if (i ==2)
                {
                    ann = perspName+"_Expression";
                    foreach (var t in Model.Tables.Where(a => a.Measures.Any(b => b.HasAnnotation(ann)) || a.Columns.Any(b => b.HasAnnotation(ann))).OrderBy(a => a.Name).ToList())
                    {
                        string tableName = t.Name;
                        var z = x.Nodes.Add(tableName);
                        z.ImageIndex = 0;
                        z.SelectedImageIndex = 0;

                        foreach(var o in t.Measures.Where(a => a.HasAnnotation(ann)).OrderBy(a => a.Name).ToList())
                        {
                            string objectName = o.Name;
                            string annValue = o.GetAnnotation(ann);
                            var y = z.Nodes.Add(objectName+": "+annValue);
                            y.ImageIndex = 2;
                            y.SelectedImageIndex = 2;

                            annValue = annValue.Replace("\r"," ").Replace("\n"," ");
                            
                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Measures[\""+objectName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");
                        }

                        foreach(var o in t.Columns.Where(a => a.HasAnnotation(ann)).OrderBy(a => a.Name).ToList())
                        {
                            string objectName = o.Name;
                            string annValue = o.GetAnnotation(ann);
                            var y = z.Nodes.Add(objectName+": "+annValue);
                            y.ImageIndex = 4;
                            y.SelectedImageIndex = 4;

                            annValue = annValue.Replace("\r"," ").Replace("\n"," ");
                            
                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Columns[\""+objectName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");
                        }
                    }
                }
                else if (i == 3)
                {
                    ann = perspName+"_Remove";
                    foreach (var t in Model.Tables.Where(a => a.Partitions.Any(b => b.HasAnnotation(ann))).OrderBy(a => a.Name).ToList())
                    {
                        string annValue = "";
                        string tableName = t.Name;
                        var z = x.Nodes.Add(tableName);
                        z.ImageIndex = 0;
                        z.SelectedImageIndex = 0;


                        foreach(var p in t.Partitions.Where(a => a.HasAnnotation(ann)).OrderBy(a => a.Name).ToList())
                        {
                            string pName = p.Name;
                            var y = z.Nodes.Add(pName);
                            y.ImageIndex = 7;
                            y.SelectedImageIndex = 7;

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Partitions[\""+pName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");
                        }
                    }
                }
                else if (i == 4)
                {
                    ann = perspName+"_Remove";
                    foreach (var p in Model.Perspectives.Where(a => a.HasAnnotation(ann)).OrderBy(a => a.Name).ToList())
                    {
                        string annValue = "";
                        string pName = p.Name;
                        var z = x.Nodes.Add(pName);
                        z.ImageIndex = 8;
                        z.SelectedImageIndex = 8;

                        sb_ExportScript.Append(Environment.NewLine);  
                        sb_ExportScript.Append("Model.Perspectives[\""+pName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");
                    }
                }
                else if (i == 5)
                {
                    ann = perspName+"_UpdatePartitionQuery";
                    foreach (var t in Model.Tables.Where(a => a.HasAnnotation(ann)).OrderBy(a => a.Name).ToList())
                    {
                        string tableName = t.Name;
                        string annValue = t.GetAnnotation(ann);

                        var z = x.Nodes.Add(tableName + ": "+annValue);
                        z.ImageIndex = 0;
                        z.SelectedImageIndex = 0;

                        sb_ExportScript.Append(Environment.NewLine);  
                        sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].SetAnnotation(\""+ann+"\",\""+annValue+"\");");  
                    }
                }
                else if (i == 6)
                {
                    foreach (var r in Model.Roles.ToList().OrderBy(a => a.Name))
                    {
                        string roleName = r.Name;

                        var z = x.Nodes.Add(roleName);
                        z.ImageIndex = 10;
                        z.SelectedImageIndex = 10;

                        ann = perspName+"_UpdateRoleMembers";
                        if (r.HasAnnotation(ann))
                        {
                            string annValue = r.GetAnnotation(ann);
                            var y = z.Nodes.Add("Role Members: "+annValue);   
                            y.ImageIndex = 30;
                            y.SelectedImageIndex = 30;

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Roles[\""+roleName+"\"].SetAnnotation(\""+ann+"\",@\""+annValue+"\");");                              
                        }
                        ann = perspName+"_UpdateModelPermission";
                        if (r.HasAnnotation(ann))
                        {
                            string annValue = r.GetAnnotation(ann);
                            var y = z.Nodes.Add("Model Permission: "+annValue);  
                            y.ImageIndex = 30;
                            y.SelectedImageIndex = 30;

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Roles[\""+roleName+"\"].SetAnnotation(\""+ann+"\",@\""+annValue+"\");");                              
                        }
                    }
                }
                else if (i == 7)
                {                   
                    foreach (var r in Model.Roles.ToList().OrderBy(a => a.Name))
                    {
                        string roleName = r.Name;                   
                        int g = 0;                
                        foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName] && a.RowLevelSecurity[roleName] != null).OrderBy(a => a.Name).ToList())
                        {
                            string tableName = t.Name;
                            ann = perspName+"_UpdateRLS_"+tableName;
                            if (r.HasAnnotation(ann))
                            {
                                if (g == 0)
                                {
                                    var z = x.Nodes.Add(roleName);
                                    z.ImageIndex = 10;
                                    z.SelectedImageIndex = 10;
                                    g++;
                                }

                                int b = x.Nodes.Count-1;
                                string annValue = r.GetAnnotation(ann);
                                var c = x.Nodes[b].Nodes.Add(tableName+": "+annValue);
                                c.ImageIndex = 12;
                                c.SelectedImageIndex = 12;    

                                sb_ExportScript.Append(Environment.NewLine);  
                                sb_ExportScript.Append("Model.Roles[\""+roleName+"\"].SetAnnotation(\""+ann+"\",@\""+annValue+"\");");                              
                            }
                        }
                    }
                }
                else if (i == 8)
                {
                    ann = perspName+"_UpdateDataSource";

                    foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName] && a.HasAnnotation(ann)).OrderBy(a => a.Name).ToList())
                    {
                        string tableName = t.Name;
                        string annValue = t.GetAnnotation(ann);
                        var z = x.Nodes.Add(tableName+": "+annValue);
                        z.ImageIndex = 0;
                        z.SelectedImageIndex = 0;

                        sb_ExportScript.Append(Environment.NewLine);  
                        sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].SetAnnotation(\""+ann+"\",@\""+annValue+"\");");
                    }
                }
                else if (i == 9)
                {
                    ann = perspName+"_FilterColumnValues";

                    foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName] && a.Columns.Any(b => b.HasAnnotation(ann))).OrderBy(a => a.Name).ToList())
                    {
                        string tableName = t.Name;
                        var z = x.Nodes.Add(tableName);
                        z.ImageIndex = 0;
                        z.SelectedImageIndex = 0;

                        foreach (var c in t.Columns.Where(a => a.HasAnnotation(ann)).OrderBy(a => a.Name).ToList())
                        {
                            string columnName = c.Name;
                            string annValue = c.GetAnnotation(ann).Replace("\"","\"\"");
                            var y = z.Nodes.Add(columnName+": "+annValue);
                            y.ImageIndex = 1;
                            y.SelectedImageIndex = 1;

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Columns[\""+columnName+"\"].SetAnnotation(\""+ann+"\",@\""+annValue+"\");");
                        }
                    }
                }
                else if (i == 10)
                {
                    ann = perspName+"_AggType";

                    foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName] && a.Columns.Any(b => b.HasAnnotation(ann))).OrderBy(a => a.Name).ToList())
                    {
                        string tableName = t.Name;
                        var z = x.Nodes.Add(tableName);
                        z.ImageIndex = 0;
                        z.SelectedImageIndex = 0;

                        foreach (var c in t.Columns.Where(a => a.HasAnnotation(ann)).OrderBy(a => a.Name).ToList())
                        {
                            string columnName = c.Name;
                            string annValue = c.GetAnnotation(ann);
                            var y = z.Nodes.Add(columnName+": "+annValue);
                            y.ImageIndex = 1;
                         y.SelectedImageIndex = 1;

                            sb_ExportScript.Append(Environment.NewLine);  
                            sb_ExportScript.Append("Model.Tables[\""+tableName+"\"].Columns[\""+columnName+"\"].SetAnnotation(\""+ann+"\",@\""+annValue+"\");");
                        }
                    }
                }
            }
        }

        else if (stepNumber == 13)
        {
            newForm.Close();
        }
    }
};

// Event Handlers (Start Screen)
newmodelButton.Click += (System.Object sender, System.EventArgs e) => {

    startstep1Button.Visible = true;
    startstep1Button.Location = new Point(startScreenX+37, startScreenY+80);
    mmComboBox.Visible = false;
    startstep1Button.Enabled = true;
    mmComboBox.Text = string.Empty;
    modelnameTextBox.Enabled = true;
};

mmComboBox.SelectedValueChanged += (System.Object sender, System.EventArgs e) => {

    startstep1Button.Enabled = true;         
};

existingmodelButton.Click += (System.Object sender, System.EventArgs e) => {

    startstep1Button.Location = new Point(startScreenX+37, startScreenY+120);
    mmComboBox.Visible = true;
    startstep1Button.Visible = true;    
    startstep1Button.Enabled = false;
    modelnameTextBox.Enabled = false;  
    
    // Add items to combo box
    mmComboBox.Items.Clear();
    foreach (var p in Model.Perspectives.ToList())
    {
        string pName = p.Name;
        mmComboBox.Items.Add(pName);
    }

    if (mmComboBox.SelectedItem == null)
    {
        startstep1Button.Enabled = false;
    }  
};

startstep1Button.Click += (System.Object sender, System.EventArgs e) => {

    NextStep(1);    
};

nextstepButton.Click += (System.Object sender, System.EventArgs e) => {

    if (step1treeView.Visible == true)
    {
        NextStep(2);
    }
    else if (step2treeView.Visible == true)
    {
        NextStep(3);
    }
    else if (step3treeView.Visible == true)
    {
        NextStep(4);
    }
    else if (step4treeView.Visible == true)
    {
        NextStep(5);
    }
    else if (step5treeView.Visible == true)
    {
        NextStep(6);
    }
    else if (step6treeView.Visible == true)
    {
        NextStep(7);
    }
    else if (step7treeView.Visible == true)
    {
        NextStep(8);
    }
    else if (step8treeView.Visible == true)
    {
        NextStep(9);
    }
    else if (step9treeView.Visible == true)
    {
        try
        {
            var result = EvaluateDax("1");
            NextStep(10);
        }
        catch
        {
            Error(asErrorMessage);
        }
        
    }
    else if (step10treeView.Visible == true)
    {
        NextStep(11);
    }
    else if (step11treeView.Visible == true)
    {
        NextStep(12);
    }
    else if (nextstepButton.Text == "Finish")
    {
        NextStep(13);
    }
    else
    {
        NextStep(1);
    }
};

step1Button.Click += (System.Object sender, System.EventArgs e) => {
      
    NextStep(1);
};

step2Button.Click += (System.Object sender, System.EventArgs e) => {
     
    NextStep(2);
};

step3Button.Click += (System.Object sender, System.EventArgs e) => {
      
    NextStep(3);
};

step4Button.Click += (System.Object sender, System.EventArgs e) => {
      
    NextStep(4);
};

step5Button.Click += (System.Object sender, System.EventArgs e) => {
      
    NextStep(5);
};

step6Button.Click += (System.Object sender, System.EventArgs e) => {
      
    NextStep(6);
};

step7Button.Click += (System.Object sender, System.EventArgs e) => {
     
    NextStep(7);
};

step8Button.Click += (System.Object sender, System.EventArgs e) => {
      
    NextStep(8);
};

step9Button.Click += (System.Object sender, System.EventArgs e) => {
     
    NextStep(9);
};

step10Button.Click += (System.Object sender, System.EventArgs e) => {
    
    try
    {
        var result = EvaluateDax("1");
        NextStep(10);
    }
    catch
    {
        Error(asErrorMessage);
    }  
};

step11Button.Click += (System.Object sender, System.EventArgs e) => {
      
    NextStep(11);
};

step12Button.Click += (System.Object sender, System.EventArgs e) => {
      
    NextStep(12);
};

step1treeView.AfterExpand += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    IsExpOrCol = true;
};

step1treeView.AfterCollapse += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    IsExpOrCol = true;
};

step1treeView.NodeMouseClick += (System.Object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e) => {
    
    if (IsExpOrCol == false)
    {
        if (e.Node.StateImageIndex != 1)
        {
            e.Node.StateImageIndex = 1;
        }
        else if (e.Node.StateImageIndex == 1)
        {
            e.Node.StateImageIndex = 0;
        }
                
        if (e.Node.ImageIndex == 0)
        {
            // If parent node is checked, check all child nodes
            if (e.Node.StateImageIndex == 1)        
            {   
                foreach (System.Windows.Forms.TreeNode childNode in e.Node.Nodes)
                {
                    childNode.StateImageIndex = 1;
                }
            }
            // If parent node is unchecked, uncheck all child nodes
            else if (e.Node.StateImageIndex == 0)
            {
                foreach (System.Windows.Forms.TreeNode childNode in e.Node.Nodes)
                {
                    childNode.StateImageIndex = 0;                
                }
            }
        }     
        else
        {
            int childNodeCount = e.Node.Parent.Nodes.Count;   
            int childNodeCheckedCount = 0;    
        
            foreach (System.Windows.Forms.TreeNode n in e.Node.Parent.Nodes)
            {
                if (n.StateImageIndex == 1)
                {
                    childNodeCheckedCount+=1;
                }
            }
            
            // If all child nodes are checked, set parent node to checked
            if (childNodeCheckedCount == childNodeCount)
            {
                e.Node.Parent.StateImageIndex = 1;
            }
            // If no child nodes are checked, set parent node to unchecked
            else if (childNodeCheckedCount == 0)
            {
                e.Node.Parent.StateImageIndex = 0;
            }
            // If not all children nodes are selected, set parent node to partially checked icon
            else if (childNodeCheckedCount < childNodeCount)
            {
                e.Node.Parent.StateImageIndex = 2;
            }
        }                       
    }
    
    IsExpOrCol = false;
};

step2treeView.AfterExpand += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    IsExpOrCol = true;
};

step2treeView.AfterCollapse += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    IsExpOrCol = true;
};

step2treeView.NodeMouseClick += (System.Object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e) => {
    
    if (IsExpOrCol == false)
    {    
        // Set color
        if (e.Node.ForeColor == hiddenColor)
        {
            e.Node.ForeColor = visibleColor;       
        }
        else
        {
            e.Node.ForeColor = hiddenColor;
        }
                
        // Set checkboxes
        if (e.Node.StateImageIndex == 1)
        {
            e.Node.StateImageIndex = 0;                                     
        }
        else
        {
            e.Node.StateImageIndex = 1;           
        }                           
                               
        if (e.Node.ImageIndex == 0)
        {
            // If parent node is checked, check all child nodes
            if (e.Node.StateImageIndex == 1)
            {
                foreach (System.Windows.Forms.TreeNode childNode in e.Node.Nodes)
                {
                    childNode.StateImageIndex = 1;
                    if (childNode.ForeColor == hiddenColor)
                    {
                        childNode.ForeColor = visibleColor;                        
                    }
                    else
                    {
                        childNode.ForeColor = hiddenColor;
                    }                                     
                }
            }
            // If parent node is unchecked, uncheck all child nodes
            else
            {
                foreach (System.Windows.Forms.TreeNode childNode in e.Node.Nodes)
                {
                    childNode.StateImageIndex = 0;   
                    if (childNode.ForeColor == hiddenColor)
                    {
                        childNode.ForeColor = visibleColor;                        
                    }
                    else
                    {
                        childNode.ForeColor = hiddenColor;
                    }                 
                }
            }   
        }                  
        else
        {
            int childNodeCount = e.Node.Parent.Nodes.Count;   
            int childNodeCheckedCount = 0;    
        
            foreach (System.Windows.Forms.TreeNode n in e.Node.Parent.Nodes)
            {
                if (n.StateImageIndex == 1)
                {
                    childNodeCheckedCount+=1;
                }
            }
            
            // If all child nodes are checked, set parent node to checked
            if (childNodeCheckedCount == childNodeCount)
            {
                e.Node.Parent.StateImageIndex = 1;

            }
            // If no child nodes are checked, set parent node to unchecked
            else if (childNodeCheckedCount == 0)
            {
                e.Node.Parent.StateImageIndex = 0;
            }
            // If not all children nodes are selected, set parent node to partially checked icon
            else if (childNodeCheckedCount < childNodeCount)
            {
                e.Node.Parent.StateImageIndex = 2;
            }
        }   
    }
    
    IsExpOrCol = false;
};

step3treeView.AfterSelect += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    oldDAXTextBox.Text = string.Empty;
    newDAXTextBox.Text = string.Empty;
    newDAXTextBox.ReadOnly = true;
        
    if (e.Node.Parent != null)
    {
        var tableName = e.Node.Parent.Text;
        string ann = perspName + "_Expression";
        newDAXTextBox.ReadOnly = false;

        // Calculated Columns
        if (e.Node.ImageIndex == 4 || e.Node.ImageIndex == 5)
        {
            string objectName = e.Node.Text; 
            var obj = (Model.Tables[tableName].Columns[objectName] as CalculatedColumn);
            
            var oldDAX = obj.Expression;                
            oldDAXTextBox.Text = oldDAX;
            
            string newDAX = obj.GetAnnotation(ann);
            newDAXTextBox.Text = newDAX; 
        }
        // Measures
        else if (e.Node.ImageIndex == 2 || e.Node.ImageIndex == 6)
        {
            string objectName = e.Node.Text;  
            var obj = Model.Tables[tableName].Measures[objectName];
            
            string oldDAX = obj.Expression;                
            oldDAXTextBox.Text = oldDAX;
            
            string newDAX = obj.GetAnnotation(ann);
            newDAXTextBox.Text = newDAX;              
        }
    }    
};

step4treeView.AfterExpand += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    IsExpOrCol = true;
};

step4treeView.AfterCollapse += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    IsExpOrCol = true;
};

step4treeView.NodeMouseClick += (System.Object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e) => {
    
    if (IsExpOrCol == false)
    {
        if (e.Node.ImageIndex == 0)
        {
            Error("Cannot remove entire table in this manner. Please select partitions only.");
        }
        else if (e.Node.ImageIndex != 1)
        {
            // Update child nodes
            if (e.Node.StateImageIndex != 1)
            {
                e.Node.StateImageIndex = 1;
            }
            else if (e.Node.StateImageIndex == 1)
            {
                e.Node.StateImageIndex = 0;
            }                                                           
            
            // Update parent nodes
            foreach (System.Windows.Forms.TreeNode rootNode in step4treeView.Nodes)
            {
                int childNodeCount = rootNode.Nodes.Count;
                int childNodeCheckedCount = 0;
                
                foreach (System.Windows.Forms.TreeNode childNode in rootNode.Nodes)
                {
                    if (childNode.StateImageIndex == 1)
                    {
                        childNodeCheckedCount+=1;
                    }                    
                }
                
                if (childNodeCheckedCount == 0)
                {
                    rootNode.StateImageIndex = 0;
                }
                else if (childNodeCheckedCount == childNodeCount)
                {
                    Error("Cannot remove all partitions of a table.");
                    e.Node.StateImageIndex = 0;
                }
                else if (childNodeCheckedCount < childNodeCount)
                {
                    rootNode.StateImageIndex = 2;
                }                                
            }                      
        }        
    }
    
    IsExpOrCol = false;  
};

step5treeView.NodeMouseClick += (System.Object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e) => {

    if (e.Node.StateImageIndex != 1)
    {
        e.Node.StateImageIndex = 1;
    }
    else
    {
        e.Node.StateImageIndex = 0;
    }
};

step6treeView.NodeMouseClick += (System.Object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e) => {

    //newqueryTextBox.ReadOnly = false;
    findTextBox.ReadOnly = false;
    replaceTextBox.ReadOnly = false;
    findTextBox.Text = string.Empty;
    replaceTextBox.Text = string.Empty;
    oldqueryTextBox.Text = string.Empty;
    newqueryTextBox.Text = string.Empty;
    int nodeStateInd = e.Node.StateImageIndex;
    string tableName = e.Node.Text;
    string ann = perspName+"_UpdatePartitionQuery";
    
    if (nodeStateInd != 1)
    {
        e.Node.StateImageIndex = 1;
    }
    else
    {
        e.Node.StateImageIndex = 0;
    }
    
    var tbl = Model.Tables[tableName];
    string oldQ = tbl.Partitions.First().Query;
    string newQ = string.Empty;
    string oper = tbl.GetAnnotation(ann);    
    string sep = " ---- ";
    string operFind = string.Empty;
    string operReplace = string.Empty;
    int sepIndex = 0;
    
    if (oper != null)
    {
        sepIndex = oper.IndexOf(sep);
        operFind = oper.Substring(0,sepIndex);
        operReplace = oper.Substring(sepIndex + 6,oper.Length - sepIndex - 6);
        newQ = oldQ.Replace(operFind,operReplace);
    }
                     
    oldqueryTextBox.Text = oldQ;
    newqueryTextBox.Text = newQ;
    findTextBox.Text = operFind;
    replaceTextBox.Text = operReplace;
};

step7treeView.AfterSelect += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    string ann = perspName+"_UpdateRoleMembers";
    string ann2 = perspName+"_UpdateModelPermission";
    string roleName = e.Node.Text;
    string oldroleMembers = Model.Roles[roleName].RoleMembers;
    string newroleMembers = Model.Roles[roleName].GetAnnotation(ann);
    var obj = Model.Roles[roleName];
    
    oldroleTextBox.Text = oldroleMembers;
    newroleTextBox.Text = newroleMembers;
    newroleTextBox.ReadOnly = false;
    newmpComboBox.Enabled = true;
    // Populate combo boxes    
    string oldMP = obj.ModelPermission.ToString();    
    oldmpComboBox.Text = oldMP;    

    string[] mpOptions = {"None", "Read", "ReadRefresh", "Refresh", "Administrator"};
    newmpComboBox.Items.Clear();   
    
    for (int o =0; o < mpOptions.Length; o++)
    {    
        newmpComboBox.Items.Add(mpOptions[o]);
    }

    if (obj.HasAnnotation(ann2))
    {
        newmpComboBox.Text = obj.GetAnnotation(ann2);
    }
    else
    {
        newmpComboBox.Text = oldMP;
    }
};

step8treeView.AfterSelect += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {

    if (e.Node.Parent != null)
    {
        string ann = perspName+"_UpdateRLS_";
        string roleName = e.Node.Parent.Text;
        string tableName = e.Node.Text;
        var roleobj = Model.Roles[roleName];
        
        oldrlsTextBox.Text = Model.Tables[tableName].RowLevelSecurity[roleName];
        if (roleobj.HasAnnotation(ann+tableName))
        {
            newrlsTextBox.Text = roleobj.GetAnnotation(ann+tableName);
        }
        newrlsTextBox.ReadOnly = false;
    }
    else
    {
        oldrlsTextBox.Text = string.Empty;
        newrlsTextBox.Text = string.Empty;
        newrlsTextBox.ReadOnly = true;
    }
};

step9treeView.AfterSelect += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
   
    string ann = perspName+"_UpdateDataSource";
    string tableName = e.Node.Text;    
    var obj = Model.Tables[tableName];
    string ds = obj.Source;
    
    olddsComboBox.Text = ds;
    if (obj.HasAnnotation(ann))
    {
        newdsComboBox.Text = obj.GetAnnotation(ann);
    }    
    else
    {
        newdsComboBox.Text = string.Empty;
    }
    newdsComboBox.Enabled = true;
};

step10treeView.AfterExpand += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    IsExpOrCol = true;
};

step10treeView.AfterCollapse += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {
    
    IsExpOrCol = true;
};

step10treeView.NodeMouseClick += (System.Object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e) => {
    
    if (IsExpOrCol == false)
    {
        filtersTreeView.Nodes.Clear();

        if (e.Node.Parent != null)
        {
            string tableName = e.Node.Parent.Text;
            string columnName = e.Node.Text;
            var obj = Model.Tables[tableName].Columns[columnName];
            string ann = perspName+"_FilterColumnValues";
            var columnValuesCount = EvaluateDax("SUMMARIZECOLUMNS(\"test\",COUNTROWS(DISTINCT('"+tableName+"'["+columnName+"])))");
            
            if (columnValuesCount.ToString() != "Table")
            {
                if (Convert.ToInt32(columnValuesCount) <= 50 && Convert.ToInt32(columnValuesCount) > 0)
                {
                    var columnValues = ExecuteDax("EVALUATE SUMMARIZECOLUMNS('"+tableName+"'["+columnName+"]) ORDER BY '"+tableName+"'["+columnName+"]").Tables[0];
                    
                    for (int r = 0; r < columnValues.Rows.Count; r++)
                    {
                        string cv = columnValues.Rows[r][0].ToString();                            
                        string colValue = "\""+cv+"\"";
                        var x = filtersTreeView.Nodes.Add(cv);

                        if (obj.HasAnnotation(ann) && !obj.GetAnnotation(ann).Contains(colValue.ToString()))
                        {
                            x.Checked = false;
                        }
                        else
                        {
                            x.Checked = true;
                        }
                        
                    }
                }                
                else if (Convert.ToInt32(columnValuesCount) > 50)
                {
                    Info("'"+tableName+"'["+columnName+"] has more than 50 unique values. The filtering option is only enabled for columns with less than 50 unique values.");
                }
            }
            else
            {
                Info("'"+tableName+"'["+columnName+"] has no values in the model. You may need to process this table.");
            }
        }
    }

    IsExpOrCol = false;
};

step11treeView.AfterSelect += (System.Object sender, System.Windows.Forms.TreeViewEventArgs e) => {

    // Remove existing controls
    rightPanel2.Controls.Clear();

    string tableName = e.Node.Text;
    string ann = perspName+"_AggType";
    int aggX = 260;
    int aggLabelX = 0;
    int aggY = 20;
    int aggLabelY = 22;

    int z = 0;
    // Ensure all partitions are SELECT * FROM
    foreach (var p in Model.Tables[tableName].Partitions)
    {
        string partitionName = p.Name;
        string pQuery = p.Query.Replace(" ","").Replace("\r\n","").Replace("\r","").Replace("\n","");

        if (pQuery.ToUpper().Substring(0,11) != "SELECT*FROM")
        {
            z+=1;
        }
    }

    if (z > 0)
    {
        Error("All table partitions must be in the 'SELECT * FROM' format.");
    }
    else
    {


        foreach (var c in Model.Tables[tableName].Columns.Where(a => a.InPerspective[perspName] && a.Type.ToString() == "Data").OrderBy(a => a.Name))
        {
            string columnName = c.Name;
            string dt = c.DataType.ToString();
            System.Windows.Forms.ComboBox aggComboBox = new System.Windows.Forms.ComboBox();
            System.Windows.Forms.Label aggColumnLabel = new System.Windows.Forms.Label();
            aggComboBox.Visible = true;
            aggComboBox.Size = new Size(90,20);
            aggComboBox.Location = new Point(aggX,aggY);
            aggComboBox.Name = columnName;
            aggComboBox.Tag = "agg";
            rightPanel2.Controls.Add(aggComboBox);
            rightPanel2.Controls.Add(aggColumnLabel);
            string[] aggOptions = {"GroupBy", "Sum", "Count", "Average", "Min", "Max"};
            
            aggComboBox.Items.Clear();
            
            if (dt != "Decimal" && dt != "Int64" && dt != "Double")
            {
                aggComboBox.Items.Add("GroupBy");
            }
            else 
            {
                for (int o =0; o < aggOptions.Length; o++)
                {    
                    aggComboBox.Items.Add(aggOptions[o]);            
                }        
            }
            
            if (dt == "Decimal" || dt == "Double")
            {
                aggComboBox.Items.Remove("GroupBy");
            }
            
            // Show pre-existing annotation value
            if (c.HasAnnotation(ann))
            {
                aggComboBox.Text = c.GetAnnotation(ann);
            }

            aggColumnLabel.Visible = true;
            aggColumnLabel.Size = new Size(260,20);
            aggColumnLabel.Location = new Point(aggLabelX,aggLabelY);
            aggColumnLabel.Text = columnName;
            aggColumnLabel.Tag = "agg";
            aggY +=30;
            aggLabelY +=30;
        }
    }
};

saveButton.Click += (System.Object sender, System.EventArgs e) => {

    perspName = modelnameTextBox.Text;
    // Step 1
    if (step1treeView.Visible == true)
    {
        if (perspName == string.Empty)
        {
            // Invalid perspective name
            Error("Must enter a name for your mini model.");
        }
        else
        {
            // If perspective does not exist, create a new one
            if (Model.Perspectives.Where(a => a.Name == perspName).Count() == 0)
            {
                Model.AddPerspective(perspName);
            }

            // Clear perspective
            foreach (var t in Model.Tables.ToList())
            {
                string tableName = t.Name;             
                Model.Tables[tableName].InPerspective[perspName] = false;
            }
          
            // Add elements and dependencies to perspective
            foreach (System.Windows.Forms.TreeNode rootNode in step1treeView.Nodes)
            {
                var tableName = rootNode.Text;         
                 
                foreach (System.Windows.Forms.TreeNode childNode in rootNode.Nodes)
                {
                    var objectName = childNode.Text;
                     
                    if (childNode.StateImageIndex == 1)
                    {
                        // Columns
                        if(childNode.ImageIndex == 1 || childNode.ImageIndex == 4)                    
                        {
                            var o = Model.Tables[tableName].Columns[objectName];
                            o.InPerspective[perspName] = true;
                             
                            // Calculated column dependencies
                            // if (o.Type.ToString() == "Calculated")
                            // {
                            //     var allReferences = (Model.Tables[tableName].Columns[objectName] as CalculatedColumn).DependsOn.Deep();
                             
                            //     foreach(var dep in allReferences)
                            //     {
                            //         // Add dependent columns/measures specified in text file to the perspective
                            //         var columnDep = dep as Column; if(columnDep != null) columnDep.InPerspective[perspName] = true;
                            //         var measureDep = dep as Measure; if(measureDep != null) measureDep.InPerspective[perspName] = true;
                            //     }
                            // }
                        }                    
                        // Measures
                        else if(childNode.ImageIndex == 2)                    
                        {
                            var o = Model.Tables[tableName].Measures[objectName];
                            o.InPerspective[perspName] = true;
                             
                            var allReferences = o.DependsOn.Deep();
                            
                            foreach(var dep in allReferences)
                            {
                                //Add dependent columns/measures specified in text file to the perspective
                                var columnDep = dep as Column; if(columnDep != null) columnDep.InPerspective[perspName] = true;
                                var measureDep = dep as Measure; if(measureDep != null) measureDep.InPerspective[perspName] = true;
                            }
                        }
                        // Hierarchies
                        else if(childNode.ImageIndex == 3)                    
                        {
                            var o = Model.Tables[tableName].Hierarchies[objectName];
                            o.InPerspective[perspName] = true;
                             
                            // Add dependent columns for hierarchy                         
                            foreach (var lev in o.Levels.ToList())
                            {
                                string hcolName = lev.Column.Name;
                                Model.Tables[tableName].Columns[hcolName].InPerspective[perspName] = true;
                            }                         
                        }
                    }
                }
            } 

            // Add primary key columns to perspective
            foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName]))
            {
                foreach (var c in t.Columns.Where(a => a.IsKey == true))
                {
                    c.InPerspective[perspName] = true;
                }
            }
            // Check tables with RLS and their related tables
            // foreach (var r in Model.Roles.ToList())
            // {
            //     var roleName = r.Name;
                
            //     foreach (var t in Model.Tables.Where(a => a.RowLevelSecurity[roleName] != null))
            //     {
            //         var tableName = t.Name;
                    
            //         var relList = Model.Tables[tableName].UsedInRelationships;
                    
            //         foreach (var rel in relList)
            //         {
            //             string relTableName = rel.ToTable.Name;
            //             string relColumnName = rel.ToColumn.Name;
                        
            //             int colInPCount = Model.Tables[relTableName].Columns.Where(a => a.InPerspective[perspName] == true).Count();
                        
            //             if (colInPCount > 0)
            //             {
            //                 Model.Tables[tableName].InPerspective[perspName] = true;
            //                 Model.Tables[relTableName].Columns[relColumnName].InPerspective[perspName] = true;                
            //             }
            //             else
            //             {
            //                 // do nothing
            //             }
            //         }                
            //     }
            // }
            
            // Add RLS tables and related column to the perspective
            foreach (var r in Model.Roles.ToList())
            {
                string roleName = r.Name;
                foreach (var t in Model.Tables.Where(a => a.RowLevelSecurity[roleName] != null).ToList())
                {
                    string tableName = t.Name;
                    
                    // Add RLS tables to perspective        
                    Model.Tables[tableName].InPerspective[perspName] = true;
                    
                    foreach (var rel in Model.Tables[tableName].UsedInRelationships.ToList())
                    {
                        string relID = rel.ID;
                        var obj = Model.Relationships[relID];
                        string toTable = obj.ToTable.Name;
                        string toColumn = obj.ToColumn.Name;
                        string toCard = obj.ToCardinality.ToString();
                        int x = Model.Tables[toTable].Columns[toColumn].UsedInRelationships.Count();
                        // Add column related to RLS table to perspective
                        Model.Tables[toTable].Columns[toColumn].InPerspective[perspName] = true;
                        
                        if (toCard == "One" && x == 2)
                        {
                            foreach (var rel2 in Model.Tables[toTable].UsedInRelationships.ToList())
                            {
                                string rel2ID = rel2.ID;
                                var obj2 = Model.Relationships[rel2ID];
                                string fromTable = obj2.FromTable.Name;
                                string fromColumn = obj2.FromColumn.Name;
                                // Add secondary column related to RLS table to perspective
                                Model.Tables[fromTable].Columns[fromColumn].InPerspective[perspName] = true;
                            }
                        }
                    }
                }    
            }

            //Add in foreign and primary keys from tables that are within the perspective.
            foreach (var rel in Model.Relationships.Where(r => r.FromTable.InPerspective[perspName] && r.ToTable.InPerspective[perspName]).ToList())
            { 
                string tF = rel.FromTable.Name;
                string cF = rel.FromColumn.Name;
                Model.Tables[tF].Columns[cF].InPerspective[perspName] = true;
                string tT = rel.ToTable.Name;
                string cT = rel.ToColumn.Name;
                Model.Tables[tT].Columns[cT].InPerspective[perspName] = true;
            } 
        }    
    }

    // Step 2
    if (step2treeView.Visible == true)
    {
        string annH = perspName+"_Hide";
        string annU = perspName+"_Unhide";
        // Remove existing annotations for hide and unhide
        foreach (var t in Model.Tables.ToList())
        {
            string tableName = t.Name;
            var tbl = Model.Tables[tableName];
            tbl.RemoveAnnotation(annH);
            tbl.RemoveAnnotation(annU);
            
            foreach (var c in t.Columns.ToList())
            {
                string objectName = c.Name;
                var obj = Model.Tables[tableName].Columns[objectName];
                obj.RemoveAnnotation(annH);
                obj.RemoveAnnotation(annU);                   
            }        
            foreach (var m in t.Measures.ToList())
            {
                string objectName = m.Name;
                var obj = Model.Tables[tableName].Measures[objectName];
                obj.RemoveAnnotation(annH);
                obj.RemoveAnnotation(annU);                   
            }
            foreach (var h in t.Hierarchies.ToList())
            {
                string objectName = h.Name;
                var obj = Model.Tables[tableName].Hierarchies[objectName];
                obj.RemoveAnnotation(annH);
                obj.RemoveAnnotation(annU);                   
            }
        }

        // Add hide or unhide annotations
        foreach (System.Windows.Forms.TreeNode rootNode in step2treeView.Nodes)
        {
            string tableName = rootNode.Text;
            var tbl = Model.Tables[tableName];
            
            if (rootNode.StateImageIndex == 1)
            {
                if (rootNode.ForeColor == hiddenColor)
                {
                    tbl.SetAnnotation(annH,"");
                }
                else
                {
                    tbl.SetAnnotation(annU,"");
                }
            }
         
            foreach (System.Windows.Forms.TreeNode childNode in rootNode.Nodes)
            {
                string objectName = childNode.Text;
                
                if (rootNode.StateImageIndex != 1)
                { 
                    if (childNode.StateImageIndex == 1)
                    {
                        // Columns
                        if(childNode.ImageIndex == 1 || childNode.ImageIndex == 4)                    
                        {
                            var o = Model.Tables[tableName].Columns[objectName];
                            if (childNode.ForeColor == hiddenColor)
                            {
                                o.SetAnnotation(annH,"");
                            }
                            else
                            {
                                o.SetAnnotation(annU,"");
                            }                                                                         
                        }                    
                        // Measures
                        else if(childNode.ImageIndex == 2)                    
                        {                        
                            var o = Model.Tables[tableName].Measures[objectName];
                            if (childNode.ForeColor == hiddenColor)
                            {
                                o.SetAnnotation(annH,"");
                            }
                            else
                            {
                                o.SetAnnotation(annU,"");
                            }
                        }
                        // Hierarchies
                        else if(childNode.ImageIndex == 3)                    
                        {
                            var o = Model.Tables[tableName].Hierarchies[objectName];
                            if (childNode.ForeColor == hiddenColor)
                            {
                                o.SetAnnotation(annH,"");
                            }
                            else
                            {
                                o.SetAnnotation(annU,"");
                            }                       
                        }
                    }
                }
            } 
        }  
    }

    // Step 3
    else if (step3treeView.Visible == true && step3treeView.SelectedNode != null)
    {
        if (step3treeView.SelectedNode.Parent != null)
        {
            string tableName = step3treeView.SelectedNode.Parent.Text;
            string obj = step3treeView.SelectedNode.Text;
            int objIndex = step3treeView.SelectedNode.ImageIndex;
            
            string oldDAX = oldDAXTextBox.Text;
            string newDAX = newDAXTextBox.Text;
            
            string ann = perspName + "_Expression";
            
            // Remove annotation if empty
            if (newDAX == string.Empty)
            {
                if (objIndex == 4 || objIndex == 5)
                {
                    step3treeView.SelectedNode.ImageIndex = 4;
                    step3treeView.SelectedNode.SelectedImageIndex = 4;
                    var o = (Model.Tables[tableName].Columns[obj] as CalculatedColumn);
                    o.RemoveAnnotation(ann);
                }
                else if (objIndex == 2 || objIndex == 6)
                {
                    step3treeView.SelectedNode.ImageIndex = 2;
                    step3treeView.SelectedNode.SelectedImageIndex = 2;
                    var o = Model.Tables[tableName].Measures[obj];
                    o.RemoveAnnotation(ann);
                }
            }
            // Add annotation and update icon
            else
            {
                try
                {
                    // DAX validation
                    // myFormatDax(newDAX);     

                    // Calculated Column
                    if (objIndex == 4 || objIndex == 5)
                    {
                        step3treeView.SelectedNode.ImageIndex = 5;
                        step3treeView.SelectedNode.SelectedImageIndex = 5;
                        var o = (Model.Tables[tableName].Columns[obj] as CalculatedColumn);
                        o.SetAnnotation(ann,newDAX);
                    }    
                    // Measures
                    else if (objIndex == 2 || objIndex == 6)
                    {
                        step3treeView.SelectedNode.ImageIndex = 6;
                        step3treeView.SelectedNode.SelectedImageIndex = 6;
                        var o = Model.Tables[tableName].Measures[obj];
                        o.SetAnnotation(ann,newDAX);   
                    } 
                }
                catch
                {
                    Error("DAX is not valid. Please try again.");
                }                              
            }            
        }
    }
    // Step 4
    else if (step4treeView.Visible == true)
    {
        string ann = perspName+"_Remove";
        // Remove annotations
        foreach (var t in Model.Tables.Where(a => a.InPerspective[perspName]).ToList())
        {
            string tableName = t.Name;
            
            foreach (var p in t.Partitions.ToList())
            {
                string partitionName = p.Name;
                var obj = Model.Tables[tableName].Partitions[partitionName];
                obj.RemoveAnnotation(ann);            
            }
        }
        
        // Create annotations
        foreach (System.Windows.Forms.TreeNode rootNode in step4treeView.Nodes)
        {
            var tableName = rootNode.Text;

            foreach (System.Windows.Forms.TreeNode childNode in rootNode.Nodes)
            {
                var obj = childNode.Text;
                
                if (childNode.StateImageIndex == 1)
                {
                    Model.Tables[tableName].Partitions[obj].SetAnnotation(ann,"");
                }
            }
        } 
    }
    // Step 5
    else if (step5treeView.Visible == true)
    {
        string ann = perspName+"_Remove";
        // Set Annotations for perspectives    
        foreach (System.Windows.Forms.TreeNode rootNode in step5treeView.Nodes)
        {
            string pName = rootNode.Text;        
            if (rootNode.StateImageIndex == 1)
            {
                Model.Perspectives[pName].SetAnnotation(ann,"");
            }
            else
            {
                Model.Perspectives[pName].RemoveAnnotation(ann);
            }
        }
    }
    // Step 6
    else if (step6treeView.Visible == true)
    {
        string oldQ = oldqueryTextBox.Text;
        string newQ = newqueryTextBox.Text;
        string findText = findTextBox.Text;
        string replaceText = replaceTextBox.Text;
        string ann = perspName+"_UpdatePartitionQuery";
        string sep = " ---- ";

        if (findText != string.Empty && replaceText != string.Empty)
        {
            // Update new query text box
            newqueryTextBox.Text = oldQ.Replace(findText,replaceText);
            
            // Add annotations
            foreach (System.Windows.Forms.TreeNode rootNode in step6treeView.Nodes)
            {
                string tableName = rootNode.Text;
                
                if (rootNode.StateImageIndex == 1)
                {
                    Model.Tables[tableName].SetAnnotation(ann,findText + sep + replaceText);                
                    rootNode.ImageIndex = 9;
                    rootNode.SelectedImageIndex = 9;
                }            
            }
        }    
        else
        {        
            // Remove Annotations        
            foreach (System.Windows.Forms.TreeNode rootNode in step6treeView.Nodes)
            {
                string tableName = rootNode.Text;
                
                if (rootNode.StateImageIndex == 1)
                {
                    Model.Tables[tableName].RemoveAnnotation(ann);                
                    rootNode.ImageIndex = 0;
                    rootNode.SelectedImageIndex = 0;
                }              
            }
            // Reset new query text box
            newqueryTextBox.Text = string.Empty;
        }
    }
    // Step 7
    else if (step7treeView.Visible == true && step7treeView.SelectedNode != null)
    {
        string ann = perspName+"_UpdateRoleMembers";
        string ann2 = perspName+"_UpdateModelPermission";
        string oldrm = oldroleTextBox.Text;
        string newrm = newroleTextBox.Text;
        string roleName = step7treeView.SelectedNode.Text;
        string oldmp = oldmpComboBox.Text;
        string newmp = newmpComboBox.Text;    
        var obj = Model.Roles[roleName];
        
        // Annotations for role members
        if (newrm != string.Empty && oldrm != newrm)
        {
            obj.SetAnnotation(ann,newrm);
        }
        else
        {
            obj.RemoveAnnotation(ann);
        }
        
        // Annotations for model permission
        if (newmp != string.Empty && oldmp != newmp)
        {
            obj.SetAnnotation(ann2,newmp);

        }
        else
        {
            obj.RemoveAnnotation(ann2);
        }

        // Update icon
        if (obj.HasAnnotation(ann) || obj.HasAnnotation(ann2))
        {
            step7treeView.SelectedNode.ImageIndex = 11;
            step7treeView.SelectedNode.SelectedImageIndex = 11;
        }
        else
        {
            step7treeView.SelectedNode.ImageIndex = 10;
            step7treeView.SelectedNode.SelectedImageIndex = 10;
        }
    }
    // Step 8
    else if (step8treeView.Visible == true && step8treeView.SelectedNode != null)
    {
        string ann = perspName+"_UpdateRLS_";
        string oldRLS = oldrlsTextBox.Text;
        string newRLS = newrlsTextBox.Text;    
        
        if (step8treeView.SelectedNode.Parent != null)
        {
            string roleName = step8treeView.SelectedNode.Parent.Text;
            string tableName = step8treeView.SelectedNode.Text;
            
            if (newRLS != string.Empty && oldRLS != newRLS)
            {
                try
                {
                    // myFormatDax(newRLS);
                    Model.Roles[roleName].SetAnnotation(ann+tableName,newRLS);
                    step8treeView.SelectedNode.ImageIndex = 13;
                    step8treeView.SelectedNode.SelectedImageIndex = 13;
                }
                catch
                {
                    Error("DAX used for Row Level Security is not valid. Please try again.");
                }
            }
            else
            {
                Model.Roles[roleName].RemoveAnnotation(ann+tableName);
                step8treeView.SelectedNode.ImageIndex = 12;
                step8treeView.SelectedNode.SelectedImageIndex = 12;
            }
        }
    }
    // Step 9
    else if (step9treeView.Visible == true && step9treeView.SelectedNode != null)
    {
        string ann = perspName+"_UpdateDataSource";
        string oldDS = olddsComboBox.Text;
        string newDS = newdsComboBox.Text;    
        string tableName = step9treeView.SelectedNode.Text;
            
        if (newDS != string.Empty && oldDS != newDS)
        {
            Model.Tables[tableName].SetAnnotation(ann,newDS);
            step9treeView.SelectedNode.ImageIndex = 9;
            step9treeView.SelectedNode.SelectedImageIndex = 9;
        }
        else
        {
            Model.Tables[tableName].RemoveAnnotation(ann);
            step9treeView.SelectedNode.ImageIndex = 0;
            step9treeView.SelectedNode.SelectedImageIndex = 0;
        }  
    }
    // Step 10
    else if (step10treeView.Visible == true && step10treeView.SelectedNode != null)
    {
        string ann = perspName+"_FilterColumnValues";

        var sb_Filter = new System.Text.StringBuilder();

        if (step10treeView.SelectedNode.Parent != null)
        {
            string tableName = step10treeView.SelectedNode.Parent.Text;
            string columnName = step10treeView.SelectedNode.Text;
            var obj = (Model.Tables[tableName].Columns[columnName] as DataColumn);
            string sourceColumn = obj.SourceColumn;

            int colCount = filtersTreeView.Nodes.Count;
            int colCheckedCount = 0;

            // Count to determin IN or NOT IN
            foreach (System.Windows.Forms.TreeNode rootNode in filtersTreeView.Nodes)
            {                 
                 if (rootNode.Checked == true)
                 {
                     colCheckedCount+=1;
                 }
            }

            if (colCheckedCount == colCount)
            {
                obj.RemoveAnnotation(ann);
            }
            else if (colCheckedCount == 0)
            {
                Error("Cannot remove all values.");
            }
            else //if (colCheckedCount < (colCount/2))
            {
                sb_Filter.Append("["+sourceColumn+"] IN(");
                foreach (System.Windows.Forms.TreeNode rootNode in filtersTreeView.Nodes)
                {
                    string columnValue = rootNode.Text;
                    if (rootNode.Checked == true)
                    {
                        sb_Filter.Append("\""+columnValue+"\",");
                    }
                }
                
                string filterVal = sb_Filter.ToString();
                string filterValue = filterVal.Substring(0,filterVal.Length-1) + ")";
                obj.SetAnnotation(ann,filterValue);                
            } 
        }
    }
    // Step 11
    else if (step11treeView.Visible == true && step11treeView.SelectedNode != null)
    {
        string tableName = step11treeView.SelectedNode.Text;
        int cbCount = 0;
        int cbFilledCount = 0;
        // Check if all boxes are filled
        foreach (System.Windows.Forms.Control cCB in rightPanel2.Controls.OfType<System.Windows.Forms.ComboBox>())
        {
            if (cCB.Text != "")
            {
                cbFilledCount+=1;
            }
            cbCount+=1;
        }

        if (cbFilledCount == cbCount)
        {
            foreach (System.Windows.Forms.Control cCB in rightPanel2.Controls.OfType<System.Windows.Forms.ComboBox>())
            {
                string columnName = cCB.Name;
                string ann = perspName+"_AggType";
                string aggType = cCB.Text;
                var obj = Model.Tables[tableName].Columns[columnName];
                if (cCB.Text != string.Empty)
                {
                    obj.SetAnnotation(ann,aggType);
                }
                else
                {
                    obj.RemoveAnnotation(ann);
                }

                step11treeView.SelectedNode.ImageIndex = 9;
                step11treeView.SelectedNode.SelectedImageIndex = 9;
            }
        }
        // Remove all annotations if none are filled
        else if (cbFilledCount == 0)
        {
            foreach (System.Windows.Forms.Control cCB in rightPanel2.Controls.OfType<System.Windows.Forms.ComboBox>())
            {
                string columnName = cCB.Name;
                string ann = perspName+"_AggType";
                var obj = Model.Tables[tableName].Columns[columnName];
                obj.RemoveAnnotation(ann);  

                step11treeView.SelectedNode.ImageIndex = 0;
                step11treeView.SelectedNode.SelectedImageIndex = 0;              
            }
        }
        // If some are filled, raise an error
        else
        {
            Error("Must fill summarizations for all columns in order to save.");
        }
    }
};

exportscriptButton.Click += (System.Object sender, System.EventArgs e) => {

    // Save export script to desktop
    string desktopPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
    System.IO.File.WriteAllText(desktopPath + @"\"+perspName+"_MiniModel.cs", sb_ExportScript.ToString());
};

recoButton.Click += (System.Object sender, System.EventArgs e) => {

    if (step11treeView.SelectedNode != null)
    {
        string tableName = step11treeView.SelectedNode.Text;
        foreach (System.Windows.Forms.Control cL in rightPanel2.Controls.OfType<System.Windows.Forms.Label>())
        {
            string colName = cL.Text;
            var obj = Model.Tables[tableName].Columns[colName];
            string dt = obj.DataType.ToString();
            bool h = obj.IsHidden;
            int rCount = obj.UsedInRelationships.Count();
            string last2 = colName.Substring(colName.Length - 2);
            string last3 = colName.Substring(colName.Length - 3);
            foreach (System.Windows.Forms.Control cCB in rightPanel2.Controls.OfType<System.Windows.Forms.ComboBox>())
            {
                if (cCB.Name == colName)
                {
                    if (rCount > 0)
                    {
                        cCB.Text = "GroupBy";
                    }
                    else if (dt != "Decimal" && dt != "Double" && dt != "Int64")
                    {
                        cCB.Text = "GroupBy";
                    }
                    else if (h == false)
                    {
                        cCB.Text = "GroupBy";
                    }
                    else if (last2.ToUpper() == "ID" || last3.ToUpper() == "KEY")
                    {
                        cCB.Text = "GroupBy";
                    }
                    else
                    {
                        cCB.Text = "Sum";
                    }
                }
            }
        }
    }
};

eraseButton.Click += (System.Object sender, System.EventArgs e) => {

    if (step11treeView.SelectedNode != null)
    {
        foreach (System.Windows.Forms.Control cCB in rightPanel2.Controls.OfType<System.Windows.Forms.ComboBox>())
        {
            cCB.Text = "";
        }
    }
};

newForm.Show();