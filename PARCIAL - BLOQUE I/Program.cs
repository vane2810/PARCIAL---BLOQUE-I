using System;
using System.Collections;

namespace PARCIAL___BLOQUE_I
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "";
            do
            {
                int numero_estudiantes;
                ArrayList datos = new ArrayList();
                string nombre;
                int edad;
                double nota1;
                double nota2;
                double parcial;
                double nota;
                string estado;
                int contador = 0;

                Console.Write("Ingrese el número de estudiantes: ");
                numero_estudiantes = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                while (contador < numero_estudiantes)
                {
                    Console.Write("Ingrese el nombre completo del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Laboratorio 1: ");
                    nota1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Laboratorio 2: ");
                    nota2 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Parcial: ");
                    parcial = double.Parse(Console.ReadLine());
                    nota = Nota(nota1, nota2, parcial);
                    
                    Estudiantes _estudiantes = new Estudiantes() { Nombre = nombre, Nota = nota };
                    datos.Add(_estudiantes);
                    contador++;
                    
                    if(nota >=6)
                    {
                        Console.WriteLine("APROBADO");
                    }
                    else
                    {
                        Console.WriteLine("REPROBADO");
                    }
                }

                Console.WriteLine("=========================== DATOS ================================");
                foreach (Estudiantes st in datos)
                {
                    Console.WriteLine(st.getData());
                }


                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("¿Desea continuar?");
                Console.WriteLine("Elija la opción:");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                continuar = Console.ReadLine();
            }
            while (continuar == "1" || continuar == "1");
        }
        //Función (Calcular nota final)
        static double Nota(double nota1, double nota2, double parcial)
        {
            return (nota1 * .3) + (nota2 * .3) + (parcial * .4);
        }

        //Función (Estado aprobado o reprobado)
        
        
        
    }

    public class Estudiantes
    {
        private string NOMBRE;
        private double NOTA;
        private string ESTADO;

        public string Nombre
        {
            get => NOMBRE;
            set => NOMBRE = value;
        }

        public double Nota
        {
            get => NOTA;
            set => NOTA = value;

        }

        public string Estado
        {
            get => ESTADO;
            set => ESTADO = value;
        }

        public string getData()
        {
            return "Nombre completo: " + NOMBRE + " ---  Nota final: " + NOTA + " --- Estado: " + ESTADO;
        }
}   }
    

