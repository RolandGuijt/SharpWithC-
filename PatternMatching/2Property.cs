
var p = new Person("Roland", "Guijt", new Address("Singel", "Amsterdam"));

//Property pattern
//Pre C# 10
//if (p is Person { Address: { City: "Amsterdam" } } person)

//null check + Person check (boolean pattern, includes null check) + property value check
if (p is Person { Address.City: "Amsterdam" } person)
Console.WriteLine(person.FirstName);

public record Person(string FirstName, string LastName, Address? Address);
public record Address(string Street, string City);

