# Execution Time Measurement Framework

![ExecutionTimeMeasurement](https://raw.githubusercontent.com/J0rgeSerran0/ExecutionTimeMeasurement/master/ExecutionTimeMeasurement.png)

*Framework to generate measurements about the times consumed by a method to study the performance of a process.*


## Introduction

* You can use this Framework in your .NET Framework apps with 4.6.1 or greater, or .NET Core 2.0 or greater and Visual Studio 2017.


## Installing the package

To install the package, use NuGet.

You can find more information about the last version of this package [here][1].

To install the package, you can do it manually too.

### Package Manager

**`Install-Package ExecutionTimeMeasurement -Version {version}`**

> Where {version} is the version of the package you want to install.
For example, `Install-Package ExecutionTimeMeasurement -Version 1.0.0`

### .NET CLI

**`dotnet add package ExecutionTimeMeasurement --version {version}`**

> Where {version} is the version of the package you want to install.
For example, `dotnet add package ExecutionTimeMeasurement --version 1.0.0`


## Sample use of the Execution Time Measuremente Framework

In this repo, inside of the Demo directory, you can find two samples, one of them for .NET Framework, and the another one for .NET Core.

Now, I am going to create a sample code to use the Framework.

The next method will be measured and will be executed three times, so, we will get three measurements of the method.

```csharp
[Measure(nameof(ExecutionWithoutParams), "Sample test without params", 3)]
public void ExecutionWithoutParams()
{
    List<int> values = new List<int>();
    for (int i = 0; i < 1000; i++)
    {
        values.Add(i);
    }
}
```

To execute the measurement, we will have to execute the next code:

```csharp
MeasureResult measureResult = Measurement.Exec(ExecutionWithoutParams);
Console.WriteLine(measureResult.Name);
Console.WriteLine(measureResult.Description);
Console.WriteLine(measureResult.Iterations);
foreach (var item in measureResult.ResultTime)
{
    Console.WriteLine(item.Elapsed.TotalMilliseconds);
}
```

In the `MeasureResult` object, we will receive the summary of the results with the time of each execution.

[1]: https://www.nuget.org/packages/ExecutionTimeMeasurement/1.0.0