using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_params_ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int u = 666;
            string h = "";
            t1(out h, out u); // при вызове указывать out, ref
                       
            Console.WriteLine(u);
            t2(ref u);
            Console.WriteLine(u);

            t3(1, 4, 3, 5, 2);
            t3(4, 6, 8, 9, 1);

        }

        static void t1 (out string mess, out int num)//отдадим стринг
        {
            mess = "";
            num = 8;        
        }

        static void t2(ref int num)//принимаем ссылку? меняем оригинал
        {
            num = 5;
        }
        static void t3(params int[] p) //принимает неограниченное кол-во параметров
        {
            Console.WriteLine(p.Length);
            for (int i=0;i<p.Length;i++)
            {
                Console.WriteLine(p[i]);
            }
        }
    }
}
