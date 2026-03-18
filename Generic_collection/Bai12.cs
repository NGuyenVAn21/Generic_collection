using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 12: Tim sinh vien theo ten trong List<Student>

class Student12
{
    public int Id;
    public string Name;
}

class Bai12
{
    public static void Run()
    {
        List<Student12> danhSach = new List<Student12>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 12: Tim sinh vien theo ten");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong sinh vien: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student12 sv = new Student12();
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            Console.Write("ID: ");
            sv.Id = int.Parse(Console.ReadLine());
            Console.Write("Ten: ");
            sv.Name = Console.ReadLine();
            danhSach.Add(sv);
        }

        Console.Write("\nNhap ten can tim: ");
        string tenTim = Console.ReadLine();

        bool timThay = false;
        Console.WriteLine("\nKet qua tim kiem:");
        foreach (Student12 sv in danhSach)
        {
            if (sv.Name.ToLower().Contains(tenTim.ToLower()))
            {
                Console.WriteLine($"ID: {sv.Id} - Ten: {sv.Name}");
                timThay = true;
            }
        }

        if (!timThay)
            Console.WriteLine($"Khong tim thay sinh vien ten '{tenTim}'!");
    }
}