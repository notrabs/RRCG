# RRCG - Rec Room Circuit Generator
---
> :warning: **Consider upvoting this feature request**: https://recroom.featureupvote.com/suggestions/482338/circuits-api
> 
> We need official support for programmatic circuit manipulation to bring generated circuits into the game.
---

What if you never had to move a wire by hand? What if circuits were automatically organized?

![example-circuit](/Docs/Images/header.png)

<!-- toc -->

## Install

### For development

For development: Clone the repository into the "Packages" folder of your Studio project.

e.g. as a submodule: `git submodule add https://github.com/notrabs/RRCG.git Packages/RRCG`

### via Git URL

Open `Packages/manifest.json` with your favorite text editor. Add following line to the dependencies block:
```json
{
  "dependencies": {
    "com.rrcs.RRCG": "https://github.com/notrabs/RRCG.git"
  }
}
```

## Using the Compiler

1. Add the `RRCG` prefab to your Scene (Place it in a location with enough space. The chip area will grow to the top-right)
2. Open the Inspector of the RRCG prefab
3. Link a Script file
4. Click Compile Circuit
5. Click Build Circuit (currently not supported)

#### DOT Graph
A DOT graph is a standard graph format that can be visualized online. You can copy a DOT into your clipboard by pressing the button in the inspector.
(e.g. [https://dreampuf.github.io/GraphvizOnline/](https://dreampuf.github.io/GraphvizOnline/))

## Writing Code

The goal of this language is to be an intuitive, direct mapping of C# to Circuits. With the C# execution flow being mapped to exec lines and data flow being mapped to data lines.
Language features should do what you expect in C# also in circuits.

### The Circuit Descriptor
The Circuit Descriptor is your entry point. Your chips start building from the CircuitGraph() method, but beyond that you can organize your code however you like. The only limitation for now is that the compiler only supports translating a single file at a time.
```c#
public class ExampleRoom : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        // Your circuits go here
    }
}
```

### Data flow

Ports are data. Data is Ports. Don't worry what the type system might say. Write code as you usually would.

```c#
public void MyRoom()
{
    Chips.EventReceiver(RoomEvents.Hz30);
  
    int rand1 = Chips.RandomInt(0, 10);
    var rand2 = Chips.RandomInt(0, rand1);
  
    if (rand1 + rand2 > 10) Chips.LogString("Today's your lucky day");
    else Chips.LogString("Try again next time");
}
```

### Exec flow

Functions are invisible. In most cases the execution flow follows the first pin. If a Chip has no exec input, it automatically starts a new graph.

```c#
public override void CircuitGraph()
{
    Chips.EventReceiver(RoomEvents.Hz30);
  
    var rand1 = MyFunction();
    Chips.LogString(Chips.ToString(rand1));

    Chips.EventReceiver(RoomEvents.Hz30);
    Chips.LogString("1");
}

public void MyFunction()
{
    return Chips.RandomInt(1, 2);
}
```

## Building Code (.generated.cs files)
TODO

## Roadmap
Things to do that are in scope of the RRCG project. Although contributions are welcome, even if not listed here.
- [ ] Circuit Building Backend (with an official API)
- [ ] Support more CV2 features
  - [ ] Circuit Boards
  - [ ] Variable Kinds
  - [ ] Event Kinds
  - [ ] ... (basically anything that can be configured)
- [ ] Support more C# language features
  - [ ] returns (for execs and values)
  - [ ] value switches
  - [ ] (automatic) type casts
- [ ] Compiler improvements
  - [ ] Can the workflow be made faster? ([Source Generators](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) would be nice)
  - [ ] Support more than one file for compilation (automatic dependencies?)
- [ ] Circuit Formatter improvements
  - [ ] Improve chip size estimation 
  - [ ] Allow formatting a selection of circuits (with an official API)
- [ ] Decompilation (Circuits to Code)
  - [ ] This wouldn't be perfect, but could be nice to build a library
- [ ] Optimization ideas
  - [ ] Collapse math operations (e.g. multipler adds into a single chip)
  - [ ] Automatically replace multiple "Equal-Ifs" with switches (also in combination with returns)
- [ ] Online playground
  - [ ] Would be great for documentation 

## Useful Resources
* [Roslyn Quoter](https://roslynquoter.azurewebsites.net/)
* [DOT Graph Visualizer](https://dreampuf.github.io/GraphvizOnline/)
