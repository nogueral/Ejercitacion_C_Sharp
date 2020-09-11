using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public static class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string resultado = "";

            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        resultado = "0" + resultado;

                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }

                    numero = numero / 2;

                }
            }
            else
            {
                resultado = "Valor invalido";
            }

            return resultado;
        }

        public static int BinarioDecimal(string binario)
        {
            double acumulador = 0;
            char[] array = binario.ToCharArray();
            Array.Reverse(array);

            if (EsBinario(binario))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        acumulador += Math.Pow(2, i);
                    }

                }

            }


            return (int)acumulador;
        }

        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            char[] array = binario.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != '0' && array[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }
    }
}
