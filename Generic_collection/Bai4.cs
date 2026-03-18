using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 4: Dem so chan trong List<int>

class Bai4
{
    public static void Run()
    {
        List<int> danhSach = new List<int>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 4: Dem so chan trong danh sach");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            int x = int.Parse(Console.ReadLine());
            danhSach.Add(x);
        }

        int demChan = 0;
        foreach (int so in danhSach)
        {
            if (so % 2 == 0)
                demChan++;
        }

        Console.WriteLine("Danh sach: " + string.Join(", ", danhSach));
        Console.WriteLine($"So luong so chan: {demChan}");
    }
}