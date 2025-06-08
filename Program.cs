using Slide5;
using System;
using System.Security.Cryptography.X509Certificates;

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
        listStudent.Add(new Student(1,"NguyenVanA",7.5f));
        listStudent.Add(new Student(99, "NguyenVanF", 0.5f));
        listStudent.Add(new Student(2, "NguyenVanB", 6.5f));
        listStudent.Add(new Student(3, "NguyenVanC", 0.5f));
        listStudent.Add(new Student(4, "NguyenVanD", 9.5f));
        listStudent.Add(new Student(5, "NguyenVanE", 9.5f));
        ////VIet 1 cau truy van tim tat ca sinh vien co diem > 8
        //var ketQua = from student in listStudent // Lay nguon du lieu
        //             where student.Grade > 8f // dieu kien
        //             select student; // khi gap dieu kien thi lam gi
        //foreach(Student student in ketQua)
        //{
        //    Console.WriteLine($"Id: {student.Id}, Name : {student.Name}, Grade: {student.Grade}");
        //}
        //var minGrade = listStudent.Sum(x => x.Grade);
        ////foreach (var student in minGrade)
        ////{
        ////    Console.WriteLine($"Id: {student.Id}, Name : {student.Name}, Grade: {student.Grade}");
        ////}
        //Console.WriteLine(minGrade);
        //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //var result = a.TakeWhile(x => x < 5);
        //result.ToList().ForEach(x => Console.WriteLine(x));
        //var lookUpStudent = listStudent.ToLookup(x =>x.Id);
        //foreach(var student in lookUpStudent)
        //{
        //    Console.WriteLine(student.Key);
        //    foreach(var info in student)
        //    {
        //        Console.WriteLine($"Name: {info.Name}, Grade: {info.Grade}");
        //    }
        //}
        //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        //try
        //{
        //    var b = a.Cast<float>();
        //    foreach (var item in b)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Khong ep kieu duoc");
        //}
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        var b = a.AsEnumerable();
        foreach(var x in b)
        {
            Console.WriteLine(x);
        }

    }
    
    

}
