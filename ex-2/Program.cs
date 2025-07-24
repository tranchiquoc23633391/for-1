using System;

public class Program
{
    public static void Main(string[] args)
    {
        int luaChon = -1;

        while (luaChon != 0)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. In hinh chu nhat");
            Console.WriteLine("2. In hinh tam giac vuong (4 goc)");
            Console.WriteLine("3. In hinh tam giac can");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");
            luaChon = Int32.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    InHinhChuNhat();
                    break;
                case 2:
                    InTamGiacVuong();
                    break;
                case 3:
                    InTamGiacCan();
                    break;
                case 0:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }

    public static void InHinhChuNhat()
    {
        Console.WriteLine("Nhap chieu dai:");
        int dai = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong:");
        int rong = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < dai; i++)
        {
            for (int j = 0; j < rong; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    public static void InTamGiacVuong()
    {
        Console.WriteLine("Tam giac vuong goc o dau?");
        Console.WriteLine("1. Goc duoi trai");
        Console.WriteLine("2. Goc tren trai");
        Console.WriteLine("3. Goc duoi phai");
        Console.WriteLine("4. Goc tren phai");
        Console.Write("Nhap lua chon (1-4): ");
        int goc = Int32.Parse(Console.ReadLine());

        Console.Write("Nhap chieu cao tam giac: ");
        int h = Int32.Parse(Console.ReadLine());

        switch (goc)
        {
            case 1: // goc duoi trai
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                break;
            case 2: // goc tren trai
                for (int i = h; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                break;
            case 3: // goc duoi phai
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= h - i; j++)
                        Console.Write("  ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                break;
            case 4: // goc tren phai
                for (int i = h; i >= 1; i--)
                {
                    for (int j = 1; j <= h - i; j++)
                        Console.Write("  ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                break;
        }
    }

    public static void InTamGiacCan()
    {
        Console.Write("Nhap chieu cao tam giac: ");
        int h = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= h; i++)
        {
            for (int j = 1; j <= h - i; j++)
                Console.Write("  "); // in khoang trong
            for (int j = 1; j <= 2 * i - 1; j++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }
}
