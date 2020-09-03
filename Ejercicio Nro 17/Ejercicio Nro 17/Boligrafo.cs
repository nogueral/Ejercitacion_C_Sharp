using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligrafoSpace
{
    class Boligrafo
    {
        const short CANTIDADTINTAMAXIMA = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            int estadoActual;
            dibujo = "";

            estadoActual = this.tinta;

            estadoActual -= gasto;

            if (estadoActual >= 0)
            {
                this.SetTinta((short)estadoActual);

                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }

                retorno = true;
            }


            return retorno;
        }

        public void Recargar()
        {
            this.SetTinta(100);
            Console.WriteLine("Recarga exitosa");
        }

        private void SetTinta(short tinta)
        {
            this.tinta = tinta;

            if(this.tinta < 0)
            {
                this.tinta = 0;

            } else if (this.tinta > CANTIDADTINTAMAXIMA)
            {
                this.tinta = CANTIDADTINTAMAXIMA;
            }

        }
    }
}
