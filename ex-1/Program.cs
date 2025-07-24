using System;

public class Program
{
    public static void Main(string[] args)
    {
        double tienGui = 1.0;
        int soThang = 1;
        double laiSuatNam = 1.0;

        Console.WriteLine("Nhap so tien gui (VD: 100000000):");
        tienGui = Double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap so thang gui:");
        soThang = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Nhap lai suat hang nam (phan tram, VD: 5.5):");
        laiSuatNam = Double.Parse(Console.ReadLine());

        double tongTienLai = 0;

        for (int i = 0; i < soThang; i++)
        {
            tongTienLai += tienGui * (laiSuatNam / 100) / 12;
        }

        Console.WriteLine("Tong tien lai nhan duoc: " + tongTienLai + " dong");
    }
}
