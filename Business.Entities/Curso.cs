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
        private int id_comision;
        private int anio_calendario;
        private int cupo;
        private string _descComision;
        private string _descMateria;

        public string DescMateria
        {
            get { return _descMateria; }
            set { _descMateria = value; }
        }


        public string DescComision
        {
            get { return _descComision; }
            set { _descComision = value; }
        }


        public int IdMateria
        {
            get { return id_materia; }
            set { id_materia = value; }
        }


        public int IdComision
        {
            get { return id_comision; }
            set { id_comision = value; }
        }


        public int AnioCalendario
        {
            get { return anio_calendario; }
            set { anio_calendario = value; }
        }


        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }
    }
}
