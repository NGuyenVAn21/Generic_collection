using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 18: Quan ly diem sinh vien - Tim sinh vien diem cao nhat

class Student18
{
    public string Name;
    public double Score;
}

class Bai18
{
    public static void Run()
    {
        List<Student18> danhSach = new List<Student18>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 18: Quan ly diem sinh vien");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong sinh vien: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student18 sv = new Student18();
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            Console.Write("Ten: ");
            sv.Name = Console.ReadLine();
            Console.Write("Diem: ");
            sv.Score = double.Parse(Console.ReadLine());
            danhSach.Add(sv);
        }

        Console.WriteLine("\nDanh sach sinh vien:");
        foreach (Student18 sv in danhSach)
            Console.WriteLine($"Ten: {sv.Name} - Diem: {sv.Score}");

        Student18 svCaoDiem = danhSach[0];
        foreach (Student18 sv in danhSach)
        {
            if (sv.Score > svCaoDiem.Score)
                svCaoDiem = sv;
        }

        Console.WriteLine("========================");
        Console.WriteLine("Sinh vien co diem cao nhat:");
        Console.WriteLine($"Ten: {svCaoDiem.Name}");
        Console.WriteLine($"Diem: {svCaoDiem.Score}");
    }
}