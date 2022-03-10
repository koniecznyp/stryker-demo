[Stryker.NET](https://stryker-mutator.io/) offers you mutation testing for your .NET Core and .NET Framework projects. It allows you to test your tests by temporarily inserting bugs. Stryker.NET is installed using NuGet.

### Getting started
To stary playing with testing you need to install `stryker`
```
cd ..\stryker-demo\StrykerDemo.Tests

dotnet new tool-manifest

dotnet tool install dotnet-stryker
```

After instalation all you need to do is run `stryker` using

```
dotnet stryker
```

`Stryker` will create `mutants` and check if your tests survive the changes in code. Finally, the analysis will be included in the `html` report that can be opened in the browser where the detected problems will be described