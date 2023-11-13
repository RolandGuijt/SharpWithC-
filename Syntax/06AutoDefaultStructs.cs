struct Coordinate
{
    //With a value type, in a ctor not all props have to be initialized explicitly anymore
    public Coordinate()
    {
        X = 0;
    }
    public int X { get; set; }
    public int Y { get; set; }
}
