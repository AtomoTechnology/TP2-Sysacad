using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
   public  class DictadoLogic : BusinessLogic
    {
        DictadoAdapter dictadoAdapter = new DictadoAdapter();
        private static DictadoLogic singleton;
        public static DictadoLogic GetInstance()
        {

            if (singleton == null)
            {
                singleton = new DictadoLogic();
            }

            return singleton;

        }
        public List<Dictado> GetAll(int? idUsuario = null )
        {
            return dictadoAdapter.GetAll(idUsuario);
        }
        public void Save(Dictado dictado)
        {
            dictadoAdapter.Save(dictado);
        }
    }
}
