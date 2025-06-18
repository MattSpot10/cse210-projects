class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        // Person myPerson = new Person("John", "Doe", 56);

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Crocker", 23, "bat", 30, 40);

        Doctor myDoctor = new Doctor("Bob", "Payne", 43, "Knife", 50000);

        // Console.WriteLine(myPerson.GetPersonInformation());

        // Console.WriteLine(myPoliceMan.GetPoliceManInformation());
        // Console.WriteLine(myDoctor.GetDoctorInformation());


        List<Person> people = new List<Person>();
        people.Add(myDoctor);
        people.Add(myPoliceMan);

        foreach (Person person in people)
        {
            DisplayPersonInformation(person);
        }
    }
    private static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
        Console.WriteLine(person.GetPay());
    }
}