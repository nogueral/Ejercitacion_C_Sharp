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
        private double saldo;

        public Cliente(string nombre, string apellido, long dni, string usuario, string clave, int nroCuenta, double saldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.usuario = usuario;
            this.clave = clave;
            this.nroCuenta = nroCuenta;
            this.saldo = saldo;

        }

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

        public void SetSaldo (double auxSaldo)
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

        public double GetSaldo()
        {
            return this.saldo;
        }

        public long GetDni()
        {
            return this.dni;
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
