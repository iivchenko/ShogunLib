# ShogunLib #

Set of libraries with some sort of everyday functionality like 
* extension of LINQ
* monads
* event extensions
* ready to use pattern implementations
* etc.

## Samples ##

```csharp
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
```

## License ##

ShogunLib is open source software, licensed under the terms of MIT license. 
See [LICENSE](LICENSE) for details.