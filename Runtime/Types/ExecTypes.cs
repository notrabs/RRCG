namespace RRCGSource
{
    /// <summary>
    /// An alternative execution output on the chip. e.g. on asynchronous chips.
    /// </summary>
    public delegate void AlternativeExec();

    /// <summary>
    /// An alternative execution output on the chip. e.g. on asynchronous chips.
    /// </summary>
    /// <param name="chipValues">The ouput ports of the current chip. Since the return of the chip function is not available in delegates, use this function instead.</param>
    public delegate void AlternativeExec<T>(T chipValues);
}
