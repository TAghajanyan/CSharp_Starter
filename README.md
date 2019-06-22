# CSharp_Study
## [Variables](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables "C# Types and Variables")


### The data type is implicitly converted to

* __sbyte__ 	 ->  short, int, long, float, double, decimal  

* __byte__  	 ->  short, ushort, int, uint, long, ulong, float, double, decimal  

* __short__    ->  int, long, float, double, decimal  

* __ushort__   ->  int, uint, long, ulong, float, double, decimal  

* __int__  	   ->  long, float, double, decimal  

* __uint__  	 ->  long, ulong, float, double, decimal  

* __long__  	 ->  float, double, decimal  

* __ulong__  	 ->  float, double, decimal  

* __char__  	 ->  ushort, int, uint, long, ulong, float, double, decimal  

* __float__  	 ->  double 


___

### Conditional Statements "[if-else](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator#conditional-operator-and-an-ifelse-statement)"

```C#
if (Boolean expression)
{
    Body of the conditional statement;
}
else
{   
    Body of the else statement;
}
```


### Conditional Statement "[switch-case](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch)"

```C#
switch (integer_selector)
{
    case integer_value_1:
        statements;
        break;
    case integer_value_2:
        statements;
        break;
    // …
    default:
        statements;
        break;
}
```
