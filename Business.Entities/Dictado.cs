using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Dictado : BusinessEntity
    {
        private int  _idCurso;
        private int _idDocente;
        private int _cargo;
        private string _nombreCompleto;
        private int _legajo;
        private string _descMateria;
        private string _descComision;
        public string DescCargo
        {
            get
            {
                if(this.Cargo == 1)
                {
                    return "Primer profe";
                }
                else
                {
                    return "Segundo Profe";
                }
            }
        }

        public string DescComision
        {
            get { return _descComision; }
            set { _descComision = value; }
        }


        public string DescMateria
        {
            get { return _descMateria; }
            set { _descMateria = value; }
        }


        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }


        public string NombreCompleto
        {
            get { return _nombreCompleto; }
            set { _nombreCompleto = value; }
        }


        public int Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }


        public int IdDocente
        {
            get { return _idDocente; }
            set { _idDocente = value; }
        }


        public int  IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

    }
}
