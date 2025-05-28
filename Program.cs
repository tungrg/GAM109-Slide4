using Slide5;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //int[] a = { 1, 2, 3 };
        //foreach (int i in a)
        //{
        //    Console.WriteLine(i);
        //}
        //Array.ForEach(a, delegate(int x) { Console.WriteLine(x); });
        //Array.ForEach(a, value => { Console.WriteLine(value); });
        var listStudent = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "NguyenVanA",
                Grade = 7,
                
            },
            new Student()
            {
                Id = 2,
                Name = "NguyenVanB",
                Grade = 2,

            },
            new Student()
            {
                Id = 3,
                Name = "NguyenVanC",
                Grade = 8,

            },
        };
        
        listStudent.Sort((a, b) => b.Grade.CompareTo(a.Grade));
        listStudent.ForEach(student =>
        {
            Console.WriteLine($"Id: {student.Id}, Name : {student.Name}, Grade: {student.Grade}");
            if (student.Grade > 8)
            {
                Console.WriteLine("Gioi");
            }
            else if (student.Grade > 9)
            {
                Console.WriteLine("XuatSac");
            }
            else if (student.Grade < 5) {
                Console.WriteLine("Khong dat");
            }
        });
    }
}
