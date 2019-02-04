echo Starting of the file on %date% at %time%
dotnet test "%CD%\LinnworksUnitTests\LinnworksUnitTests.csproj" --logger "trx;LogFileName=TestResult.xml"


