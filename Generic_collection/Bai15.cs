using System;
using System.Collections.Generic;

// Ho ten: Nguyen Dinh Van
// MSSV: 23115053122248
// Lop: 225LTC02
// Bai 15: Su dung Dictionary<string, string> luu tu dien Anh - Viet

class Bai15
{
    public static void Run()
    {
        Dictionary<string, string> tuDien = new Dictionary<string, string>();

        Console.WriteLine("Ho ten: Nguyen Dinh Van");
        Console.WriteLine("MSSV: 23115053122248");
        Console.WriteLine("Lop: 225LTC02");
        Console.WriteLine("========================");
        Console.WriteLine("Bai 15: Tu dien Anh - Viet");
        Console.WriteLine("========================");

        // Them san mot so tu
        tuDien.Add("hello", "xin chao");
        tuDien.Add("goodbye", "tam biet");
        tuDien.Add("book", "quyen sach");
        tuDien.Add("computer", "may tinh");
        tuDien.Add("student", "sinh vien");
        tuDien.Add("teacher", "giao vien");
        tuDien.Add("school", "truong hoc");
        tuDien.Add("water", "nuoc");
        tuDien.Add("food", "thuc an");
        tuDien.Add("house", "nha");

        Console.WriteLine("Danh sach tu trong tu dien:");
        foreach (var cap in tuDien)
            Console.WriteLine($"{cap.Key} = {cap.Value}");

        Console.WriteLine("========================");
        Console.Write("Nhap tu tieng Anh can tra: ");
        string tuNhap = Console.ReadLine().ToLower();

        if (tuDien.ContainsKey(tuNhap))
            Console.WriteLine($"Nghia: {tuDien[tuNhap]}");
        else
            Console.WriteLine($"Khong tim thay tu '{tuNhap}' trong tu dien!");
    }
}