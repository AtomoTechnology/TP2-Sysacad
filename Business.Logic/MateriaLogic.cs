using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class MateriaLogic: BusinessLogic
    {
        private MateriaAdapter materiaAdapter;
        private static MateriaLogic singleton;

        public static  MateriaLogic GetInstance()
        {
            if(singleton == null)
            {
                singleton = new MateriaLogic();
            }
            return singleton;
        }

        public MateriaAdapter MateriaAdapter
        {
            get { return materiaAdapter; }
            set { materiaAdapter = value; }
        }

        public MateriaLogic()
        {
            materiaAdapter = new MateriaAdapter();
        }
        public List<Materia> GetAll()
        {
            return MateriaAdapter.GetAll();
        }
        public Materia GetOne(int id)
        {
            return MateriaAdapter.GetOne(id);
        }
        public void Delete(int id)
        {
            MateriaAdapter.Delete(id);
        }
        public void Save(Materia materia)
        {
            MateriaAdapter.Save(materia);
        }
    }
}
