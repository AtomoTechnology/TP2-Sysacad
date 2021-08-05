using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private string desc_plan;
        private string _descEspecialiad;

        public string DescEspecialidad
        {
            get { return _descEspecialiad; }
            set { _descEspecialiad = value; }
        }


        public string DescPlan
        {
            get { return desc_plan; }
            set { desc_plan = value; }
        }
        private int id_especialidad;

        public int IdEspecialidad
        {
            get { return id_especialidad; }
            set { id_especialidad = value; }
        }


    }
}
