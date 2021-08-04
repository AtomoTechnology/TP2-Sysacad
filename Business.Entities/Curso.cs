using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int id_materia;

        public int IdMateria
        {
            get { return id_materia; }
            set { id_materia = value; }
        }

        private int id_comision;

        public int IdComision
        {
            get { return id_comision; }
            set { id_comision = value; }
        }

        private int anio_calendario;

        public int AnioCalendario
        {
            get { return anio_calendario; }
            set { anio_calendario = value; }
        }

        private int cupo;

        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }




    }
}
