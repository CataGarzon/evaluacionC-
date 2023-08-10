using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionCatalina
{
    class persona
    {
        protected int numeroIdentificacion;
        protected string nombre;
        protected string apellidos;
        protected string telefono;
        protected DateTime fechaNacimiento;
     

        public persona()
        {
        }

        public persona(int numeroIdentificacion, string nombre, string apellidos, string telefono, DateTime fechaNacimiento)
        {
            this.numeroIdentificacion = numeroIdentificacion;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int NumeroIdentificacion { get => numeroIdentificacion; set => numeroIdentificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }
    }
}
