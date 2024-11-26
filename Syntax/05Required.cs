//can't change name after construction, but it isn't required
//can use ctor but that will lose default ctor
//required solves this
var p = new Person();


public class Person
{
    public string Name { get; init; }
}
