using System;

public class Person
{
    public string Name { get; set; }
    public string Last { get; set; }
    public DateTime Birth { get; set; }
    public Person(string name, string last, DateTime birth)
    {
        Name = name;
        Last = last;
        Birth = birth;
    }
    public Person() : this("Nikita", "Arseniy", new DateTime(2007, 08, 29))
    {
    }
    public override string ToString()
    {
        return Name + " " + Last + " " + Birth.ToShortDateString();
    }
}