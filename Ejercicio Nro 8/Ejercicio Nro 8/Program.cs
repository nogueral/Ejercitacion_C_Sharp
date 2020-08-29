using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_8
{
    class Program
    {
        /*
        Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) 
        y la cantidad de horas
        trabajadas en el mes de N empleados de una fábrica.
        Se pide calcular el importe a cobrar teniendo en cuenta que el total 
        (que resulta de multiplicar el
        valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
        multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
        descuentos.
        Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
        el total a cobrar en
        bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
        Nota: Utilizar estructuras repetitivas y selectivas.
         */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 8";

            Empleado[] listaEmpleados = new Empleado[3];
            int cantidadHoras;
            int antiguedad;
            float valorHora;

            for (int i = 0; i < listaEmpleados.Length; i++)
            {
                listaEmpleados[i] = new Empleado();

                Console.Write("Ingrese nombre: ");
                listaEmpleados[i].SetNombre(Console.ReadLine());

                Console.Write("Ingrese antiguedad: ");
                int.TryParse(Console.ReadLine(), out antiguedad);
                listaEmpleados[i].SetAntiguedad(antiguedad);

                Console.Write("Ingrese horas trabajadas: ");
                int.TryParse(Console.ReadLine(), out cantidadHoras);
                listaEmpleados[i].SetAntiguedad(cantidadHoras);

                Console.Write("Ingrese valor de la hora: ");
                float.TryParse(Console.ReadLine(), out valorHora);
                listaEmpleados[i].SetValorHora(valorHora);
            }

            foreach (Empleado item in listaEmpleados)
            {
                item.GetSueldo();
            }
        }
    }
}
