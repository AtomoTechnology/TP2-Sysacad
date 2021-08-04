using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision :BusinessEntity
    {
        private string desc_comision;

        public string DescComision
        {
            get { return desc_comision; }
            set { desc_comision = value; }
        }
        private int anio_especialidad;

        public int AnioEspecialidad
        {
            get { return anio_especialidad; }
            set { anio_especialidad = value; }
        }

        private int id_plan;

        public int IdPlan
        {
            get { return id_plan; }
            set { id_plan = value; }
        }



    }
}
