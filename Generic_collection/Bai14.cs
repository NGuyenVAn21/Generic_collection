using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 14: Xoa sinh vien theo ID trong List<Student>

class Student14
{
    public int Id;
    public string Name;
}

class Bai14
{
    public static void Run()
    {
        List<Student14> danhSach = new List<Student14>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 14: Xoa sinh vien theo ID");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong sinh vien: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student14 sv = new Student14();
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            Console.Write("ID: ");
            sv.Id = int.Parse(Console.ReadLine());
            Console.Write("Ten: ");
            sv.Name = Console.ReadLine();
            danhSach.Add(sv);
        }

        Console.WriteLine("\nDanh sach sinh vien hien tai:");
        foreach (Student14 sv in danhSach)
            Console.WriteLine($"ID: {sv.Id} - Ten: {sv.Name}");

        Console.Write("\nNhap ID can xoa: ");
        int idXoa = int.Parse(Console.ReadLine());

        Student14 svXoa = null;
        foreach (Student14 sv in danhSach)
        {
            if (sv.Id == idXoa)
            {
                svXoa = sv;
                break;
            }
        }

        if (svXoa != null)
        {
            danhSach.Remove(svXoa);
            Console.WriteLine($"Da xoa sinh vien co ID = {idXoa}!");
        }
        else
        {
            Console.WriteLine($"Khong tim thay sinh vien co ID = {idXoa}!");
        }

        Console.WriteLine("\nDanh sach sau khi xoa:");
        foreach (Student14 sv in danhSach)
            Console.WriteLine($"ID: {sv.Id} - Ten: {sv.Name}");
    }
}