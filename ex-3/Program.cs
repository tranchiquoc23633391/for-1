﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Danh sach cac so nguyen to nho hon 100:");

        for (int i = 2; i < 100; i++)
        {
            int dem = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    dem++;
                }
            }

            if (dem == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
