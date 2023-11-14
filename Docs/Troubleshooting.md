# Troubleshooting

[Back](../README.md)

#### My class doesn't show up in the Inspector UI

1. Make sure your class is in a `.rrcg.cs` file
2. Make sure your class extends `CircuitDescriptor`, not `RRCGSource.CircuitDescriptor` 
3. Make sure there is no compilation errors in the console
4. Try `Recompile All` in the window menu

#### There's compilation errors I can't get rid of

1. Check that the language feature you are using is implemented (see [Feature Matrix](FeatureMatrix.md))
2. Use `Clean All` (and then `Recompile All`) in the window menu to recompile after pulling a new compiler version
3. If nothing helps, disable `Watch Mode` and submit a bug report


