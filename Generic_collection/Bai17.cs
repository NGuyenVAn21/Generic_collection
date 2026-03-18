using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 17: Tim phan tu xuat hien nhieu nhat trong List<int>

class Bai17
{
    public static void Run()
    {
        List<int> danhSach = new List<int>();
        int n;

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 17: Tim phan tu xuat hien nhieu nhat");
        Console.WriteLine("========================");

        Console.Write("Nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            int x = int.Parse(Console.ReadLine());
            danhSach.Add(x);
        }

        Console.WriteLine("Danh sach: " + string.Join(", ", danhSach));

        Dictionary<int, int> demSoLan = new Dictionary<int, int>();
        foreach (int so in danhSach)
        {
            if (demSoLan.ContainsKey(so))
                demSoLan[so]++;
            else
                demSoLan[so] = 1;
        }

        int soNhieuNhat = 0;
        int soLanMax = 0;
        foreach (var cap in demSoLan)
        {
            if (cap.Value > soLanMax)
            {
                soLanMax = cap.Value;
                soNhieuNhat = cap.Key;
            }
        }

        Console.WriteLine($"So xuat hien nhieu nhat: {soNhieuNhat}");
        Console.WriteLine($"So lan xuat hien: {soLanMax}");
    }
}