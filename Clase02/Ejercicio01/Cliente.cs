using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private long dni;
        private string usuario;
        private string clave;
        private int nroCuenta;
        private float saldo;

        public void SetNombre (string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public void SetApellido (string auxApellido)
        {
            this.apellido = auxApellido;
        }

        public void SetUsuario (string auxUsuario)
        {
            this.usuario = auxUsuario;
        }

        public void SetClave (string auxClave)
        {
            this.clave = auxClave;
        }

        public void SetDni (long auxDni)
        {
            this.dni = auxDni;
        }

        public void SetNroCuenta(int auxNroCuenta)
        {
            this.nroCuenta = auxNroCuenta;
        }

        public void SetSaldo (int auxSaldo)
        {
            this.saldo = auxSaldo;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public string GetUsuario()
        {
            return this.usuario;
        }

        public string GetContrasena()
        {
            return this.clave;
        }

        public long GetNroCuenta()
        {
            return this.nroCuenta;
        }

        public float GetSaldo()
        {
            return this.saldo;
        }

        public long GetDni()
        {
            return this.dni;
        }

        public static void ValidarUsers (ref string dato)
        {
            
            while (string.IsNullOrEmpty(dato))
            {
                Console.Write("El dato ingresado no puede ser vacio o nulo, reingrese: ");
                dato = Console.ReadLine();
            }
        }

        public void AgregarDinero (int auxSaldo)
        {
            this.saldo += auxSaldo;
        }

        public bool RetirarDinero (int auxSaldo)
        {
            bool retorno = false;

            if(this.saldo > auxSaldo)
            {
                this.saldo -= auxSaldo;
                retorno = true;
            }


            return retorno;
        }
    }
}
