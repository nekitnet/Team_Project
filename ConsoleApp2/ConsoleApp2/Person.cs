using System;

public class Person
{
    private string imya;
    private string familiya;
    private DateTime dataRozhdeniya;

    public Person(string i, string f, DateTime d)
    {
        imya = i;
        familiya = f;
        dataRozhdeniya = d;
    }

    public Person()
    {
        imya = "Imya";
        familiya = "Familiya";
        dataRozhdeniya = new DateTime(2000, 1, 1);
    }

    public string Imya { get => imya; set => imya = value; }
    public string Familiya { get => familiya; set => familiya = value; }
    public DateTime DataRozhdeniya { get => dataRozhdeniya; set => dataRozhdeniya = value; }

    public override string ToString()
    {
        return $"{imya} {familiya}, {dataRozhdeniya.ToShortDateString()}";
    }
    
    public string ToShortString()
    {
        return $"{Imya} {Familiya}";
    }
}