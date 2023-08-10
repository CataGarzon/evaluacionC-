using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionCatalina
{
    class paciente : persona
    {
        private string direccion;
        private string nombreFamiliar;
        private string telefonoFamiliar;

        persona Persona = new persona();

        public paciente(int numeroIdentificacion, string nombre, string apellidos, string telefono, DateTime fechaNacimiento,string direccion, string nombreFamiliar, string telefonoFamiliar) 
         :base(numeroIdentificacion, nombre, apellidos, telefono, fechaNacimiento)
        {
            this.Direccion = direccion;
            this.NombreFamiliar = nombreFamiliar;
            this.TelefonoFamiliar = telefonoFamiliar;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public string NombreFamiliar { get => nombreFamiliar; set => nombreFamiliar = value; }
        public string TelefonoFamiliar { get => telefonoFamiliar; set => telefonoFamiliar = value; }
    }
}
