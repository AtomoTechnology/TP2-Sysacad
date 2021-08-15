using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class InscripcionLogic : BusinessLogic
    {

        private static InscripcionLogic singleton; 
        public static  InscripcionLogic GetInstance()
        {
            if( singleton == null)
            {
                singleton = new InscripcionLogic();
            }
            return singleton;
        }

        public List<Inscripcion> GetAll(int? idDocente = null)
        {
           return  InscripcionAdapter.GetInstance().GetAll(idDocente);
        }
        public Inscripcion GetOne(int ID)
        {
            return InscripcionAdapter.GetInstance().GetOne(ID);
        }
        public void Delete(int ID)
        {
            InscripcionAdapter.GetInstance().Delete(ID);
        }
       
        public void Save(Inscripcion ins)
        {
            
            InscripcionAdapter.GetInstance().Save(ins);
        }
        public List<Inscripcion> ReporteCursos(int? idCurso = null, string orderBy = null , string condicion = "")
        {
            return InscripcionAdapter.GetInstance().ReporteCursos(idCurso, orderBy,condicion);
        }

    }
}
