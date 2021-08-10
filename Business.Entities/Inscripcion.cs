using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Inscripcion : BusinessEntity
    {
        private int _idAlumno;
        private int _idCurso;
        private string _condicion;
        private int? _nota;
        private string _descMateria;
        private string _descComision;
        private string _nombreCompleto;
        private int _legajo;
        private int _cupoCurso;
        public string notaString
        {
            get
            {
                if (Nota.HasValue)
                {
                    return Nota.Value.ToString( "N2" );
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public int CursoCupo
        {
            get { return _cupoCurso; }
            set { _cupoCurso = value; }
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


        public int? Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }


        public string Condicion
        {
            get { return _condicion; }
            set { _condicion = value; }
        }


        public int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }


        public int IdAlumno
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }

    }
}
