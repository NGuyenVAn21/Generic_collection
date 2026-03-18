using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 13: Dem tong so sinh vien trong List<Student>

class Student13
{
    public int Id;
    public string Name;
}

class Bai13
{
    public static void Run()
    {
        List<Student13> danhSach = new List<Student13>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 13: Dem tong so sinh vien");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong sinh vien: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student13 sv = new Student13();
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            Console.Write("ID: ");
            sv.Id = int.Parse(Console.ReadLine());
            Console.Write("Ten: ");
            sv.Name = Console.ReadLine();
            danhSach.Add(sv);
        }

        Console.WriteLine("\nDanh sach sinh vien:");
        foreach (Student13 sv in danhSach)
            Console.WriteLine($"ID: {sv.Id} - Ten: {sv.Name}");

        Console.WriteLine("========================");
        Console.WriteLine($"Tong so sinh vien: {danhSach.Count}");
    }
}