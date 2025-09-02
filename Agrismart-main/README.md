# Agrismart

## How to build

dotnet nuget add source https://nuget.devexpress.com/SOME_API_KEY/api --name DevExpress
dotnet build .\AgriSmart.sln

## Common errors

> : error NU1101: Unable to find package DevExpress.Win.Design. No packages exist with this id in source(s): Microsoft Visual Studio Offline Packages, nuget.org

dotnet nuget add source "https://nuget.devexpress.com/{your_devexpress_key}/api" -n DevExpress

OR

AgriSmart.slm REMOVE

> Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "AgriSmart.Tools.Desktop", "AgriSmart.Tools.Desktop\AgriSmart.Tools.Desktop.csproj", "{D7F8FB04-EC03-4EC4-8EED-AB1BF553729A}"
EndProject


## Running each module

1. dotnet run --project .\AgriSmart.Api.Agronomic\AgriSmart.Api.Agronomic.csproj

> System.IO.DirectoryNotFoundException: Could not find a part of the path 'C:\Users\AlexQQ\Desktop\reference-repo\Agrismart-main\AgriSmart.Api.Agronomic\Logs\2025-09-02_log.txt'.

mkdir .\AgriSmart.Api.Agronomic\Logs


2. dotnet run --project .\AgriSmart.AgronomicProcess\AgriSmart.AgronomicProcess.csproj

3. dotnet run --project .\AgriSmart.Api.Iot\AgriSmart.Api.Iot.csproj

> Unhandled exception. Unhandled exception. System.ObjectDisposedException: Cannot access a disposed object.
Object name: 'IServiceProvider'.

mkdir .\AgriSmart.Api.Iot\Logs

4. Application.X are Class Libraries, not executables but utils

5. dotnet run --project .\AgriSmart.Calculator\AgriSmart.Calculator.csproj
> Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.

Copy "AgrismartApiConfiguration" from appsettings.json into appsettings.Development.json (AgriSmart.Calculator folder)

> Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
   at AgriSmart.Calculator.WorkerCalculator..ctor(ILogger`1 logger, IOptions`1 agrismartApiConfiguration) in C:\Users\AlexQQ\Desktop\reference-repo\Agrismart-main\AgriSmart.Calculator\WorkerCalculator.cs:line 31

REVIEW: WorkerCalculator.cs // FIX ENTRY 0

> info: AgriSmart.Calculator.WorkerCalculator[0]
      Worker running at: 09/02/2025 10:27:11 -06:00
Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
   at AgriSmart.Calculator.WorkerCalculator.ExecuteAsync(CancellationToken stoppingToken) in C:\Users\AlexQQ\Desktop\reference-repo\Agrismart-main\AgriSmart.Calculator\WorkerCalculator.cs:line 47
   at Microsoft.Extensions.Hosting.Internal.Host.StartAsync(CancellationToken cancellationToken)
   at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
   at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
   at Program.<Main>$(String[] args) in C:\Users\AlexQQ\Desktop\reference-repo\Agrismart-main\AgriSmart.Calculator\Program.cs:line 21
   at Program.<Main>(String[] args)

REVIEW: WorkerCalculator.cs // FIX ENTRY 1

6.  AgriSmart.Core is a Class Library (util)

7.  AgriSmart.DB is an SQL Project (util)

8.  AgriSmart.Infrastructure is a Class Library (util)

9. dotnet run --project .\Agrismart.MQTTBroker\Agrismart.MQTTBroker.csproj

10. dotnet run --project .\AgriSmart.OnDemandIrrigation\AgriSmart.OnDemandIrrigation.csproj

Errors in appsettings.json and CalculationCalculate, too many to document, so providing full fix instead

