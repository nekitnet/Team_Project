using System;

    /*{
        Student st = new Student(
            new Person("Иван", "Иванов", new DateTime(2000, 5, 20)),
            Education.Bachelor,
            101
        );

        Console.WriteLine(st.ToString());

        Console.WriteLine(st[Education.Specialist]);
        Console.WriteLine(st[Education.Bachelor]);
        Console.WriteLine(st[Education.SecondEducation]);

        st.DobavitEkzameny(
            new Exam("Математика", 5, DateTime.Now),
            new Exam("Физика", 4, DateTime.Now),
            new Exam("Программирование", 5, DateTime.Now)
        );

        Console.WriteLine(st.ToString());

        Console.WriteLine("Введите количество строк и столбцов (разделители: пробел, запятая, точка с запятой):");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ', ',', ';');
        int nrow = int.Parse(parts[0]);
        int ncol = int.Parse(parts[1]);
        int total = nrow * ncol;

        Exam[] arr1 = new Exam[total];
        Exam[,] arr2 = new Exam[nrow, ncol];
        Exam[][] arr3 = new Exam[nrow][];
        for (int i = 0; i < nrow; i++) arr3[i] = new Exam[ncol];

        for (int i = 0; i < total; i++) arr1[i] = new Exam();
        for (int i = 0; i < nrow; i++)
            for (int j = 0; j < ncol; j++)
            {
                arr2[i, j] = new Exam();
                arr3[i][j] = new Exam();
            }

        int t1Start = Environment.TickCount;
        for (int i = 0; i < total; i++) arr1[i].otsenka = 5;
        int t1End = Environment.TickCount;

        int t2Start = Environment.TickCount;
        for (int i = 0; i < nrow; i++)
            for (int j = 0; j < ncol; j++)
                arr2[i, j].otsenka = 5;
        int t2End = Environment.TickCount;

        int t3Start = Environment.TickCount;
        for (int i = 0; i < nrow; i++)
            for (int j = 0; j < ncol; j++)
                arr3[i][j].otsenka = 5;
        int t3End = Environment.TickCount;

        Console.WriteLine($"Количество строк: {nrow}, количество столбцов: {ncol}");
        Console.WriteLine($"Одномерный массив: {t1End - t1Start} мс");
        Console.WriteLine($"Двумерный прямоугольный массив: {t2End - t2Start} мс");
        Console.WriteLine($"Ступенчатый массив: {t3End - t3Start} мс");
    }
}*/
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Екатерина", "Иванова", new DateTime(1998, 5, 12));
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p1.ToShortString());
            Console.WriteLine(p2.ToShortString());
            
            Person  p3 = new Person("Анна","Сидорова",new DateTime(2000,3,15));
            Console.WriteLine(p3.ToString());
            p3.DataRozhdeniya=new  DateTime(1999,3,15);
            Console.WriteLine(p3.ToString());
            
            Exam ex1 = new Exam("ООП", 9, new DateTime(2025, 1, 20));
            Console.WriteLine(ex1.ToString());
            ex1.predmet = "Информационная безопасность";
            ex1.otsenka = 10;
            ex1.data = new DateTime(2025, 1, 25);
            Console.WriteLine(ex1.ToString());
            
            Student st1=new Student(new Person("Екатерина","Смирнова",new DateTime(2001,10,05)),Education.Specialist,101);
            Console.WriteLine(st1.ToShortString());
            st1.FormaObucheniya = Education.Bachelor;
            st1.Gruppa = 202;
            Console.WriteLine(st1.ToShortString());
            Student st2=new Student(new Person("Иван","Петров",new DateTime(2002,6,10)), Education.Bachelor,202);
            Console.WriteLine (st2[Education.Specialist]);
            Console.WriteLine (st2[Education.Bachelor]);
            Console.WriteLine (st2[Education.SecondEducation]);
            Student st3 = new Student(new Person("Мария","Кузнецова",new DateTime(2000,03,14)),Education.Bachelor,305);
            st3.FormaObucheniya=Education.Specialist;


            Console.WriteLine("-------------------------------");
            Student[] students=new Student[]
            {
                st1 =new Student(new Person("Екатерина","Смирнова",new DateTime(2001,10,05)),Education.Specialist,101),
                st2 =new Student(new Person("Иван","Петров",new DateTime(2002,6,10)), Education.Bachelor,202),
                st3 =new Student(new Person("Мария","Кузнецова",new DateTime(2000,03,14)),Education.Bachelor,305),
            };
            int g = 305;
            foreach (Student s in students)
            {
                if (s.Gruppa==g)
                {
                    Console.WriteLine(s.ToString());
                }
            }
            
                
                
            st3.DobavitEkzameny(new Exam("Базы данных",7, new DateTime(2025,2,10)),new Exam("Сети",8,new DateTime(2025,2,12)) );
            Console.WriteLine(st3.ToShortString());
        }
    }

