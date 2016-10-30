# ShogunLib

[![Build](https://ci.appveyor.com/api/projects/status/3xfkxtnkrts1x06q/branch/master?svg=true)](https://ci.appveyor.com/project/iivchenko/shogunlib) [![NuGet downloads](https://img.shields.io/badge/nuget-v%200.1.3-brightgreen.svg)](https://www.nuget.org/packages/ShogunLib.dll)

Set of libraries with some sort of everyday functionality like 
* [Extension of LINQ](https://github.com/iivchenko/ShogunLib/wiki/LINQ)
  * [Enumerable](https://github.com/iivchenko/ShogunLib/wiki/Enumerable)
  * [Collection](https://github.com/iivchenko/ShogunLib/wiki/Collection)
* [Maybe monad](https://github.com/iivchenko/ShogunLib/wiki/Maybe)
* [Event extensions](https://github.com/iivchenko/ShogunLib/wiki/Events)
* [Units convertor](https://github.com/iivchenko/ShogunLib/wiki/Units)
* [Argument validation](https://github.com/iivchenko/ShogunLib/wiki/Validate)
* etc.

```csharp
public void Process(Report report, string author)
{
    report.ValidateNull(nameof(report));
    author.ValidateStringEmpty(nameof(author));

    report
		.ToMaybe()
		.Bind(x => x.Item)
		.Bind(x => x.Value)
		.Do(x => NameChanged.Raise(this, x));

    var unit = 
    	report
	      .ToMaybe()
	      .Bind(x => x.Item)
	      .Bind(x => x.Length.ToUnit())
	      .Return();

	Console.WriteLine($"Report size is {unit.Value} ({unit.Name})");

    report.ToMaybe()
          .Do(x => x.Records.ForEach(y => Console.WriteLine(y.Header)));
}
```

## Releases ##
![Release v0.1.3](https://img.shields.io/badge/v%200.1.3-missing-lightgrey.svg) [![Release Notes v0.1.3](https://img.shields.io/badge/Release%20notes-Navigate-brightgreen.svg)](https://github.com/iivchenko/ShogunLib/releases/tag/v0.1.3)

## License ##

ShogunLib is open source software, licensed under the terms of MIT license. 
See [LICENSE](LICENSE) for details.