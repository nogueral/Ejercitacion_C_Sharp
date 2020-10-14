using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Barco
    {
        public static int XMax;
        public static int YMax;
        static Random auxRandom;

        int posicionX;
        int posicionY;
        int largo;
        int ancho;
        int velocidadX;
        int velocidadY;

        static Barco()
        {
            auxRandom = new Random(DateTime.Now.Millisecond); 
        }

        public Barco()
        {
             
            velocidadX = auxRandom.Next(-1, 1);
            velocidadY = auxRandom.Next(-1, 1);

            if(velocidadX == 0 && velocidadY == 0)
            {
                this.velocidadX = 1;
            }
        }

        public Barco(int posicionInicialX, int posicionInicialY, int largo, int ancho):this()
        {
            this.posicionX = posicionInicialX;
            this.posicionY = posicionInicialY;


            if (Math.Abs(this.velocidadY) > Math.Abs(this.velocidadX))
            {
                this.ancho = largo > ancho ? largo : ancho;
                this.largo = largo > ancho ? ancho : largo;

            } else
            {

                this.largo = largo > ancho ? largo : ancho;
                this.ancho = largo > ancho ? ancho : largo;

            }

 
        }

        public int PosicionFinalX
        {
            get { return this.posicionX + this.ancho;  }
        }

        public int PosicionFInalY
        {
            get { return this.posicionY + this.largo; }
        }

        public int VelocidadX
        {
            get { return this.velocidadX; }

            set { this.velocidadX = value; }
        }

        public int VelocidadY
        {
            get { return this.velocidadY; }

            set { this.velocidadY = value; }
        }

        public int PosicionX
        {
            get { return this.posicionX; }

            set { this.posicionX = value; }
        }

        public int PosicionY
        {
            get { return this.posicionY; }

            set { this.posicionY = value; }
        }

        public int Ancho
        {
            get { return this.ancho; }

            set { this.ancho = value; }
        }

        public int Largo
        {
            get { return this.largo; }

            set { this.largo = value; }
        }

        public virtual void Mover()
        {

            if (this.velocidadX != 0)
            {
                if((this.posicionX == 1 && this.velocidadX == -1) || (this.PosicionFinalX == Barco.XMax - 1 && this.velocidadX == 1))
                {
                    this.velocidadX = this.velocidadX * -1;
                }

                this.posicionX += this.velocidadX;
            }

            if (this.velocidadY != 0)
            {
                if ((this.posicionY == 1 && this.velocidadY == -1) || (this.PosicionFInalY == Barco.YMax - 1 && this.velocidadY == 1))
                {
                    this.velocidadY = this.velocidadY * -1;
                }


                this.posicionY += this.velocidadY;
            }
        }

        public virtual int ValidarPunto(int x, int y)
        {
            if(posicionX >= x && posicionY >= y && PosicionFinalX <= x && PosicionFInalY <= y)
            {
                return 1;
            }

            return 0;
        }
    }
}
