using System;

public class Person
{
    public string imya;
    public string familiya;
    public DateTime dataRozhdeniya;

    public Person(string imya, string familiya, DateTime dataRozhdeniya)
    {
        this.imya = imya;
        this.familiya = familiya;
        this.dataRozhdeniya = dataRozhdeniya;
    }

    public override bool Equals(object obj)
    {
        Person d = obj as Person;
        if (d == null) return false;
        return imya == d.imya &&
               familiya == d.familiya &&
               dataRozhdeniya == d.dataRozhdeniya;
    }

    public static bool operator ==(Person a, Person b)
    {
        if (ReferenceEquals(a, b)) return true;
        if ((object)a == null || (object)b == null) return false;
        return a.Equals(b);
    }

    public static bool operator !=(Person a, Person b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        int h1 = imya == null ? 0 : imya.GetHashCode();
        int h2 = familiya == null ? 0 : familiya.GetHashCode();
        int h3 = dataRozhdeniya.GetHashCode();
        return h1 ^ h2 ^ h3;
    }

    public Person DeepCopy()
    {
        return new Person(imya, familiya, dataRozhdeniya);
    }
}