using System;

public class Exam
{
    public string predmet { get; set; }
    public int otsenka { get; set; }
    public DateTime data { get; set; }

    public Exam(string p, int o, DateTime d)
    {
        predmet = p;
        otsenka = o;
        data = d;
    }

    public Exam()
    {
        predmet = "Predmet";
        otsenka = 0;
        data = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{predmet}, {otsenka}, {data.ToShortDateString()}";
    }
}