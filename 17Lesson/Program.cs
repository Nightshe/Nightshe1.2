using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _17Lesson
{
    public struct triugolnik
    {
        public int a;
        public int b;
        public int c;
        public double calc()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

    }
    internal class Program
    {
        static triugolnik bigest(triugolnik[] triugolniki)
        {
            triugolnik hitler = triugolniki[0];
            for (int i = 1; i < triugolniki.Length; i++)
            {
                if (triugolniki[i].calc() > hitler.calc())
                {
                    hitler = triugolniki[i];
                }
            }
            return hitler;
        }
        static void Main()
        {
            triugolnik[] triugolniki =
            {
                new triugolnik { a = 71, b = 22, c = 32 },
                new triugolnik { a = 43, b = 25, c = 35 },
                new triugolnik { a = 31, b = 25, c = 36 },
            };
            triugolnik hitler = bigest(triugolniki);

            Console.WriteLine("Трикутник з найбiльшою площею має сторони: " +
                        + hitler.a + ", " + hitler.b + ", " + hitler.c);
            Console.ReadKey();
        }
    }
}