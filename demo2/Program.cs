using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    internal class Program
    {
        //bai1:
        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap so nguyen: ");
        //    int x = int.Parse(Console.ReadLine());
        //    int z = x % 3;
        //    if ( x % 3 == 0)
        //    {                
        //        Console.WriteLine("Ket qua: " + z );
        //    }

        //}

        //bai2:
        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap so nguyen: ");
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine("" );
        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 1; j <= n; j++)
        //        {
        //            Console.WriteLine(i + " * " + j + " = " + i * j);
        //        }
        //        Console.WriteLine(" ");

        //    }
        //}

        //bai3;
        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap so nguyen: ");
        //    int n = int.Parse(Console.ReadLine());
        //    long tGiaiThua = 0;
        //    long giaiThua = 1;            
        //    for (int i = 1; i <= n; i++)
        //    {
        //        giaiThua *= i;
        //        tGiaiThua += giaiThua;
        //    }

        //    Console.WriteLine(n + " = " + tGiaiThua );

        //}

        //bai4
        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap so nguyen: ");
        //    int n = int.Parse(Console.ReadLine());

        //    int x = (int)Math.Sqrt(n);

        //    if (x * x == n)
        //    {
        //        Console.WriteLine("la so chinh phuong " + n);
        //    }
        //    else
        //    {
        //        Console.WriteLine("khong phai la so chinh phuong " + n);
        //    }

        //}

        //bai5:

        // static void Main(string[] asgn)
        //{
        //    Console.Write("Nhap thang: ");
        //    int n = int.Parse(Console.ReadLine());
        //    int x = 0;

        //    if(n % 2 == 0)
        //    {
        //        x = 30;
        //        if( n == 2)
        //        {
        //            x = 29;
        //        }
        //        Console.WriteLine(x + " ngay ");
        //    }
        //    else
        //    {
        //        x = 31;
        //        Console.WriteLine(x + " ngay ");

        //    }
        //}

        //bai6:

        //static void Main(string[] asgn)
        // {
        //Console.Write("Nhap so nguyen: ");
        //int n = int.Parse(Console.ReadLine());

        //    int S = 0;
        //    for( int i = 0; i <= n; i++)
        //    {
        //        S += i * i;
        //    }
        //    Console.WriteLine(" Tong S la : " + S);
        //}

        //bai7:

        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap so nguyen: ");
        //    int n = int.Parse(Console.ReadLine());
        //    int x = 0;

        //    for(int i = 1; i <= n; i++)
        //    {
        //        if(i % 2 != 0)
        //        {
        //            x += i;
        //        }
        //    }
        //    Console.WriteLine(" Tong la: " + x);

        //}

        //bai8:

        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap so nguyen: ");
        //    int n = int.Parse(Console.ReadLine());
        //    //int x = 0;
        //    //int z = 0;
        //    for (int i = 2; i <= n; i++)
        //    {
        //        bool isPrime = true;
        //        for (int j = 2; j * j <= i; j++)
        //        {
        //            if (i % j == 0)
        //            {
        //                isPrime = false;
        //                break;
        //            }
        //        }
        //        if (isPrime)
        //        {
        //            Console.Write("{0} ", i);
        //        }
        //    }
        //}

        //bai 9:

        //static void Main(string[] args)
        //{
        //    Console.Write("nhap so: ");
        //    int n = int.Parse(Console.ReadLine());            

        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 1; j <= n; j++)
        //        {
        //            Console.Write("");
        //        }                
        //        for (int k = 1; k <=  i - 1; k++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //bai10:

        //static void Main(string[] arges)
        //{
        //    Console.Write(" nhap so: ");
        //    int n = int.Parse(Console.ReadLine());
        //    int x = 0;
        //    int z = 1;

        //    for(int i = 0; i < n; i++)
        //    {
        //        Console.Write(x + " ");
        //        int y = x + z;
        //        x = z;
        //        z = y;


        //    }
        //}
    }
        
}
