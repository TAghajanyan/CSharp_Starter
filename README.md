# CSharp_Starter
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

___

* Loops
    * [While](https://www.tutorialsteacher.com/csharp/csharp-while-loop), [do-while](https://www.tutorialsteacher.com/csharp/csharp-do-while-loop)
    * [For](https://www.tutorialsteacher.com/csharp/csharp-for-loop)
    * [Foreach](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in)
    * [Nested loops](https://stackoverflow.com/questions/41372709/how-do-nested-for-loops-work-in-c-sharp)

---

#### While, do-while
```C#

while (condition) //Condition is returns a Boolean result - true or fals
{
    // loop body;
}

-----------------------

do
{

    // loop body;
    
}while(condition)

```

---

#### For
```C#

for(initialization; condition; updata)
{
    // loop body;
}


// infinite loop
for(; ; )
{
    // loop body;
}

```

---

#### Foreach loops

```C#

foreach (type variable in collection)
{
    // statements;
}

```

---

#### Nested loops

```C#

for(initialization; condition; updata)
{
    for(initialization; condition; updata)
    {
        // nested loop body;
    }
}

```

___

#### [DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=netframework-4.8)

* __d__  Represents the day of the month as a number from 1 through 31.


* __dd__  Represents the day of the month as a number from 01 through 31.

* __ddd__  Represents the abbreviated name of the day (Mon, Tues, Wed etc).

* __dddd__  Represents the full name of the day (Monday, Tuesday etc).

* __h__  12-hour clock hour (e.g. 4).

* __hh__  12-hour clock, with a leading 0 (e.g. 06)

* __H__  24-hour clock hour (e.g. 15)

* __HH__  24-hour clock hour, with a leading 0 (e.g. 22)

* __m__  Minutes

* __mm__  Minutes with a leading zero

* __M__  Month number(eg.3)

* __MM__  Month number with leading zero(eg.04)

* __MMM__  Abbreviated Month Name (e.g. Dec)

* __MMMM__  Full month name (e.g. December)

* __s__  Seconds

* __ss__  Seconds with leading zero

* __t__  Abbreviated AM / PM (e.g. A or P)

* __tt__  AM / PM (e.g. AM or PM

* __y__  Year, no leading zero (e.g. 2015 would be 15)

* __yy__  Year, leadin zero (e.g. 2015 would be 015)

* __yyy__  Year, (e.g. 2015)

* __yyyy__  Year, (e.g. 2015)

* __K__  Represents the time zone information of a date and time value (e.g. +05:00)

* __z__  With DateTime values, represents the signed offset of the local operating system's time zone from
         Coordinated Universal Time (UTC), measured in hours. (e.g. +6)

* __zz__  As z, but with leading zero (e.g. +06)

* __zzz__  With DateTime values, represents the signed offset of the local operating system's time zone from UTC,measured in hours and              minutes. (e.g. +06:00)

* __f__  Represents the most significant digit of the seconds fraction; that is, it represents the tenths of a second in a date and time          value.

* __ff__  Represents the two most significant digits of the seconds fraction in date and time

* __fff__  Represents the three most significant digits of the seconds fraction; that is, it represents the milliseconds in a date and              time value.

* __ffff__  Represents the four most significant digits of the seconds fraction; that is, it represents the ten thousandths of a second             in a date and time value. While it is possible to display the ten thousandths of a second component of a time value, that               value may not be meaningful.

* __fffff__  Represents the five most significant digits of the seconds fraction; that is, it represents the hundred thousandths of a                second in a date and time value.

* __ffffff__  Represents the six most significant digits of the seconds fraction; that is, it represents the millionths of a Second in a               date and time value.

* __fffffff__  Represents the seven most significant digits of the seconds fraction; that is, it represents the ten millionths of a                    second in a date and time value.
