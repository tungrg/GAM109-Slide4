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
        //var listStudent = new List<Student>()
        //{
        //    new Student()
        //    {
        //        Id = 1,
        //        Name = "NguyenVanA",
        //        Grade = 7,

        //    },
        //    new Student()
        //    {
        //        Id = 2,
        //        Name = "NguyenVanB",
        //        Grade = 2,

        //    },
        //    new Student()
        //    {
        //        Id = 3,
        //        Name = "NguyenVanC",
        //        Grade = 8,

        //    },
        //};

        //listStudent.Sort((a, b) => b.Grade.CompareTo(a.Grade));
        //listStudent.ForEach(student =>
        //{
        //    Console.WriteLine($"Id: {student.Id}, Name : {student.Name}, Grade: {student.Grade}");
        //    if (student.Grade > 8)
        //    {
        //        Console.WriteLine("Gioi");
        //    }
        //    else if (student.Grade > 9)
        //    {
        //        Console.WriteLine("XuatSac");
        //    }
        //    else if (student.Grade < 5) {
        //        Console.WriteLine("Khong dat");
        //    }
        //});

        //string[] name = { "CSGO", "PUPG", "Genshin", "Lien Minh" };
        //var res = new List<string>();

        //foreach (string s in name) 
        //{
        //    if (s.Contains('n'))
        //    {
        //        res.Add(s);
        //    }
        //}
        var listStudent = new List<Student>();
        listStudent.Add(new Student(1,"NguyenVanA",6.5f));
        listStudent.Add(new Student(2, "NguyenVanB", 7.5f));
        listStudent.Add(new Student(3, "NguyenVanC", 8.5f));
        listStudent.Add(new Student(4, "NguyenVanD", 9.5f));

        //VIet 1 cau truy van tim tat ca sinh vien co diem > 8
        var ketQua = from student in listStudent
                     where student.Grade > 8f
                     select student;
        foreach(Student student in ketQua)
        {
            Console.WriteLine($"Id: {student.Id}, Name : {student.Name}, Grade: {student.Grade}");
        }
    }
    
    

}
