using System;
using System.Text;

public class Student
{
    private Person dannye;
    private Education formaObucheniya;
    private int gruppa;
    private Exam[] ekzameny;

    public Student(Person d, Education f, int g)
    {
        dannye = d;
        formaObucheniya = f;
        gruppa = g;
        ekzameny = new Exam[0];
    }

    public Student()
    {
        dannye = new Person();
        formaObucheniya = Education.Bachelor;
        gruppa = 0;
        ekzameny = new Exam[0];
    }

    public Person Dannye { get => dannye; set => dannye = value; }
    public Education FormaObucheniya { get => formaObucheniya; set => formaObucheniya = value; }
    public int Gruppa { get => gruppa; set => gruppa = value; }
    public Exam[] Ekzameny { get => ekzameny; set => ekzameny = value; }

    public void DobavitEkzameny(params Exam[] novye)
    {
        int oldLen = ekzameny.Length;
        Array.Resize(ref ekzameny, oldLen + novye.Length);
        for (int i = 0; i < novye.Length; i++)
            ekzameny[oldLen + i] = novye[i];
    }

    public bool this[Education form]
    {
        get { return formaObucheniya == form; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(dannye.ToString());
        sb.AppendLine($"Форма обучения: {formaObucheniya}, группа: {gruppa}");
        foreach (var ex in ekzameny) sb.AppendLine(ex.ToString());
        return sb.ToString();
    }
    public string ToShortString()
    {
        return $"{Dannye.ToShortString()}, форма: {FormaObucheniya}, группа: {Gruppa}";
    }
}