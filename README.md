# RRCG - Rec Room Circuit Generator

What if you never had to move a wire by hand? RRCG brings text-based scripting support to [Rec Room's](https://recroom.com/) visual scripting language CV2.

![example-circuit](./Docs/Images/header.png)


| :warning: WARNING |
| --- |
| **Consider upvoting this feature request**: **https://recroom.featureupvote.com/suggestions/482338/circuits-api** <br /> This package only contains the compiler frontend to validate the graph generation. Wihout a proper Circuits API the conversion into actual graphs is to unstable to release. |

<!-- toc -->

1. [Install](#install)
2. [Using the Compiler](#using-the-compiler)
3. [Writing Code](writing-code)
4. [Troubleshooting](Docs/Troubleshooting.md)
5. [Feature Matrix](Docs/FeatureMatrix.md)


## Install

[Using the Package Manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html) install a package from this Git URL: 
`https://github.com/notrabs/RRCG.git`

<details>
<summary> For development </summary>

For development: Clone the repository into the "Packages" folder of your Studio project.

e.g. as a submodule: `git submodule add https://github.com/notrabs/RRCG.git Packages/RRCG`
</details>

---

## Using the Compiler

1. Create a prefab from the `RRCG` window menu. Place it in a location with enough space. The chip area will grow as indicated by the arrows.
2. Open the Inspector for the `RRCG` prefab
3. Select a `CircuitDescriptor` (or use the example)
4. Click `Build Circuit` (placeholder for now. Until we have a Circuits API you can only create the debug DOT Graph)

<details>
<summary> RRCG script files </summary>

RRCG compiles every file in your project with a `.rrcg.cs` extension. Any `CircuitDescriptor` class that was successfully compiled by RRCG will be available to select in the RRCG inspector. See the next chapter for how to write valid code.

You can get started with this [example file](https://github.com/notrabs/RRCG/blob/main/Example/ExampleRoom.rrcg.cs) that is configured by default when you spawn the prefab.
</details>

<details>
<summary> Watch Mode </summary>

With watch mode on all `.rrcg.cs` files in your project are compiled automatically when Unity imports them. This also happens every time you make a change to a script file. There's no downside to leaving it watch mode on, but the option to disable it is there if you want to disable automatic compilation during development.

In case you want to manually recompile a file you can use Unity's reimport functionality or use the "Recompile all" feature from the `RRCG` window menu. This should only be needed after you downloaded a new compiler version or during compiler development.
</details>

<details>
<summary> DOT Graph </summary>

DOT is a standard graph format that can be [visualized online](https://dreampuf.github.io/GraphvizOnline/). You can copy a DOT graph for a compiled circuit by pressing the button in the inspector.
</details>

## Writing Code

The goal of this language is to be an intuitive, direct mapping of C# to Circuits. With the C# execution flow being mapped to exec lines and data flow being mapped to data lines.
C# Language features should do what you expect.

### The Circuit Descriptor

The Circuit Descriptor is your entry point. Your chips start building from the `CircuitGraph()` method, but beyond that you can organize your code however you like. 

```c#
using RRCGSource;

public class ExampleRoom : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        // Your circuits go here
    }
}
```

### Placing Chips

Chips are available as static functions in the `Chips` class. For convenience you can access them through the extended `CircuitDescriptor` class.

```c#
public void ExampleCircuit()
{
    Chips.RandomInt(1,10);
    // or
    RandomInt(1,10);
}
```

### Data flow

Ports are data. Data is Ports. Don't worry what the type system might say. Write code as you usually would. RRCG will create and connect chips when necessary to execute operations.

```c#
public void ExampleCircuit()
{
    EventReceiver(RoomEvents.Hz30);

    int rand1 = RandomInt(0, 10);
    var rand2 = RandomInt(0, rand1);

    if (rand1 + rand2 > 10) LogString("Today's your lucky day");
    else LogString("Try again next time");
}
```

If a chip has multiple outputs, a tuple will be returned

```c#
public void ExampleCircuit()
{
    // The underscore is handy to discard unwanted values
    var (parsed, _) = ParseFloat("1.0");

    // You can also access the named fields of the tuple to quickly get single values
    var value = ParseFloat("1.0").Parsed;
}
```

### Exec flow

Functions are invisible. By default the execution flow follows the first pin. If a Chip has no exec input, it automatically starts a new graph.

```c#
public void ExampleCircuit()
{
    // starts a new graph
    EventReceiver(RoomEvents.Hz30);

    // connects the random chip inside the function directly to the event receiver
    var rand1 = MyFunction();
    LogString(ToString(rand1));

    // starts a new graph
    EventReceiver(RoomEvents.Hz30);
    LogString("1");
}

public void MyFunction()
{
    return RandomInt(1, 2);
}
```

"If" and Execution Switches are fully supported. A `throw` statement ends a branch of execution.

```c#
public void ExampleCircuit()
{
    var num = Random(1,10);

    if (num == 5) {
      LogString("high five");
      throw null;
    } else {
      LogString("else and else if are supported");
    }

    switch (num){
      case 1:
        LogString("1");
        break;
      case 2:
        LogString("2");
        break;
      default:
        LogString("There's gotta be a more efficient way");
        break;
    }
}
```

(returns are in the works)

### Operator Overload

Math Operators and comparisons will create the according chips, and evaluate using c#'s order of operations.

```c#
public void ExampleCircuit()
{
    var result = RandomInt(1,5) + 1 - 2 * 3 / 4 % 5;
    if (result > 0 && result < 0) {
        LogString("This is a scientfic breakthrough");
    }
}
```

### Automatic Casting

The `FromRecRoomObject` chip has been hidden since it doesn't map nicely into c# types. Instead you can use implicit casts to convert objects:

```c#
public void ExampleCircuit()
{
    var text = RecRoomObjectGetFirstwithTag("text");
    // Using text here will automatically insert a FromRecRoomObject chip
    TextSetText(text, "Hello");
}
```

### Circuit Boards

You can generate code for existing circuit boards (or control panels). Their interface needs to be already defined in the game:

```c#
public void ExampleCircuit()
{
    // ... other circuits placed directly in the room

    ExistingCircuitBoard("Board Name", CircuitBoard);
}

public void CircuitBoard()
{
    ExistingExecInput("AddRandom");
    var sum = ExsitingDataInput<int>("number") + RandomInt(1,10);
    ExistingDataOutput("Sum", sum);
    ExistingExecOutput("AddRandom");
}
```

You can create new Circuit Boards from a function. An exec port will be automatically added when executable nodes are inside. The inputs/outputs match the function interface. If you want to return multiple ports, make sure to wrap them in a tuple.

```c#
public void ExampleRoom()
{
    // This board will only have data pins
    var (a, b) = CircuitBoard(MathBoard, 5, -5);

    // This board will have execution pins
    CircuitBoard(RandomBoard, a, b);
}

// the output ports will be named after parameter names and names in the tuple return
public (int sum, int difference) MathBoard(int a, int b)
{
   return (a + b, a - b);
}

public int RandomBoard(int a, int b)
{
   return RandomInt(a, b);
}
```

### Chip Lib

The Chip Lib contains useful helpers to write common patterns. Check back as more are implemented:

```c#
public void ExampleCircuit()
{
    // The EventCache creates a simple event to cache data for later execution ticks
    var expensiveSum = Add(3,4);
    var cachedSum = ChipLib.EventCache<int>(expensiveSum);

    // Log() automatically converts any value ToString
    ChipLib.Log(cachedSum);

    // AwaitDelay() continues on th delayed line of a Delay chip. Useful if you don't need immediate logic.
    ChipLib.AwaitDelay();
    ChipLib.AwaitDelay(1);
}
```

### Event Helpers

The `EventHelper` class helps you write type-safe code. You can define the structure of an event once, and then place all event chips with correct typings:

```c#
EventHelper<int> onInputEvent = new EventHelper<int>("OnInput", "value");

public void ExampleCircuit()
{
    // Place a definition chip in the proper scope, if you need one
    onInputEvent.Definition();

    // Start new circuit graphs at the receiver
    var data = onInputEvent.Receiver();

    // Send Events using the sender
    onInputEvent.Sender(123);
}
```

Access the predefined events using the `RoomEvents` enum:

```c#
public void StudioBoard()
{
    EventReceiver(RoomEvents.Hz30);
    // ... react to event
}
```

Studio Events are referenced by name. There is a small helper to make this more readable, but a named event receiver also works:

```c#
public void StudioBoard()
{
    StudioEventReceiver("StudioEventName");
    // ... react to event
}
```

Use the `[EventFunction]` Attribute to automatically convert a function call into event senders, with all the logic only being placed once in the world. You can return a value like in other functions, where it will be shared by all users.

```c#
public void ExampleCircuit()
{
    // will be placed as two event senders
    ExpensiveFunction("World");
    ExpensiveFunction("World 2");
}

[EventFunction]
public void ExpensiveFunction(string parameter)
{
    // only one LogString will be placed in the world, and retrieve the parameter from the event
    LogString("Hello" + parameter);
}
```

### Variable Helpers

The `Variable`, `SyncedVariable` and `CloudVariable` classes help you to write type-safe code. Instance and Synced Variables are named automatically.

```c#
Variable<int> count = new Variable<int>();
SyncedVariable<int> syncedVarWithHomeValue = new SyncedVariable<int>(2);
CloudVariable<string> cloudVar = new CloudVariable<string>("Name_of_my_Variable");

public void ExampleCircuit()
{
    // Places a configured event receiver
    count.ChangedEvent();

    // Access/Modify the Value using the Value getter/setter
    count.Value = count.Value + 1;
}
```

### Shared Properties

Use the `[SharedProperty]` Attribute to annotate functions that should only be placed once. All calls to this function will connect to the same graph.
This is a bit of syntactic sugar to work around c# not allowing you to access VariableHelpers during initialization. If possible you should place your shared chips into the class body.

:warning: It is up to the user to ensure that SharedProperty functions are pure and do not contain any execs. You can pass parameters into the function, but they will be only connected during the first call of the function.

```c#
// Simple static chips can also be shared by storing them directly in the class.
int SharedTimeChip = TimeGetUniversalSeconds();

VariableHelper roundStarted = new VariableHelper<int>();

public void ExampleCircuit()
{
    ChipLib.Log(RoundTime());
    ChipLib.Log(RoundTime());
}

[SharedProperty]
public int GameTime()
{
    // only placed once in the world
    return SharedTimeChip - roundStarted.Value;
}
```

### Interfacing with Studio Objects

RRCG provides a built-in mechanism to interface with Studio Objects. The goal is to eventually allow you to create all logic within C#. For this your Studio Object needs to be described by a `StudioObjectDescriptor` class in a `.rrcg.cs` file.

```c#
using RRCGSource;

public class MyStudioObject : StudioObjectDescriptor
{
    // Copy this constructor and change the prefab name to match your prefab.
    public MyStudioObject(StudioObject target) : base(target, "StudioObjectPrefabName") { }

    // The [ExistingStudioFunction] allows you to call manually defined Studio Functions.
    // Make sure their interface and name match to the function defined!
    [ExistingStudioFunction]
    public void SetScale(Vector3 scale) { }

    // For manually defined functions return "default". The function will work once in-game.
    [ExistingStudioFunction]   
    public Vector3 GetPosition() { return default; }

    // If your function has multiple outputs, return a tuple
    [ExistingStudioFunction]
    public (Vector3, Quaternion) GetPositionAndRotation() { return default; }

    // Coming soon: A [StudioFunction] attribute to generate Studio Functions automatically from C# code!
}

```
To use a function from a CircuitDescriptor, create an instance of your StudioObjectDescriptor class and call its functions directly.

```c#
public class ExampleRoom : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        var rro = RecRoomObjectGetFirstWithTag("mystudioobj");
        
        // Pass a reference to your studio object. It will be connected to the according event/function pins.
        var myStudioObject = new MyStudioObject(rro);

        // Directly call the functions defined in your StudioObjectDescriptor
        myStudioObject.SetScale(new Vector3(1,2,3));
        var position = myStudioObject.GetPosition();
    }
}
```


### Interfacing with Unity

You can directly call functions in other Editor scripts or libraries. They will be evaluated when you build the circuits.

:warning: Make sure the data passed to outside functions is valid c# data. If it holds a chips' port output, the function needs to support the according `Port` type. Take a look at the "Custom Building Code" chapter to learn more about the compilation process.

```c#
public void ExampleCircuit()
{
    var numOfGameObjects = GameObject.Find("Ball").Count();
    LogString("Number Of GameObjects:");
    LogString(ToString(numOfGameObjects));
}
```

---

## Custom Building Code (.rrcg.gen.cs files)

The conversion of control structures (if,for,...) might not be desireable in some use-cases. Especially when you want to create a dynamic number of chips.

To implement dynamic structures you have to bypass the syntax transformation and write code directly in the build realm (= `generated` files). The syntax there is a bit more verbose, but you have the advantage of being able to use c# features to build code, instead of just describing it.

![image](./Docs/Images/flow_chart.png)

For example to generate n chips in a chain it is not possible to use a for loop:

```c#
// This will transform into a single for chip and a single random chip
public void RRCGSourceRealm() {
    for (int i=0;i<n;i++) {
        Chips.RandomInt(0,i);
    }
}

// In the build realm the for loop stays in the c# code. So you will generate n random chips
public void RRCGBuildRealm() {
    for (int i=0;i<n;i++) {
        ChipBuilder.RandomInt(0,i);
    }
}
```

(Note: for loops are not implemented yet, but this example illustrates the idea)

To use the build realm simply write your code in a non-compiled file.
More documnentation to come, but looking at the ChipLib source would be a good place to start. Note how there's two version of it so it can be used in the `RRCGSource` and `RRCGBuild` namespace with different types.

---

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
  - [ ] conditional values
  - [ ] (automatic) type casts
- [ ] Compiler improvements
  - [ ] Can the workflow be made faster? ([Source Generators](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) would be nice)
  - [ ] Support more than one file for compilation (automatic dependencies?)
  - [ ] Attribute to disable syntax transformation of c# code
- [ ] Circuit Formatter improvements
  - [ ] Improve chip size estimation
  - [ ] Allow formatting a selection of circuits (with an official API)
- [ ] Decompilation (Circuits to Code)
  - [ ] This wouldn't be perfect, but could be nice to build a library
- [ ] Optimization ideas
  - [ ] Collapse math operations (e.g. multipler adds into a single chip)
  - [ ] Automatically replace multiple "Equal-Ifs" with switches (also in combination with returns)
- [ ] Online playground
  - [ ] https://github.com/ashmind/SharpLab looks promising
  - [ ] Would be great for documentation

---

## Useful Resources

- [Roslyn Quoter](https://roslynquoter.azurewebsites.net/)
- [DOT Graph Visualizer](https://dreampuf.github.io/GraphvizOnline/)
- [CV2 chip definitions](https://github.com/tyleo-rec/CircuitsV2Resources/blob/master/misc/circuitsv2.json)
