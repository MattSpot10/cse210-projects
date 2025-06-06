class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Person myPerson = new Person("John", "Doe", 56);

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Crocker", 23, "bat");

        Doctor myDoctor = new Doctor("Bob", "Payne", 43, "Knife");

        Console.WriteLine(myPerson.GetPersonInformation());

        Console.WriteLine(myPoliceMan.GetPoliceManInformation());
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}