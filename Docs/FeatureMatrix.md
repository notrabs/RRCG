# Feature Matrix
 
 [Back](../README.md)
 
 List of [language features](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/) currently implemented. If something is marked as implemented, but not working properly, please report a bug. If you think a particular feature is especially valuable feel free to suggest it or even contribute yourself.

## Data Types

**Implemented:** `bool`, `int`, `float`, `string`, all the RRTypes

**Partially Implemented:** `Vector3`, `Quaternion`, `Color`

These Unity data types should work as they do in Unity, but not all methods/properties might have translations yet.

Any other type will not be translated. This is intentionally allowed to allow you to write simple statements to access your Unity scene and retrieve information. If you need more complex logic, it should be placed outside of an `rrcg.cs` file.

## Arithmetic Operators

**Implemented**: `+`, `-`, `*`, `/`, `%`, `++`, `--`, `op=`, `()` 

Uses the standard c# operator precendence. 
Will try to pre-calculate constants in C#, but place CV2 chips once necessary.
Note that only `int` and `float` are supported (and `string` for concatentaion)

## Boolean Operators

**Implemented**: `!`, `&&`, `||`

Uses the standard c# operator precendence. Will try to pre-calculate constants in C#, but place CV2 chips once necessary.

## Bitwise and shift operators

not implemented yet

## Collection expressions

not implemented. Is there a use-case?

## Equality/Comparison operators

**Implemented**: `==`, `!=`, `>`, `<`, `>=`, `<=`

`!=` is implemeted as `Not(Equals(...))`. If used in an if expressions, the not chip might be optimized away by swapping the then/else branches of the chip.

## Indexer access

**Implemented**: `List[index]`

Using the indexer will create a list get/set element chip if needed.

**Not implemented**: Complex range expresssions using `^` or  `..` 

## Ternary operator

not implemented yet

## Null-conditional operators

not implemented. Could be nice to check validity of objects.

## Type operators

**Implemented**: Explicit cast operations should translate well during compilation

**Not implemented**: `is`, `as`, `typeof`. Type-testing operators have no equivalent in game

## Assignment operator

Implemented partially. With a current limitation that conditional information will be lost. Only assignments within the current scope are safe. There are plans to support automatic insertion of e.g. `If Value` chips when assiging from an if statement eventually.

To Test: Do `ref` assignments and null-coalsescing assignements work?

## Lambda expressions

implemented

## Pattern matching

Not implemented. The `value switch` could be an interesting candidate for the Value Switch chip

## Async/Await

Not implemented. Maybe this would be nice syntax for delays or the async chips?

## Declaration Statements

implemented

## Exception-handling statements

**Implemented:** `throw`

 Will end the current execution flow (e.g. `throw null;`)

**Not implemented:** `try`, `catch`, `finally`

## Iteration statements 

**Implemented:** `while`, `do`

Will place equivalent circuitry to implement the loops.

**Not implmented:** `for`, `foreach`

## Selection statements

**Implemented:** `if`, `else`, `switch`

Switch only supports int and string cases and single values without case guards. Basically what the in-game chip also supports.

## Jump statements 

**Implemented:** `break`, `continue`, `return`

Note that return only works as expected for void functions. In a value function only the last returned value will currently be returned. (This is the same limitation as given for the assignment operator)

**Not Implmented:** `goto`

## String interpolation

not implemented yet. You can use string concatention with `+`

## Misc

**Not supported:** `checked`, `unchecked`, `fixed`, `lock`, `using`, `yield`, unsafe code and pointers

These will probably never make sense
