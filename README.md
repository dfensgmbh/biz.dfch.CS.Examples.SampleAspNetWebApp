# biz.dfch.CS.Examples.SampleAspNetWebApp
[![License](https://img.shields.io/badge/license-Apache%20License%202.0-blue.svg)](https://github.com/dfensgmbh/biz.dfch.CS.Examples.SampleAspNetWebApp/blob/master/LICENSE)

Sample ASP.NET Web Application

# Project Configuration
- **Project Template:** ASP.NET Web Application
- **Type:** MVC
- **Authentication:** Individual User Accounts

# Publish Application

1. Open solution in Visual Studio 2017
1. Right click on the project `biz.dfch.CS.Examples.SampleAspNetWebApp` and select `Publish...`
1. ![Publish Web Application](/media/publish-app-1.png?raw=true)
1. ![Publish Web Application](/media/publish-app-2.png?raw=true)
1. ![Publish Web Application](/media/publish-app-3.png?raw=true)

# Deploy Application to IIS

## Prerequirements
To deploy the Web package (attached to the [release](https://github.com/dfensgmbh/biz.dfch.CS.Examples.SampleAspNetWebApp/releases/tag/1.0.0)), Web Deploy (msdeploy.exe) must be installed on the computer that runs the .cmd file. For information about how to install Web Deploy, see the following URL:

https://go.microsoft.com/?linkid=9278654

## Step by Step Manual
1. Copy the following artifacts (attachments of the [release](https://github.com/dfensgmbh/biz.dfch.CS.Examples.SampleAspNetWebApp/releases/tag/1.0.0)) to the server, where IIS runs on
    - `biz.dfch.CS.Examples.SampleAspNetWebApp.deploy.cmd`
    - `biz.dfch.CS.Examples.SampleAspNetWebApp.deploy-readme.txt`
    - `biz.dfch.CS.Examples.SampleAspNetWebApp.SetParameters.xml`
    - `biz.dfch.CS.Examples.SampleAspNetWebApp.SourceManifest.xml`
    - `biz.dfch.CS.Examples.SampleAspNetWebApp.zip`
1. Replace the value of `DefaultConnection-Web.config Connection String` in `biz.dfch.CS.Examples.SampleAspNetWebApp.SetParameters.xml` with the connection string of the MSSQL database the application should use

    **Important:** The user the application uses to connect to the database has to have permissions to create and update databases and to create, read, update and delete entries from its databases (even if using windows authentication in combination with DefaultAppPool the DefaultAppPool user has to have the before described permissions).

    For examples see [here](https://www.connectionstrings.com/sql-server/)

1. Prefix value of `IIS Web Application Name` in `biz.dfch.CS.Examples.SampleAspNetWebApp.SetParameters.xml` with `Default Web Site\`
1. Open PowerShell console or CMD
1. Deploy the Web package to IIS by executing the following command

    PATH\TO\biz.dfch.CS.Examples.SampleAspNetWebApp.deploy.cmd /Y

    For more details concerning the flags, that can be used when executing `biz.dfch.CS.Examples.SampleAspNetWebApp.deploy.cmd` see `biz.dfch.CS.Examples.SampleAspNetWebApp.deploy-readme.txt`
