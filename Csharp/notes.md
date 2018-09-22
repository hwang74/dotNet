# C# Study Note

## Date Types

| type     | size(bytes)     | .NET type       | range                                                   |
|----------|-----------------|-----------------|---------------------------------------------------------|
| int      | 4               | System.Int32    | -2,147,483,648 to 2,147,483,647                         |
| long     | 8               | System.Int64    | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| float    | 4               | System.Single   | +/-3.4 x 10^38                                          |
| double   | 8               | System.Double   | +/-1.7 x 10^308                                         |
| decimal  | 16              | System.Decimal  | 28 significant figures                                  |
| char     | 2               | System.Char     |                                                         |
| bool     | 1               | System.Boolean  | True or False                                           |
| DateTime | 8               | System.DateTime | 0:00:00 on 01/01/0001 to 23:59:59 on 12/31/9999         |
| string   | 2 per character | System.String   |                                                         |

## Identifiers

### Namespaces  

the .NET Framework uses namespaces as a way to separate class files into related buckets or categories. it also helps avoid naming collisions in applications that may contain classes with the same name  

### Classes

classes are the blueprints for reference types. They specify the structure an object will take when you create instances of the class  

### Methods

they are discrete pieces of functionality in an application. They are analogous to functions in the non-object-oriented programming world  

### Variables

these are identifiers or names, that you create to hold values or references to objects in your code. A variable is essentially a named memory location

## Operators

| type                               | operators                                   |
|------------------------------------|---------------------------------------------|
| arithmetic                         | +, -, *, /, %                               |
| increment, decrement               | ++, --                                      |
| comparison                         | ==, !=, <, >, <=, >=, is                    |
| string concatenation               | +                                           |
| logical/bitwise operations         | &, |, ^, @, !, &&, ||                       |
| indexing                           | []                                          |
| casting                            | (), as                                      |
| assignment                         | =, +=, -=, /=, %=, &=, |=, ^=, <<=, >>=, ?? |
| bit shift                          | <<, >>                                      |
| type information                   | sizeof, typeof                              |
| delegate concatenation and removal | +, -                                        |
| overflow exception conytol         | checked, unchecked                          |
| indirection and address            | &, ->, [], &                                |
| conditional (ternary operator)     | ?:                                          |

## Casting / Data Conversion

### Implicit

```c#
int myInt = 123;
long myLong = myInt;
```

### Explicit

```c#
double myDouble = 123.4;
// option A:
int myInt = (int)myDouble;
// option B:
int myInt = Convert.ToInt32(myDouble);
// option C: return true if parsed and store result in variable after 'out'
bool myBool = Int32.TryPrase(myDouble, out myInt);
// option D:
int myInt = Int32.Parse(myDouble);
```