using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 5: Xoa phan tu khoi List<string>

class Bai5
{
    public static void Run()
    {
        List<string> danhSach = new List<string>();

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 5: Xoa ten sinh vien khoi danh sach");
        Console.WriteLine("========================");

        // Them san mot so ten
        danhSach.Add("Nguyen Van A");
        danhSach.Add("Tran Thi B");
        danhSach.Add("Le Van C");
        danhSach.Add("Pham Thi D");
        danhSach.Add("Hoang Van E");

        Console.WriteLine("Danh sach sinh vien ban dau:");
        foreach (string ten in danhSach)
            Console.WriteLine("- " + ten);

        Console.Write("\nNhap ten can xoa: ");
        string tenXoa = Console.ReadLine();

        if (danhSach.Contains(tenXoa))
        {
            danhSach.Remove(tenXoa);
            Console.WriteLine($"Da xoa '{tenXoa}' khoi danh sach!");
        }
        else
        {
            Console.WriteLine($"Khong tim thay '{tenXoa}' trong danh sach!");
        }

        Console.WriteLine("\nDanh sach sau khi xoa:");
        foreach (string ten in danhSach)
            Console.WriteLine("- " + ten);
    }
}