using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 6: Kiem tra phan tu ton tai trong List<string>

class Bai6
{
    public static void Run()
    {
        List<string> danhSach = new List<string>();

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 6: Kiem tra phan tu ton tai");
        Console.WriteLine("========================");

        danhSach.Add("Nguyen Van A");
        danhSach.Add("Tran Thi B");
        danhSach.Add("Le Van C");
        danhSach.Add("Pham Thi D");
        danhSach.Add("Hoang Van E");

        Console.WriteLine("Danh sach sinh vien:");
        foreach (string ten in danhSach)
            Console.WriteLine("- " + ten);

        Console.Write("\nNhap ten can kiem tra: ");
        string tenKiemTra = Console.ReadLine();

        if (danhSach.Contains(tenKiemTra))
            Console.WriteLine($"'{tenKiemTra}' TON TAI trong danh sach!");
        else
            Console.WriteLine($"'{tenKiemTra}' KHONG TON TAI trong danh sach!");
    }
}