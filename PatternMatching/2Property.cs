
var p = new Person("Roland", "Guijt", new Address("Singel", "Amsterdam"));

//Property pattern
//null check + Person check + property value check
if (p is Person { Address.City: "Amsterdam" } person)
    Console.WriteLine(person.FirstName);

public record Person(string FirstName, string LastName, Address? Address);
public record Address(string Street, string City);

