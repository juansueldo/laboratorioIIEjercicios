using System;

namespace Entidades
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        
        Random random = new Random();
        
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void Estudiar (byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
        
        public void  CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >=4)
            {
                this.notaFinal = random.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public string Mostrar()
        {
            string retorno = "Datos del alumno";
            Console.WriteLine("Nombre del alumno: {0}", this.nombre);
            Console.WriteLine("Apellido del alumno: {0}", this.apellido);
            Console.WriteLine("Nota 1 del alumno: {0}", this.nota1);
            Console.WriteLine("Nota 2 del alumno: {0}", this.nota2);
            Console.WriteLine("Legajo del alumno: {0}", this.legajo);
            if(this.notaFinal != -1)
            {
                Console.WriteLine("Nota final del alumno: {0}", this.notaFinal);
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.WriteLine("Alumno desaprobado");
                Console.WriteLine("---------------------------");
            }
            return retorno;
        }
    }
}
