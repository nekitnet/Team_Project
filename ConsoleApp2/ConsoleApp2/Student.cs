using System;

public class Student
{
    private Person _info;
    private Education _edu;
    private int _group;
    private Exam[] _exams;

    public Student(Person info, Education edu, int group)
    {
        _info = info;
        _edu = edu;
        _group = group;
        _exams = new Exam[0];
    }
    public Student()
    {
        _info = new Person();
        _edu = Education.Bachelor;
        _group = 392;
        _exams = new Exam[0];
    }
    public Person Info
    {
        get { return _info; }
        set { _info = value; }
    }
    public Education Edu
    {
        get { return _edu; }
        set { _edu = value; }
    }
    public int Group
    {
        get { return _group; }
        set { _group = value; }
    }
    public Exam[] Exams
    {
        get { return _exams; }
        set { _exams = value; }
    }
}