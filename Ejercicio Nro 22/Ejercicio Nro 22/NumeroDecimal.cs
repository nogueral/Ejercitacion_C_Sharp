using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_22
{
    class NumeroDecimal
    {
        double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumero()
        {
            return this.numero;
        }

        public static double operator +(NumeroDecimal dec, NumeroBinario bin)
        {
            int auxNumero = Conversor.BinarioDecimal(bin.Numero);

            return dec.numero + auxNumero;
        }

        public static double operator -(NumeroDecimal dec, NumeroBinario bin)
        {
            int auxNumero = Conversor.BinarioDecimal(bin.Numero);

            return dec.numero - auxNumero;
        }

        public static bool operator ==(NumeroDecimal dec, NumeroBinario bin)
        {
            bool retorno = false;
            int auxNumero = Conversor.BinarioDecimal(bin.Numero);

            if (dec.numero == auxNumero)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(NumeroDecimal dec, NumeroBinario bin)
        {
            return !(dec == bin);
        }

        public static explicit operator NumeroBinario(NumeroDecimal dec)
        {
            return new NumeroBinario(Conversor.DecimalBinario((int)dec.GetNumero()));
        }
    }
}
