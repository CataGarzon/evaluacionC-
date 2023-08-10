using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionCatalina
{
    class habitacion
    {
        private int numeroHabitacion;
        private int cama;

        public habitacion(){ }
        public habitacion(int numeroHabitacion, int cama)
        {
            this.numeroHabitacion = numeroHabitacion;
            this.cama = cama;
        }

        public int NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }
        public int Cama { get => cama; set => cama = value; }
    }
}
