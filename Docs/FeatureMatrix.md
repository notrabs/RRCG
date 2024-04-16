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

Note: There is no short-circuiting similar to the in-game chips. Use multiple if's to emulate this behavior.

## Bitwise and shift operators

**Implemented:** `~`, `<<`, `>>`, `&`, `^`, `|`

Like boolean operators, results for constants will be calculated ahead of time, but chips will be placed where necessary.

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

**Implemented:** Ternary operators are supported and map to If Value chips.

```
float a = 12.34f;
float b = 19.87f;
RandomFloat(0, true ? a : b);
````

Implicit conversions are also supported, for inputs and the result:
```
float portA = RandomFloat(0, 1);
int portB = RandomInt(0, 10);
ChipLib.Log($"Result: {(false ? portB : portA)}");
````

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

**Implemented:** `value switch`

Switch Expressions are implemented and map to value switch chips in-game. They will be evaluated ahead-of-time if the match value is pure-data, but will fallback to using Value Integer/String Switch chips otherwise.
As such the restrictions are that the match value must be an integer or string, and the match patterns must be constant values.

**Not implemented:** Advanced pattern matching (case guards, etc)

## Async/Await

Not implemented. Maybe this would be nice syntax for delays or the async chips?

## Declaration Statements

implemented

## Exception-handling statements

**Implemented:** `throw`

 Will end the current execution flow (e.g. `throw null;`)

**Not implemented:** `try`, `catch`, `finally`

## Iteration statements 

**Implemented:** `while`, `do`, `foreach`

Will place equivalent circuitry to implement the loops.
If the iterator has a native CV2 chip (e.g. For Each), RRCG will prefer to use it, but will swap it out with an equivalent manual implementation if required to preserve semantics (e.g. delays, return, break).

**Not implmented:** `for`

## Selection statements

**Implemented:** `if`, `else`, `switch`

Switch only supports int and string cases and single values without case guards. Basically what the in-game chip also supports.

## Jump statements 

**Implemented:** `break`, `continue`, `return`, `goto` (and `goto case`)

In the cases where you're returning in a `void` function, or you only return a single value from a function, execution flow will merge & the single port will be returned. If you have multiple returns within a non-`void` function, RRCG will automatically create & place event senders at each return location to cache the return data, which will be read from a corresponding event receiver.

Gotos will jump to the first exec input after the label declaration. If you declare a label but don't use a chip that takes an exec input somewhere ahead of it, it will not resolve correctly and you'll get an error when building your graph.

C# scoping rules apply to labels: 
* you *can't* goto a label declared in a child scope
* you *can* goto a label defined in a parent scope
* you *can't* goto a label defined in a different function (also meaning no cross-context gotos, e.g. Circuit Boards, etc)

Note that for gotos, RRCG is unable to determine conditional assignments ahead of time. Using `goto case` in a `switch` statement works as you expect, but anything else will have to be implemented manually using the Variable classes.

## String interpolation

**Implemented:** String interpolation with data & real ports: `$"Hello, {nameVar.Value}!";`

Automatically converts ports/data to strings where necessary: `$"My favourite colour is {new Color(0, 0, 1)}!";`

**Not implemented:** Alignment clauses, format clauses.

## Unsafe Code

Supported, but not in the way you expect. The `unsafe` keyword is used when declaring a block or method as a way to tell RRCG not to rewrite their syntax. It does not allow you to use pointers or any other C# features that require an unsafe context.

This is a more advanced feature, mainly intended for when you need untranslated helpers that wouldn't quite fit having their own (non-`.rrcg.cs`) file.

## Misc

**Not supported:** `checked`, `unchecked`, `fixed`, `lock`, `using`, `yield`, and pointers

These will probably never make sense
