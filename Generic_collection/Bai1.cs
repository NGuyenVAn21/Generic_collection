using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02

class Bai1
{
    public static void Run()
    {
        List<int> danhSach = new List<int>();

        danhSach.Add(10);
        danhSach.Add(25);
        danhSach.Add(7);
        danhSach.Add(42);
        danhSach.Add(33);

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Danh sach cac so nguyen:");

        foreach (int so in danhSach)
        {
            Console.WriteLine(so);
        }
    }
}