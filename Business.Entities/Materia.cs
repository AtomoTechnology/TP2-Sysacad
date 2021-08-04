using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia :BusinessEntity
    {
        private string desc_materia;

        public string DescMateria
        {
            get { return desc_materia; }
            set { desc_materia = value; }
        }

        private int hs_semanales;

        public int HsSemanales
        {
            get { return hs_semanales; }
            set { hs_semanales = value; }
        }
        private int hs_totales;

        public int HsTotales
        {
            get { return hs_totales; }
            set { hs_totales = value; }
        }
        private int id_plan;

        public int IdPlan
        {
            get { return id_plan; }
            set { id_plan = value; }
        }




    }
}
