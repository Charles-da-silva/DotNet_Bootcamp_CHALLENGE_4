using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                int N = int.Parse(Console.ReadLine());
                int totalEsferas = 0;
                int totalSobras = 0;
                
                while (N != 0)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        int sobra = 0;
                        int quotient = Math.DivRem(N, j, out sobra);

                        if(sobra == 0)
                        {
                            totalSobras++;
                        }
                    }
                
                    if(totalSobras % 2 == 0)
                    {
                        totalEsferas++;                        
                    }

                N--;
                totalSobras = 0; 

                }

                System.Console.WriteLine(totalEsferas);        
            
            }
        }
    }
}