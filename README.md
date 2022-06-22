# New_SeleniumWebDriver

Command to run nunit3-consolerunner
Install the dotnet core console runner using the following nuget command:

dotnet tool install --global NUnit.ConsoleRunner.NetCore --version 3.15.0

then the following command:

cd C:\Users\xxxx\.nuget\packages\nunit.consolerunner.netcore\3.15.0\tools\net6.0\any>nunit3-console "C:\Projects\QA Automation\SeleniumWebDriver\AutomationTestingFramework\bin\Debug\net6.0\AutomationTestingFramework.dll"
