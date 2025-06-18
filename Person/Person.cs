abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    public Person()
    {
        _firstName = "";
        _lastName = "";
        _age = 0;
    }
    public Person(string firstname, string lastname, int age)
    {
        _firstName = firstname;
        _lastName = lastname;
        _age = age;
    }
    public virtual string GetPersonInformation()
    {
        return $"{_firstName} {_lastName} age: {_age}";
    }
    public abstract double GetPay();
}