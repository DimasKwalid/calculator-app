using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAK_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi";
            Console.Write("inputkan nilai a = ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("inputkan nilai b = ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("hASIL penambahan " + a + " + " + b + " = " + Penambahan(a, b));

            Console.WriteLine("hASIL pegurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            Console.WriteLine("hASIL perkalian " + a + " * " + b  + " = " + Perkalian(a, b));
            Console.WriteLine("hASIL pembagian " + a + " / " + b +  " = " + Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluyar");
                Console.ReadKey();
        }
        static float Penambahan(float a, float b)
        {
            return a + b;
        }

        static float Pengurangan(float a, float b)
        {
            return a - b;
        }

        static float Perkalian(float a, float b)
        {
            return a * b;
        }

        static float Pembagian(float a, float b)
        {
            return a / b;
        }

    }
}

