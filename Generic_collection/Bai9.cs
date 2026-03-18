using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 9: Loai bo phan tu trung lap trong List<int>

class Bai9
{
    public static void Run()
    {
        List<int> danhSach = new List<int>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 9: Loai bo phan tu trung lap");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            int x = int.Parse(Console.ReadLine());
            danhSach.Add(x);
        }

        Console.WriteLine("Danh sach ban dau: " + string.Join(", ", danhSach));

        List<int> danhSachMoi = new List<int>();
        foreach (int so in danhSach)
        {
            if (!danhSachMoi.Contains(so))
                danhSachMoi.Add(so);
        }

        Console.WriteLine("Danh sach sau khi loai trung lap: " + string.Join(", ", danhSachMoi));
    }
}