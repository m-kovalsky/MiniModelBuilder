# Mini Model Builder

Mini Model Builder is a tool that allows you to customize a 'mini model' based on an existing tabular model. This tool runs inside of Tabular Editor's Advanced Scripting feature. This tool is compatible for all destinations of tabular models - SQL Server Analysis Services, Azure Analysis Services, and Power BI Premium. This tool is also viable for both in-memory and direct query models.

## Purpose

Call them what you want - 'micro cubes', 'mini models', 'derivative models' - this tool is designed to simplify the process of creating a 'mini model'. It is also designed with the intention of being used by a broader audience than just the tabular developer community.

## Files

* MiniModelBuilder.cs: This is the Mini Model Builder program which runs inside of Tabular Editor. This is where you customize your mini model to your desired specifications.

* MiniModelBuilder_Create.cs: This is the script that actually creates the mini model. It reads the metadata which was saved while using the Mini Model Builder program.

## Instructions for running the program

1.) Download the following files to your computer.

      MiniModelBuilder.cs
      MiniModelBuilder_Create.cs

2.) Download Tabular Editor (if you don't have it installed already). Here is a link to download it: https://github.com/otykier/TabularEditor/releases/

3.) Open Tabular Editor.

4.) Connect to your model.

5.) Paste the MiniModelBuilder.cs script inside the 'Advanced Scripting' window.

6.) Click the play button (or press F5).

## The 'Create' script

The MiniModelBuilder_Create.cs script is the code that actually creates the mini-model. The other script is essentially creating the recipe for your mini-model. This script reads the recipe and dynamically makes all the changes to create your mini-model. 

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

* Tabular Editor version 2.12.1 or higher.
* Compatible for SQL Server Analysis Services, Azure Analysis Services, and Power BI Premium models.
* Compatible for tabular models using Import-mode, Direct Query mode, and Composite models.
* To use the 'Filter Column Values' step, you must be live-connected to an Analysis Services model.
* To use either the 'Filter Column Values' or 'Set Aggregations' steps, your data source must be a SQL-type source and partition queries must start with 'SELECT * FROM ...'.
* Updating roles (Step 7) is not supported via XMLA R/W endpoints in Power BI Premium. If you are deploying to Power BI Premium, modifying roles must be done within the Power BI Service.

## Version History

* 2020-12-01 Version 1.0.0 released on GitHub.com
