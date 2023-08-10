using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionCatalina
{
    class Medico: persona
    {
        persona Persona = new persona();
        private string numeroLiciencia;
        private string especialidad;

        public Medico(int numeroIdentificacion, string nombre, string apellidos, string telefono, DateTime fechaNacimiento, string numeroLiciencia, string especialidad)
            : base(numeroIdentificacion, nombre, apellidos, telefono, fechaNacimiento)
        {
            this.NumeroLiciencia = numeroLiciencia;
            this.Especialidad = especialidad;
        }

        public string NumeroLiciencia { get => numeroLiciencia; set => numeroLiciencia = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
