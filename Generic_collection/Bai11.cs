using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 11: Luu danh sach sinh vien trong List<Student>

class Student
{
    public int Id;
    public string Name;
}

class Bai11
{
    public static void Run()
    {
        List<Student> danhSach = new List<Student>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 11: Quan ly danh sach sinh vien");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong sinh vien: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student sv = new Student();
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            Console.Write("ID: ");
            sv.Id = int.Parse(Console.ReadLine());
            Console.Write("Ten: ");
            sv.Name = Console.ReadLine();
            danhSach.Add(sv);
        }

        Console.WriteLine("\n========================");
        Console.WriteLine("Danh sach sinh vien:");
        Console.WriteLine("========================");
        foreach (Student sv in danhSach)
        {
            Console.WriteLine($"ID: {sv.Id} - Ten: {sv.Name}");
        }
    }
}