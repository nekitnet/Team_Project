using System;

public class Exam
{
    public string Subj { get; set; }
    public int Mark { get; set; }
    public DateTime Date { get; set; }

    public Exam(string subj, int mark, DateTime date)
    {
        Subj = subj;
        Mark = mark;
        Date = date;
    }

    public Exam() : this("Test2", 5, new DateTime(2025, 11, 30))
    {
    }

    public override string ToString()
    {
        return Subj + " " + Mark + " " + Date.ToShortDateString();
    }
}