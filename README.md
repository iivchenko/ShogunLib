# ShogunLib #

Set of libraries with some sort of everyday functionality like 
* extension of LINQ
* monads
* event extensions
* ready to use pattern implementations
* etc.

## Samples ##

**Validate**

```csharp
using System;
using ShogunLib;

namespace JustShogunLibSamples
{
    public class Validate
    {
		// Useful for Consturctor parameters validation.
        public Validate(
            object param1, 
            Action param2, 
            string param3, 
            string param4, 
            int param5)
        {
            param1.ValidateNull("param1");
            param2.ValidateNull("param2");
            param3.ValidateNull("param3");
            param4.ValidateStringEmpty("param4");

            // param5 can't be validated because it is not a ref type.
        }
    }
}
```

**Units**
```csharp
using System;
using ShogunLib;

namespace JustShogunLibSamples
{
    public class UnitsSamples
    {
        public void Method_1()
        {
            var template = "{0:F2} {1}";
            Func<Unit, object> name = unit => unit.Name;
            Func<Unit, object> value = unit => unit.Value;

            long i0 = 0;             // 0 bytes
            long i1 = 1;             // 1 byte
            long i2 = 1023;          // 1023 bytes
            long i3 = 1024;          // 1 KB
            long i4 = 2560;          // 2.5 KB
            long i5 = 1048576;       // 1 MB
            long i6 = 720371127;     // 686.9994421005249 MB
            long i7 = 1073741824;    // 1 GB
            long i8 = 1099511627776; // 1 TB

            Console.WriteLine(i0.ToUnit().AsString(template, value, name));
            Console.WriteLine(i1.ToUnit().AsString(template, value, name));
            Console.WriteLine(i2.ToUnit().AsString(template, value, name));
            Console.WriteLine(i3.ToUnit().AsString(template, value, name));
            Console.WriteLine(i4.ToUnit().AsString(template, value, name));
            Console.WriteLine(i5.ToUnit().AsString(template, value, name));
            Console.WriteLine(i6.ToUnit().AsString(template, value, name));
            Console.WriteLine(i7.ToUnit().AsString(template, value, name));
            Console.WriteLine(i8.ToUnit().AsString(template, value, name));
        }
		
		public void Method_2()
        {
            var template = "{0:F2} {1}";
            Func<Unit, object> name = unit => unit.Name;
            Func<Unit, object> value = unit => unit.Value;

            long i0 = 0; 			 // 0 bytes
            long i1 = 1; 			 // 1 byte
            long i2 = 1023; 		 // 1023 bytes
            long i3 = 1024;          // 1024 bytes 
            long i4 = 2560;          // 2560 bytes
            long i5 = 1048576;       // 1024 KB
            long i6 = 720371127;     // 686.9994421005249 MB
            long i7 = 1073741824; 	 // 0.0009765625 TB
            long i8 = 1099511627776; // 1 TB

            Console.WriteLine(i0.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i1.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i2.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i3.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i4.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i5.ToUnit(UnitType.KB).AsString(template, value, name));
            Console.WriteLine(i6.ToUnit(UnitType.MB).AsString(template, value, name));
            Console.WriteLine(i7.ToUnit(UnitType.TB).AsString(template, value, name));
            Console.WriteLine(i8.ToUnit(UnitType.TB).AsString(template, value, name));
        }
    }
}

// Output Method_1
// 0.00 Byte
// 1.00 Byte
// 1023.00 Byte
// 1.00 KB
// 2.50 KB
// 1.00 MB
// 687.00 MB
// 1.00 GB
// 1.00 TB

// Output Method_2
// 0.00 Byte
// 1.00 Byte
// 1023.00 Byte
// 1024.00 Byte
// 2560.00 Byte
// 1024.00 KB
// 687.00 MB
// 0.00 TB
// 1.00 TB
```

**To String**
```csharp
using System;
using System.Collections.Generic;
using System.Globalization;
using ShogunLib;

namespace JustShogunLibSamples
{
    public class StringSamples
    {
        public void Method()
        {
            Console.WriteLine(123.AsString());
            Console.WriteLine(123.AsString("Hello"));
            
            var value = new Tuple<string, int>("Hello", 1);
            var template = "[{0} {1}]";

            Console.WriteLine(value.AsString(template, x => x.Item1, x => x.Item2));
            Console.WriteLine(value.AsString(x => string.Format(CultureInfo.InvariantCulture, template, x.Item1, x.Item2)));

            var list = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(list.JoinString(", "));
            Console.WriteLine(list.JoinString(", ", i => i + 1));
        }
    }
}

// Output Mothod
// 123
// Hello
// [Hello 1]
// [Hello 1]
// 1, 2, 3, 4, 5
// 2, 3, 4, 5, 6
```
**Events**
```csharp
using System;
using ShogunLib.Events;

namespace JustShogunLibSamples
{
    public class EventsSamples
    {
        public event EventHandler<EventArgs> Event1;

        public event EventHandler<SimpleEventArgs<Tuple<string, int>>> Event2;

        public void Method()
        {
            // Safe raise of Event1 with your own EventArgs instance
            Event1.Raise<EventArgs>(this, new EventArgs());

            // Safe raise of Event2 with SimpleEventArgs<Tuple<string, int>> instance
            // and you don't need to provide SimpleEventArgs instace, 
            // code will do it insted of you.
            Event2.Raise(this, new Tuple<string, int>("Hello", 10));
        }
    }
}
```

## License ##

ShogunLib is open source software, licensed under the terms of MIT license. 
See [LICENSE](LICENSE) for details.