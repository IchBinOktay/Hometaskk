
using Task7;

public static class Program
{
    public static void Main()
    {
        User newUser = new User("Oktay", "Babayev", "ASDF123", RegistrationMonth.August);
        newUser.GetDetails();
        User newUser2 = new User("Fazil", "Babayev", "234QWE", RegistrationMonth.April);
        newUser2.GetDetails();
        User newUser3 = new User("ayhan", "Babayev", "RFD421", RegistrationMonth.November);
        newUser3.GetDetails();
        User newUser4 = new User("akif", "Babayev", "ABC987m", RegistrationMonth.October);
        newUser4.GetDetails();
        User newUser5 = new User("mehdi", "Babayev", "DRS2670", RegistrationMonth.May);
        newUser5.GetDetails();
    }
}