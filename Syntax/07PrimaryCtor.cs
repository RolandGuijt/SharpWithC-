var t = new TestClass("Roland", "Guijt");
//Name is not a member of this class, so this.Name doesn't work
//No properties are auto-generated
class TestClass(string firstName, string lastName)
{
    public int MyProperty { get; set; }
    public string FullName => $"{firstName} {lastName}";

    //When changed in a method, field is created automatically
    //which is implictly initialized in ctor
    void AddSuffix()
    {
        lastName = $"{lastName} sr.";
    }
}

//inheritance. Calling base ctor works too
class DerivedClass(string firstName, string lastName, int salary)
    : TestClass(firstName, lastName)
{

}

////Very usable with DI
//public interface IService
//{
//    Distance GetDistance();
//}

//public class ExampleController(IService service) : ControllerBase
//{
//    [HttpGet]
//    public ActionResult<Distance> Get()
//    {
//        return service.GetDistance();
//    }
//}

