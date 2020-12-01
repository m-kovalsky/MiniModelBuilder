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

2.) Download Tabular Editor (if you don't have it installed already). Here is a link to download it: https://github.com/otykier/TabularEditor/releases/.

3.) Open Tabular Editor.

4.) Connect to your model.

5.) Paste the MiniModelBuilder.cs script inside the 'Advanced Scripting' window.

6.) Click the play button (or press F5).

## The 'Create' script

The MiniModelBuilder_Create.cs script is the code that actually creates the mini-model. The other script is essentially creating the recipe for your mini-model. This script reads the recipe and dynamically makes all the changes to create your mini-model. 

## Steps within the program

* TBD...

## Version History

* 2020-12-01 Version 1.0.0 released on GitHub.com
