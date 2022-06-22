# New_SeleniumWebDriver

## Command to run nunit3-consolerunner
Install the dotnet core console runner using the following nuget command:

dotnet tool install --global NUnit.ConsoleRunner.NetCore --version 3.15.0

then the following command:

cd C:\Users\xxxx\.nuget\packages\nunit.consolerunner.netcore\3.15.0\tools\net6.0\any>nunit3-console "C:\Projects\QA Automation\SeleniumWebDriver\AutomationTestingFramework\bin\Debug\net6.0\AutomationTestingFramework.dll"

## Convert from xml to html
Install package Reportunit.exe
cd C:\Users\xxxxx.xxxx\.nuget\packages\reportunit\1.2.1\tools
[INFO] Usage 1:  ReportUnit "path-to-folder"
[INFO] Usage 2:  ReportUnit "input-folder" "output-folder"
[INFO] Usage 3:  ReportUnit "input.xml" "output.html"

In this code , we are going to use "path-to-folder"
ReportUnit.exe "C:\Users\xxx.xxx\.nuget\packages\nunit.consolerunner.netcore\3.15.0\tools\net6.0\any"
