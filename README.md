# eShop Order Totals on .NET

A fictional order calculator targeting .NET 10. The console application
calculates a total from a unit price, quantity, and discount percentage.

## Run locally

Install the .NET 10 SDK, then run:

```powershell
dotnet run --project .\OrderApp\OrderApp.csproj
```

## Tests

A separate xUnit project tests the same calculation used by the application.
Run the tests:

```powershell
dotnet test .\OrderApp.Tests\OrderApp.Tests.csproj
```
