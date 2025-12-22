using System;
using System.Collections;

public class Group
{
    public string nazvanie;
    public ArrayList spisok;

    public Group(string nazvanie)
    {
        this.nazvanie = nazvanie;
        spisok = new ArrayList();
    }

    public override bool Equals(object obj)
    {
        Group g = obj as Group;
        if (g == null) return false;
        if (nazvanie != g.nazvanie) return false;
        if (spisok.Count != g.spisok.Count) return false;

        for (int i = 0; i < spisok.Count; i++)
            if (!spisok[i].Equals(g.spisok[i])) return false;

        return true;
    }

    public override int GetHashCode()
    {
        int h = nazvanie == null ? 0 : nazvanie.GetHashCode();
        foreach (object el in spisok)
            h ^= el.GetHashCode();
        return h;
    }

    public static bool operator ==(Group a, Group b)
    {
        if (ReferenceEquals(a, b)) return true;
        if ((object)a == null || (object)b == null) return false;
        return a.Equals(b);
    }

    public static bool operator !=(Group a, Group b)
    {
        return !(a == b);
    }

    public Group DeepCopy()
    {
        Group k = new Group(nazvanie);
        foreach (object el in spisok)
        {
            if (el is Person p)
                k.spisok.Add(p.DeepCopy());
            else
                k.spisok.Add(el);
        }
        return k;
    }
}