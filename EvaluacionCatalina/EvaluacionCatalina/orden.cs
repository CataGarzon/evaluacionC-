using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionCatalina
{
    class orden
    {
        private int numeroOrden;
        private DateTime fechaIngreso;
        private DateTime fechaSalida;
        private string estado;
        private double valorFacturado;

        

        public int NumeroOrden { get => numeroOrden; set => numeroOrden = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string Estado { get => estado; set => estado = value; }
        public double ValorFacturado { get => valorFacturado; set => valorFacturado = value; }

        public orden(int numeroOrden, DateTime fechaIngreso, DateTime fechaSalida, string estado, double valorFacturado)
        {
            this.numeroOrden = numeroOrden;
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = fechaSalida;
            this.estado = estado;
            this.valorFacturado = valorFacturado;
        }

       public orden()
        { }
    }

}
