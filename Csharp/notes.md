# csharp Study Note

## [Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/index)

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

#### Access modifier

to control the accessibility of the method (from where it can be called)

- private: most restrictive and allows access to the method only from within the containing class or struct

- public: least restrictive, allowing access from any code in the application

- protected: allows for access from within the containing class or from within derived classes

- internal: accessible from files within the same assembly

- static: indicates the method is a static member of the class rather than a member of an instance of a specific object

#### Overloaded Method

The signature of a method includes its name and its parameter list. The return type or the order of parameters is not part of the signature.

```csharp
void StopService()
{
   // This method accepts no arguments
}

void StopService(string serviceName)
{
   // This method overload accepts a single string argument
}

void StopService(int serviceId)
{
   // This method overload accepts a single integer argument
}
```

#### Optional Parameter

denote an optional parameter is the inclusion of a default value

```csharp
void StopService(bool forceStop, string serviceName = null, int serviceId =1)
{
   // code here that will stop the service
}
```

### Variables

these are identifiers or names, that you create to hold values or references to objects in your code. A variable is essentially a named memory location

### [Reserved Key Words](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/index)

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

```csharp
int myInt = 123;
long myLong = myInt;
```

### Explicit

#### option 1

```csharp
double myDouble = 123.4;
int myInt = (int)myDouble;
```

#### option 2: [Convert class](https://docs.microsoft.com/en-us/dotnet/api/system.convert?view=netframework-4.7.2)

```csharp
double myDouble = 123.4;
int myInt = Convert.ToInt32(myDouble);
```

#### option 3: type specific methods

```csharp
bool myBool = Int32.TryPrase(myDouble, out myInt);
// option D:
int myInt = Int32.Parse(myDouble);
```