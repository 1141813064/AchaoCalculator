using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Random x = new Random();
            for (int i = 1; i < n; i++)
            {
                double a = x.Next(0, 100);
                double b = x.Next(0, 100);
                double c = x.Next(0, 100);
                double result = 0;
                int d = x.Next(1, 6);
                switch (d)
                {
                    case 1:
                        result = a * b + c;
                        if (result > 0)
                            Console.WriteLine(a + "*" + b + "+" + c + "=");
                        break;
                    case 2:
                        result = a + b + c;
                        if (result > 0)
                            Console.WriteLine(a + "+" + b + "+" + c + "=");
                        break;
                    case 3:
                        result = a / b - c;
                        if (result > 0)
                            Console.WriteLine(a + "/" + b + "-" + c + "=");
                        break;
                    case 4:
                        result = a + b - c;
                        if (result > 0)
                            Console.WriteLine(a + "+" + b + "-" + c + "=");
                        break;
                    case 5:
                        result = a + b * c;
                        if (result > 0)
                            Console.WriteLine(a + "+" + b + "*" + c + "=");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}