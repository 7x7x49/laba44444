using System;


struct Student
{
    public string name; 
    public string group; 
    public int[] grades;

    public double GetAverageValue()
    {
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return sum/grades.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[7];

        students[0] = new Student { name = "Carrey Jim", group = "20it2000", grades = new int[5]};
        students[1] = new Student { name = "Dantes Admon", group = "20it4090", grades = new int[5]};
        students[2] = new Student { name = "Ford Harrison", group = "20it1800", grades = new int[5]};
        students[3] = new Student { name = "Celentano Adriano", group = "20it9001", grades = new int[5]};
        students[4] = new Student { name = "Darcy Fitzwilliam", group = "20it50000000", grades = new int[5]};
        students[5] = new Student { name = "Cumberbatch Benedict Timothy Carlton", group = "20it01010101", grades = new int[5]};
        students[6] = new Student { name = "McAvoy James", group = "20it92", grades = new int[5]};
        for (int y = 0; y < 7; y++)
        {
            students[y].grades = randomgGrades();
        }




        Array.Sort(students, (a, b) => a.GetAverageValue().CompareTo(b.GetAverageValue()));
        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.name}, Group: {student.group}, Average grades: {student.GetAverageValue()}, {strValOfArr(student.grades)}");
        }
    }
    public static string strValOfArr(int[] a)
    {
        string grades = "Grades: ";
        grades += String.Join(" ", a);
        return grades;
    }
    public static int[] randomgGrades()
    {
        Random rand = new Random();
        int[] grades = new int[5];
        for (int i = 0; i < 5; i++)
        {
            grades[i] = rand.Next(2, 6);
        }
        return grades;
    }
}
