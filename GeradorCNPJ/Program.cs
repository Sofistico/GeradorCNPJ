using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNPJ
{
    class Program
    {
        private static Random rnd = new Random();

         static void Main(string[] args)
        {            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(GerarCNPJTeste());
            }
            Console.ReadKey();
        }

        public static string GerarCNPJTeste()
        {
            int[] numeros = new int[14];
            int dig1, dig2;

            string result = "";

            for (int i = 0; i <= 7; i++)
            {
                numeros[i] = rnd.Next(10);
            }
            numeros[8] = 0;
            numeros[9] = 0;
            numeros[10] = 0;
            numeros[11] = rnd.Next(10);

            int soma1 = (numeros[0] * 5) +
                (numeros[1] * 4) +
                (numeros[2] * 3) +
                (numeros[3] * 2) +
                (numeros[4] * 9) +
                (numeros[5] * 8) +
                (numeros[6] * 7) +
                (numeros[7] * 6) +
                (numeros[8] * 5) +
                (numeros[9] * 4) +
                (numeros[10] * 3) +
                (numeros[11] * 2);

            int div1 = soma1 / 11;
            int div2 = soma1 % 11;
            if (div2 < 2)
                dig1 = 0;
            else
                dig1 = 11 - div2;
            numeros[12] = dig1;

            int soma2 = (numeros[0] * 6) +
               (numeros[1] * 5) +
               (numeros[2] * 4) +
               (numeros[3] * 3) +
               (numeros[4] * 2) +
               (numeros[5] * 9) +
               (numeros[6] * 8) +
               (numeros[7] * 7) +
               (numeros[8] * 6) +
               (numeros[9] * 5) +
               (numeros[10] * 4) +
               (numeros[11] * 3) +
               (numeros[12] * 2);
            int div3 = soma2 / 11;
            int div4 = soma2 % 11;
            if (div4 < 2)
                dig2 = 0;
            else
                dig2 = 11 - div4;
            numeros[13] = dig2;

            foreach (int numero in numeros)
                result += Convert.ToString(numero);

            return result;
        }

    }
}
