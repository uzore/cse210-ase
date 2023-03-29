using System;


public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetInformalSignature()
    {
            return "Thanks, " + _firstName;
    }

    public string GetFormalSignature()
    {
            return "Sincerely, " + GetFullName();
    }

    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }
}
