using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_na_4_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            Console.WriteLine("введите число до которого будут искаться простые число( то есть начало диапозона 0, а это число его конец) : ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int c = 1; c < b; ++c)
            {
                for (int i = 2; i <= (int)(c / 2); ++i)
                {
                    if (c % i != 0) a = true;
                    else { a = false; break; }
                }
                if (a == true) Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
