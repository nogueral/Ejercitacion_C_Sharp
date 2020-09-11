using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_22
{
    class NumeroBinario
    {
        string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get { return this.numero; }
        }

        public static string operator +(NumeroBinario bin, NumeroDecimal dec)
        {
            int auxNumero = Conversor.BinarioDecimal(bin.numero);

            auxNumero = auxNumero + (int)dec.GetNumero();

            return Conversor.DecimalBinario(auxNumero);
        }

        public static string operator -(NumeroBinario bin, NumeroDecimal dec)
        {
            int auxNumero = Conversor.BinarioDecimal(bin.numero);

            auxNumero = auxNumero - (int)dec.GetNumero();

            return Conversor.DecimalBinario(auxNumero);
        }

        public static bool operator ==(NumeroBinario bin, NumeroDecimal dec)
        {
            bool retorno = false;

            int auxNumero = Conversor.BinarioDecimal(bin.numero);

            if (auxNumero == dec.GetNumero())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(NumeroBinario bin, NumeroDecimal dec)
        {
            return !(bin == dec);
        }

        public static explicit operator NumeroDecimal(NumeroBinario bin)
        {
            return new NumeroDecimal(Conversor.BinarioDecimal(bin.numero));
        }
    }
}
