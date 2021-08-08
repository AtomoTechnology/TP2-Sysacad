using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string desc_materia;
        private int id_plan;
        private int hs_semanales;
        private int hs_totales;
        private string _descPlan;

        public string DescPlan
        {
            get { return _descPlan; }
            set { _descPlan = value; }
        }

        public string DescMateria
        {
            get { return desc_materia; }
            set { desc_materia = value; }
        }
        public int HsSemanales
        {
            get { return hs_semanales; }
            set { hs_semanales = value; }
        }

        public int HsTotales
        {
            get { return hs_totales; }
            set { hs_totales = value; }
        }

        public int IdPlan
        {
            get { return id_plan; }
            set { id_plan = value; }
        }
    }
}
