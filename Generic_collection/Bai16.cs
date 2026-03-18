using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 16: Dem so lan xuat hien cua moi ky tu trong chuoi

class Bai16
{
    public static void Run()
    {
        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 16: Dem so lan xuat hien ky tu");
        Console.WriteLine("========================");

        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();

        Dictionary<char, int> demKyTu = new Dictionary<char, int>();

        foreach (char c in chuoi)
        {
            if (demKyTu.ContainsKey(c))
                demKyTu[c]++;
            else
                demKyTu[c] = 1;
        }

        Console.WriteLine("\nSo lan xuat hien cua moi ky tu:");
        foreach (var cap in demKyTu)
            Console.WriteLine($"{cap.Key} : {cap.Value}");
    }
}