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

        public List<Inscripcion> GetAll()
        {
           return  InscripcionAdapter.GetInstance().GetAll();
        }
    }
}
