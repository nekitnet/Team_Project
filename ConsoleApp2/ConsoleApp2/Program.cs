using System;
using System.Linq;

public class Person
{
    private string _name;
    private string _surname;
    private DateTime _dateOfBirth;

    public Person(string name, string surname, DateTime dateOfBirth)
    {
        _name = name;
        _surname = surname;
        _dateOfBirth = dateOfBirth;
    }

    public Person() : this("Default", "User", new DateTime(2000, 1, 1))
    {
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }

    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set { _dateOfBirth = value; }
    }

    public int YearOfBirth
    {
        get { return _dateOfBirth.Year; }
        set { _dateOfBirth = new DateTime(value, _dateOfBirth.Month, _dateOfBirth.Day); }
    }

    public override string ToString()
    {
        return "Name: " + _name + ", Surname: " + _surname + ", Date of Birth: " + _dateOfBirth.ToShortDateString();
    }

    public virtual string ToShortString()
    {
        return _name + " " + _surname;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число строк и число столбцов (nrow ncolumn), используя разделители: ',', ':', ';', ' '");
        
        string input = Console.ReadLine();
        
        char[] separators = { ',', ':', ';' , ' ' };
        string[] parts = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        int nrow = int.Parse(parts[0]);
        int ncolumn = int.Parse(parts[1]);
        int totalElements = nrow * ncolumn;

        // Инициализация одномерного массива
        Person[] vectorArray = new Person[totalElements];
        for (int i = 0; i < totalElements; i++)
        {
            vectorArray[i] = new Person();
        }

        // Инициализация двумерного прямоугольного массива
        Person[,] matrixArray = new Person[nrow, ncolumn];
        for (int i = 0; i < nrow; i++)
        {
            for (int j = 0; j < ncolumn; j++)
            {
                matrixArray[i, j] = new Person();
            }
        }

        // Инициализация двумерного ступенчатого массива
        Person[][] jaggedArray = new Person[nrow][];
        for (int i = 0; i < nrow; i++)
        {
            jaggedArray[i] = new Person[ncolumn];
            for (int j = 0; j < ncolumn; j++)
            {
                jaggedArray[i][j] = new Person();
            }
        }
        
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Сравнение времени для " + totalElements + " элементов (nrow=" + nrow + ", ncolumn=" + ncolumn + ")");

        // --- Измерение времени для одномерного массива ---
        int startTime = Environment.TickCount;
        for (int i = 0; i < totalElements; i++)
        {
            vectorArray[i].YearOfBirth = 2025;
        }
        int endTime = Environment.TickCount;
        Console.WriteLine("Время выполнения (Одномерный массив): " + (endTime - startTime) + " мс");

        // --- Измерение времени для двумерного прямоугольного массива ---
        startTime = Environment.TickCount;
        for (int i = 0; i < nrow; i++)
        {
            for (int j = 0; j < ncolumn; j++)
            {
                matrixArray[i, j].YearOfBirth = 2025;
            }
        }
        endTime = Environment.TickCount;
        Console.WriteLine("Время выполнения (Двумерный прямоугольный массив): " + (endTime - startTime) + " мс");

        // --- Измерение времени для двумерного ступенчатого массива ---
        startTime = Environment.TickCount;
        for (int i = 0; i < nrow; i++)
        {
            for (int j = 0; j < ncolumn; j++)
            {
                jaggedArray[i][j].YearOfBirth = 2025;
            }
        }
        endTime = Environment.TickCount;
        Console.WriteLine("Время выполнения (Двумерный ступенчатый массив): " + (endTime - startTime) + " мс");
    }
}