# create empty dotnet solution #

dotnet new sln --output MySolution

# create basic empty project's structure #

new-item MySolution/TestCases -ItemType Directory
new-item MySolution/Keywords  -ItemType Directory
new-item MySolution/DataProvider -ItemType Directory
new-item MySolution/Helpers -ItemType Directory

# add folders in test cases project #

new-item MySolution/TestCases/Frontend -ItemType Directory
new-item MySolution/TestCases/Backend -ItemType Directory

# add folder in keywords project #

new-item MySolution/Keywords/Frontend -ItemType Directory
new-item MySolution/Keywords/Backend -ItemType Directory

# add folders in data provider project #

new-item MySolution/DataProvider/Frontend -ItemType Directory
new-item MySolution/DataProvider/Backend -ItemType Directory

new-item MySolution/DataProvider/LocalRunSettings -ItemType Directory
new-item MySolution/DataProvider/TestData -ItemType Directory

# create subfolders in test cases #

new-item MySolution/TestCases/Frontend/SmokeTests -ItemType Directory
new-item MySolution/TestCases/Backend/SmokeTests -ItemType Directory

# add subfolders in keywords #

new-item MySolution/Keywords/Frontend/Keywords -ItemType Directory
new-item MySolution/Keywords/Frontend/Provider -ItemType Directory

new-item MySolution/Keywords/Backend/Keywords -ItemType Directory
new-item MySolution/Keywords/Backend/Provider -ItemType Directory

# add subfolders in data provider

new-item MySolution/DataProvider/Frontend/PageObjects -ItemType Directory
new-item MySolution/DataProvider/Frontend/RunSettings -ItemType Directory

new-item MySolution/DataProvider/Backend/DataObjects -ItemType Directory
new-item MySolution/DataProvider/Backend/ClientCredentials -ItemType Directory


# create xunit test cases project #

dotnet new xunit -o MySolution/TestCases

# create class-libraries as projects #

dotnet new classlib -o MySolution/Keywords
dotnet new classlib -o MySolution/Helpers
dotnet new classlib -o MySolution/DataProvider

# remove default files #

Remove-Item MySolution/TestCases/UnitTest1.cs
Remove-Item MySolution/Keywords/Class1.cs
Remove-Item MySolution/Helpers/Class1.cs
Remove-Item MySolution/DataProvider/Class1.cs

# create new basic classes for Smoke Tests #

new-item MySolution/TestCases/Frontend/SmokeTests/TestBase.cs -ItemType File
Get-Content -Path Samples/Frontend/TestBase.cs | Add-Content -Path MySolution/TestCases/Frontend/SmokeTests/TestBase.cs

new-item MySolution/TestCases/Frontend/SmokeTests/SmokeTest.cs
Get-Content -Path Samples/Frontend/SmokeTest.cs | Add-Content -Path MySolution/TestCases/Frontend/SmokeTests/SmokeTest.cs

new-item MySolution/TestCases/Frontend/SmokeTests/MainPageTests.cs
Get-Content -Path Samples/Frontend/MainPageTests.cs | Add-Content -Path MySolution/TestCases/Frontend/SmokeTests/MainPageTests.cs

new-item MySolution/TestCases/Backend/SmokeTests/TestBase.cs
Get-Content -Path Samples/Backend/TestBase.cs | Add-Content -Path MySolution/TestCases/Backend/SmokeTests/TestBase.cs

new-item MySolution/TestCases/Backend/SmokeTests/SmokeTest.cs
Get-Content -Path Samples/Backend/SmokeTest.cs | Add-Content -Path MySolution/TestCases/Backend/SmokeTests/SmokeTest.cs

# create new basic classes for keywords #

new-item Keywords/Frontend/Keywords/CoreKeywords.cs
Get-Content -Path Samples/Frontend/CoreKeywords.cs | Add-Content -Path Keywords/Frontend/Keywords/CoreKeywords.cs

new-item Keywords/Frontend/Keywords/MainKeywords.cs
Get-Content -Path Samples/Frontend/MainKeywords.cs | Add-Content -Path Keywords/Frontend/Keywords/MainKeywords.cs

new-item MySolution/Keywords/Frontend/Provider/DriverProvider.cs
Get-Content -Path Samples/Frontend/DriverProvider.cs | Add-Content -Path MySolution/Keywords/Frontend/Provider/DriverProvider.cs

new-item Keywords/Frontend/Provider/TokenProvider.cs
Get-Content -Path Samples/Frontend/TokenProvider.cs | Add-Content -Path Keywords/Frontend/Provider/TokenProvider.cs

New-Item MySolution/Keywords/Frontend/Provider/TestBaseProvider.cs
Get-Content -Path Samples/Frontend/TestBaseProvider.cs | Add-Content -Path MySolution/Keywords/Frontend/Provider/TestBaseProvider.cs

new-item MySolution/Keywords/Backend/Provider/ClientProvider.cs
Get-Content -Path Samples/Backend/ClientProvider.cs | Add-Content -Path MySolution/Keywords/Backend/Provider/ClientProvider.cs

new-item Keywords/Backend/Provider/UrlProvider.cs
Get-Content -Path Samples/Backend/UrlProvider.cs | Add-Content -Path Keywords/Backend/Provider/UrlProvider.cs

new-item MySolution/Keywords/Backend/Keywords/CoreKeywords.cs
Get-Content -Path Samples/Backend/CoreKeywords.cs | Add-Content -Path MySolution/Keywords/Backend/Keywords/CoreKeywords.cs

new-item MySolution/Keywords/Backend/Endpoints.cs
Get-Content -Path Samples/Backend/Endpoints.cs | Add-Content -Path MySolution/Keywords/Backend/Endpoints.cs

# create basic classes for helpers #

new-item MySolution/Helpers/Helpers.cs
Get-Content -Path Samples/Helpers.cs | Add-Content -Path Helpers/Helpers.cs

# create basic classes for data provider #

new-item MySolution/DataProvider/Frontend/PageObjects/MainPage.cs
Get-Content -Path Samples/Frontend/MainPage.cs | Add-Content -Path MySolution/DataProvider/Frontend/PageObjects/MainPage.cs

new-item MySolution/DataProvider/Frontend/RunSettings/RunSettingsParsedFromJsonFile.cs
Get-Content -Path Samples/Frontend/RunSettingsParsedFromJsonFile.cs | Add-Content -Path MySolution/DataProvider/Frontend/RunSettings/RunSettingsParsedFromJsonFile.cs

new-item MySolution/DataProvider/Frontend/RunSettings/RunSettingsFromEnvironment.cs
Get-Content -Path Samples/Frontend/RunSettingsFromEnvironment.cs | Add-Content -Path MySolution/DataProvider/Frontend/RunSettings/RunSettingsFromEnvironment.cs

new-item MySolution/DataProvider/TestData/TestData.cs
Get-Content -Path Samples/TestData.cs | Add-Content -Path MySolution/DataProvider/TestData/TestData.cs

new-item MySolution/DataProvider/Backend/ClientCredentials/ClientCredentials.cs
Get-Content -Path Samples/Backend/ClientCredentials.cs | Add-Content -Path MySolution/DataProvider/Backend/ClientCredentials/ClientCredentials.cs

new-item MySolution/DataProvider/Backend/DataObjects/AzureToken.cs
Get-Content -Path Samples/Backend/AzureToken.cs | Add-Content -Path MySolution/DataProvider/Backend/DataObjects/AzureToken.cs

new-item MySolution/DataProvider/LocalRunSettings/RunSettings.test.local.json
Get-Content -Path Samples/RunSettings.test.local.json | Add-Content -Path MySolution/DataProvider/LocalRunSettings/RunSettings.test.local.json

# add references #

dotnet add MySolution/TestCases/TestCases.csproj reference MySolution/Keywords/Keywords.csproj
dotnet add MySolution/TestCases/TestCases.csproj reference MySolution/DataProvider/DataProvider.csproj
dotnet add MySolution/TestCases/TestCases.csproj reference MySolution/Helpers/Helpers.csproj
dotnet add MySolution/Keywords/Keywords.csproj reference MySolution/DataProvider/DataProvider.csproj
dotnet add MySolution/Keywords/Keywords.csproj reference MySolution/Helpers/Helpers.csproj
dotnet add MySolution/Helpers/Helpers.csproj reference MySolution/DataProvider/DataProvider.csproj

# add packages into test cases project #

dotnet add MySolution/TestCases/TestCases.csproj package FluentAssertions -n
dotnet add MySolution/TestCases/TestCases.csproj package Microsoft.NET.Test.Sdk -n
dotnet add MySolution/TestCases/TestCases.csproj package Selenium.Support -n
dotnet add MySolution/TestCases/TestCases.csproj package Selenium.WebDriver -n
dotnet add MySolution/TestCases/TestCases.csproj package xunit -n
dotnet add MySolution/TestCases/TestCases.csproj package xunit.runner.visualstudio -n

# add packages into keywords project #

dotnet add MySolution/Keywords/Keywords.csproj package Newtonsoft.json -n
dotnet add MySolution/Keywords/Keywords.csproj package Selenium.Support -n
dotnet add MySolution/Keywords/Keywords.csproj package Selenium.WebDriver -n
dotnet add MySolution/Keywords/Keywords.csproj package WebDriverManager -n

# add packages in helpers project #

dotnet add MySolution/Helpers/Helpers.csproj package Newtonsoft.json -n
dotnet add MySolution/Helpers/Helpers.csproj package Selenium.WebDriver -n

# add packages into data provider project # 

dotnet add MySolution/DataProvider/DataProvider.csproj package Newtonsoft.json -n
dotnet add MySolution/DataProvider/DataProvider.csproj package Selenium.WebDriver -n

# add all projects to solution #

dotnet sln add MySolution/Keywords/Keywords.csproj
dotnet sln add MySolution/DataProvider/DataProvider.csproj
dotnet sln add MySolution/Helpers/Helpers.csproj
dotnet sln add MySolution/TestCases/TestCases.csproj