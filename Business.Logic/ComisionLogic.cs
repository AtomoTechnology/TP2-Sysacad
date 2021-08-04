using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        private ComisionAdapter  _comisionData;
        private static ComisionLogic singleton;

        public ComisionAdapter ComisionData
        {
            get { return _comisionData; }
            set { _comisionData = value; }
        }
        public static ComisionLogic GetInstance()
        {

            if (singleton == null)
            {
                singleton = new ComisionLogic();
            }

            return singleton;

        }
        public ComisionLogic()
        {
            _comisionData = new ComisionAdapter();
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }
        public Comision GetOne(int id)
        {
            return ComisionData.GetOne(id);
        }
        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }
        public void Save(Comision comision)
        {
            ComisionData.Save(comision);
        }
    }
}
