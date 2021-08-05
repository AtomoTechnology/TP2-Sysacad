using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private string desc_comision;
        private int id_plan;
        private int anio_especialidad;
        private string _descPlan;

        public string DescPlan
        {
            get { return _descPlan; }
            set { _descPlan = value; }
        }


        public string DescComision
        {
            get { return desc_comision; }
            set { desc_comision = value; }
        }

        public int AnioEspecialidad
        {
            get { return anio_especialidad; }
            set { anio_especialidad = value; }
        }


        public int IdPlan
        {
            get { return id_plan; }
            set { id_plan = value; }
        }



    }
}
