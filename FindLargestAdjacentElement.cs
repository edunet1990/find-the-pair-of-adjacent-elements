using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputArray = new int[6] { 5, 1, 2, 3, 1, 4 };

            Program p = new Program();

            Console.Write("Valor " + p.adjacentElementsProduct(inputArray));
            Console.ReadKey();
        }

        int adjacentElementsProduct(int[] inputArray)
        {
            
            List<int> result = new List<int>();
            int guardaValorNaLista = 0;
            int countResults = 0;

            //capturar o resultado da multiplicação dos adjacentes
            for (int i = 0; i < inputArray.Length- 1; i++)
            {
                
                guardaValorNaLista = inputArray[i] * inputArray[i+1];
                result.Add(guardaValorNaLista);
                countResults++;

            }
            int max = result[0];
            // verificar todos os resultados
            for (int i = 0; i < countResults; i++)
            {
                    if (result[i] > max)
                    {
                        max = result[i];
                    }
            }
            return max;
        }
    }
}
