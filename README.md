# RRCG - Rec Room Circuit Generator

What if you never had to move a wire by hand? RRCG brings text-based scripting support to [Rec Room's](https://recroom.com/) visual scripting language CV2.

![example-circuit](./Docs/Images/header.png)


| :warning: WARNING |
| --- |
| **Consider upvoting this feature request**: **https://recroom.featureupvote.com/suggestions/482338/circuits-api** <br /> This package only contains the compiler frontend to validate the graph generation. Wihout a proper Circuits API the conversion into actual graphs is to unstable to release. |

<!-- toc -->

1. [Install](#install)
2. [Using the Compiler](#using-the-compiler)
3. [Writing Code](#writing-code)
4. [Troubleshooting](Docs/Troubleshooting.md)
5. [Feature Matrix](Docs/FeatureMatrix.md)


## Install

RRCG comes as a Unity package to be installed in your [Rec Room Studio](https://docs.alexagirl.studio/docs) project.

[Using the Package Manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html) install a package from this Git URL: 
`https://github.com/notrabs/RRCG.git`

<details>
<summary> How to Update </summary>

Occasionally an update might include breaking changes, most likely if chips get changed or the compiler internals are changed. This can invalidate RRCG's generated files. To safely update, please follow these steps:

1. **Make sure Unity is open before you update**
2. Update using the Package Manager (or git) 
3. If you get errors in generated files => Use "Clean All" in the window menu
4. If you get errors in source files => Resolve them manually (e.g. adjust to chip changes)
5. Hit "Recompile All" to make sure your files are compiled with the latest compiler

</details>

<details>
<summary> For development </summary>

Clone the repository into the "Packages" folder of your Studio project.

e.g. as a submodule: `git submodule add https://github.com/notrabs/RRCG.git Packages/RRCG`
</details>


## Using the Compiler

1. Create a prefab from the `RRCG` window menu. Place it in a location with enough space. The chip area will grow as indicated by the arrows.
2. Open the Inspector for the `RRCG` prefab
3. Select a `CircuitDescriptor` (or use the [example](https://github.com/notrabs/RRCG/blob/main/Example/ExampleRoom.rrcg.cs))
4. Click `Build Circuit` (placeholder for now. Until we have a Circuits API you can only create the debug DOT Graph)

<details>
<summary> RRCG script files </summary>

RRCG compiles every file in your project with a `.rrcg.cs` extension. Any `CircuitDescriptor` class that was successfully compiled by RRCG will be available to select in the RRCG inspector. See the next chapter for how to write valid code.

You can get started with this [example file](https://github.com/notrabs/RRCG/blob/main/Example/ExampleRoom.rrcg.cs) that is configured by default when you spawn the prefab.
</details>

<details>
<summary> Standalone Projects </summary>

RRCG offers an advanced standalone compiler to speed up your iteration cycles. It bypasses Unity's dreadingly slow Assembly Reload, without sacrificing any major benefits that come from being integrated into Unity. The main difference in development is where the script files are located. Instead of in the `Assets` folder, your circuit scripts are placed inside an `RRCG` folder in the project root. The syntax and your access to Unity data stays the same.

Technically this is achieved by dynamically compiling and loading each iteration of your code. This works for RRCG (and not regular Unity Editor code), because RRCG code contains no side-effects beyond the compilation process.

The main limitation for now is that there is no mechanism for dependencies between standalone projects yet, but you can still reference any assembly compiled within your regular Assets. So the compromise for now is that shared RRCG code needs to stay within the slow Unity compiler.

To get started using standalone projects:
1. Open the Inspector for your `RRCG` prefab
2. Select the "Standalone Project" option
3. Create a new project (or select an existing one)
4. Wait for the initial compilation
5. Select a Descriptor from the project (the project generates with a standard one)
6. Open the RRCG_Project.sln in the `RRCG` folder of your Project root

After that, you can build circuits like with the integrated workflow, just without waiting. Subsequent builds within a session should also see additional speed ups thanks to caching mechanisms.

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

The Circuit Descriptor is your entry point. Your chips start building from the `CircuitGraph()` method, but beyond that you can organize your code however you like. Place it inside a `.rrcg.cs` file anywhere in your project.

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

<details>
<summary> Circuit Libraries </summary>

If you want to create reusable logic without an entry point, extend the `CircuitLibrary` class instead. 
This will also hide the class in the Circuit Selection menu. Place it inside a `.rrcg.cs` file anywhere in your project.

```c#
using RRCGSource;

public class ExampleLibrary : CircuitLibrary
{
    // Your circuits go here.
    // You can use it as a normal class or with static methods.
}
```

</details>

<details>
<summary> Additional Entry Points </summary>

A room is usually made up of multiple graphs. 
You can create separate graphs within a function by using exec chips with no exec inputs, or the `StartNewGraph()` method. 
But for code organization it is often nicer to have them as separate methods. 
Use the `[CircuitGraph]` attribute to mark functions in your CircuitDescriptor as additional entry points. 
Note that they must be parameterless functions to work.

```c#
public class ExampleRoom : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        // Your 1st graph goes here

        EventReceiver(); // implicitly creates a new graph, because receivers have no exec input.

        // Your 2nd graph goes here

        StartNewGraph(); // explicitly creates a new graph.

        // Your 3rd graph goes here
    }

    [CircuitGraph]
    void Foo()
    {
        // Your 4th graph goes here
    }
}
```

Sometimes you need an exec chip, without connecting it to your exisiting execution flow. 
You could place it in a separate graph and reference to it with variables, but that quickly gets very verbose.
Instead use the `InlineGraph()` helper to create new graphs without destryoing your current context.

```c#
public class ExampleRoom : CircuitDescriptor
{
    EventDefinition<string> onInput = new EventDefinition<string>();

    public override void CircuitGraph()
    {
        ChipLib.Log("Start");

        // Placing a receiver would normally create a new graph. This only extracts its data.
        var input = InlineGraph(() => onInput.Receiver());

        // This log chip will be connected to the previous log chip, but get the data from the event receiver.
        ChipLib.Log(input);
    }
}
```

</details>

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

In addition to placing chips explicitly, you can also use the shorthands provided in the classes of RR types.

```c#
public void ExampleCircuit()
{
    SetPosition(GetLocalPlayer(), new Vector3(1,2,3));
    // or
    GetLocalPlayer().Position = new Vector3(1,2,3);
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

    // AwaitDelay() continues on the delayed line of a Delay chip. Useful if you don't need immediate logic.
    ChipLib.AwaitDelay();
    ChipLib.AwaitDelay(1);
}
```

### Event Helpers

The `EventDefintion` class helps you to write type-safe code. You can define the structure of an event once, and then place all event chips with correct typings:

```c#
// This will create a new event definition named "onInput"
EventDefintion<int> onInput = new EventDefintion<int>("value");

public void ExampleCircuit()
{
    // Start new circuit graphs at the receiver
    var data = onInput.Receiver();

    // Send Events using one of the sender functions
    onInput.SendLocal(123);
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

Access your existing events with the `ExistingEvent` function:

```c#
// This assumes an Event definition with name "EventName" and one int value is already placed in the room
EventDefintion<int> onInput = ExistingEvent<int>("EventName");
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

The `Variable`, `SyncedVariable` and `CloudVariable` classes help you to write type-safe code. Instance and Synced Variables are named automatically and uniquely.

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


## Custom Building Code (.rrcg.gen.cs files)

For more advanced use-cases, the C# source code translation might not be expressive enough for your needs. 
Expecially the conversion of control structures is limiting, if you want to create dynamic circuits.

One simple example for dynamic chip generation is the `ChipLib.Log(object)` helper. 
It needs to insert a ToString chip, if and only if the inputted data is not already a string.

If you look at the ChipLib implementation you'll notice that the source-realm (=`RRCGSource` namespace) function is empty:
```c#
namespace RRCGSource {
    /// <summary>
    /// Logs a value to the console with automatic ToString conversion
    /// </summary>
    public static void Log(object obj) { }
}
```

Unlike normally compiled code, the ChipLib has been manually translated into the build-realm (=`RRCGBuild` namespace) to take advantage of customized building code.

```c#
namespace RRCGBuild {
    public static void Log(AnyPort obj)
    {
        StringPort stringPort;
        if (obj is StringPort sp) stringPort = sp;
        else stringPort = obj.ToString();

        LogString(stringPort);
    }
}
```

For normal RRCG scripts this conversion happens automatically with the compiler.

#### Compilation Pipeline

To understand how the build realm fits into the compilation process, it helps to have a rough idea on how RRCG is implemented. 

![image](./Docs/Images/flow_chart.png)

The conversion of RRCG scripts into CV2 circuits does not happen in a single step.
The source-realm code you write isn't executable. 
The actual circuit graph building happens when the build realm code (=`rrcg.gen.cs` files) is executed.
Most of the magic of RRCG happens in the first syntax transformation that converts your code into executable build-realm automatically.


It is during the execution of the build-realm code that we can also execute custom building code to create chips with standard C# logic. Since we are not limited by the syntax of a small C# subset, we can have more control at the price of a bit more verbose syntax.

#### Writing Build Realm code

Build-realm code is roughly structured like normal RRCG scripts. 
You can look at the generated files to get an idea, but the main concept to understand is that calling a circuit function will spawn that node into the current graph.
The functions get access to the current graph via the static `Context.current` property, so the timepoint of execution dicatates where chips are placed in the execution flow.
At the same time also only executed functions have their chips placed. 

For example, this means that unlike in the source-realm, this function will only spawn one chip. 
```c#
namespace RRCGBuild {
    void BuildFunction(){
        // This if is an actual if in the build-realm. Executing it will evaluate 
        // the bool as "true", and go into the if branch.
        if (true) {
            LogString("Chip A");
        } else {
            // This chip will not spawn, because the code is not reachable
            LogString("Chip B");
        }
    }
}
```

Having full c# capabilities back in turn means, that there is also no magical interchangeability between C# data and CV2 data anymore. 
You need to be explicit about what is CV2 data and what is a regular C# type.
RRCG uses the `[...}Port` classes to distinguish one from the other.
The CV2 type can be obtained by appending "Port" to the original type name:

* `bool` => `BoolPort`
* `string` => `StringPort`
* `Player` => `PlayerPort`
* ...

These Port classes are still fairly clever as they implement a lot of the logic that you already know from the source-realm.
For example doing arithmetic on `FloatPorts` will still only create math chips as needed.
Only once the Port is an actual port that belongs to a chip a connection will be made when it is used.

```c#
void BuildFunction(){
    FloatPort valA = 1;
    FloatPort valB = 5;
    FloatPort abs = AbsoluteValue(valA - valB);
}
```

#### Get started

To use the build realm simply write your code in a non-compiled file and provide an interface to it in both, the `RRCGSource` and `RRCGBuild` namespaces.
More documnentation to come, but looking at the ChipLib source would be a good place to start looking for inspiration. 


## Roadmap

Things to do that are in scope of the RRCG project. Although contributions are welcome, even if not listed here.

- [ ] Circuit Building Backend (with an official API)
- [ ] Support more CV2 features
- [ ] Support more C# language features
- [ ] Compiler improvements
- [ ] Circuit Formatter improvements
- [ ] Decompilation (Circuits to Code)
- [ ] Circuit Graph Optimization
- [ ] Online playground ([SharpLab](https://github.com/ashmind/SharpLab) looks prmomising)


## Useful Resources

- [Roslyn Quoter](https://roslynquoter.azurewebsites.net/)
- [DOT Graph Visualizer](https://dreampuf.github.io/GraphvizOnline/)
- [CV2 chip definitions](https://github.com/tyleo-rec/CircuitsV2Resources/blob/master/misc/circuitsv2.json)
