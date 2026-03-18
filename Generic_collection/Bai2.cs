using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 2: Tinh tong cac phan tu trong List<int>

class Bai2
{
    public static void Run()
    {
        List<int> danhSach = new List<int>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 2: Tinh tong cac phan tu");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            int x = int.Parse(Console.ReadLine());
            danhSach.Add(x);
        }

        int tong = 0;
        foreach (int so in danhSach)
            tong += so;

        Console.WriteLine($"Tong cac phan tu: {tong}");
    }
}