using RRCGSource;


internal class SyncedArray : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        ReadWrite();

        SyncedArrayInt();
    }

    public void ReadWrite()
    {
        ChipLib.Log("Start before inline definitions.");

        var arrayInt = new SyncedArray<int>(2);
        var arrayFloat = new SyncedArray<float>(4);
        var arrayString = new SyncedArray<string>(6);
        var arrayBool = new SyncedArray<bool>(8);

        arrayInt[0] = 0;
        ChipLib.Log(arrayInt[1]);

        arrayFloat[3] = RandomInt(0, 3);
        ChipLib.Log(arrayFloat[2]);

        arrayString[3] = "test";
        ChipLib.Log(arrayString[5]);

        arrayBool[3] = true;
        ChipLib.Log(arrayBool[0]);
    }

    public void SyncedArrayInt()
    {
        var arrayInt = new SyncedArrayInt(5);

        arrayInt[0] = 0;
        ChipLib.Log(arrayInt[1]);

        SyncedArray<int> casted = arrayInt;

        casted[0] = 0;
        ChipLib.Log(casted[1]);

        arrayInt.Add(4, 5);
    }
}

