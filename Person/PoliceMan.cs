class PoliceMan : Person
{
    private string _weapons;
    private double _hourlyWage;
    private double _hoursWorked;
    public PoliceMan(string firstName, string lastName, int age, string weapons, double hourlyWage, double hoursWorked)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hourlyWage = hourlyWage;
        _hoursWorked = hoursWorked;
    }
    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }
    public override string GetPersonInformation()
    {
        return $"I am a Policeman: {_weapons} :: {base.GetPersonInformation()}";
    }
    public override double GetPay()
    {
        double pay = _hourlyWage * _hoursWorked;
        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }
        return pay;
    }
}