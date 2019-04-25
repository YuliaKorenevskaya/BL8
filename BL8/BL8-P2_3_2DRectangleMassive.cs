using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8
{
    class Program
    {
        public struct Square
        {
            public int side;            
        }
        static void Main(string[] args)
        {
            Square[] group = new Square[100];
            int[] mas = new int[100];
            Random r = new Random();
            int count = 1;
            int j = 0;

            for (int i = 0; i < 100; i++)
            { 
                group[i].side =  r.Next(1,11);
                mas[j] = group[i].side;              
                Console.Write($"{group[i].side} ");
                j++;
            }

            Console.WriteLine();

            for (int i = 0; i < 100; i++)
            {
                for (j = 0; j < 100; j++)
                {
                    if (group[i].side == mas[j])
                    {                     
                        count++;
                        mas[j] = 0;
                    }
                } 

                if (count > 1)
                {
                    Console.WriteLine($"Квадрат со стороной - {group[i].side}; повторов - {count} ");
                }
               
                count = 0;           
            }
       
            Console.ReadKey();
        }
    }
}
