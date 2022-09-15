using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Negocio
    {
        static string nombreIdea, impactoSocial;
        static double valorInversion, ingresosProyectos;
        static int cantidadIntegrantes;
        //herencia  departamentos, integrantes
        //List<Departamento> listaDepartamentos = new List<Departamento>();
        //List<Integrante> listaIntegrante = new List<Integrante>();

         public Negocio(string nombreIdea, string impactoSocial, double valorInversion, double ingresosProyectos)
        {
            this.NombreIdea = nombreIdea;
            this.ImpactoSocial = impactoSocial;
            this.ValorInversion = valorInversion;
            this.IngresosProyectos = ingresosProyectos;
        }

        static public string NombreIdea { get => nombreIdea; set => nombreIdea = value; }
        static public string ImpactoSocial { get => impactoSocial; set => impactoSocial = value; }
        static public double ValorInversion { get => valorInversion; set => valorInversion = value; }
        static public double IngresosProyectos { get => ingresosProyectos; set => ingresosProyectos = value; }

        public static void recoleccionDatos()
        {
            Console.WriteLine("Ingrese el nombre de la idea de negocio: ");
            nombreIdea = Console.ReadLine();
            Console.WriteLine("Ingrese el impacto social o economico que tiene el negocio: ");
            impactoSocial = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de integrantes del proyecto: ");
            cantidadIntegrantes = Convert.ToInt16(Console.ReadLine());

            for(i = 0; i < cantidadIntegrantes; i++)
            {
                

            }
                


        }
    }
}
