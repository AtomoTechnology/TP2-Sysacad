using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EspecialidadLogic :BusinessLogic
    {
        private EspecialidadAdapter esp_data;
        private static EspecialidadLogic singleton;


        public static EspecialidadLogic GetInstance()
        {

            if (singleton == null)
            {
                singleton = new EspecialidadLogic();
            }

            return singleton;

        }
        public EspecialidadAdapter especialidad
        {
            get { return esp_data; }
            set { esp_data = value; }
        }
        public EspecialidadLogic()
        {
            esp_data = new EspecialidadAdapter();
        }

        public Especialidad GetOne(int id)
        {
            return especialidad.GetOne(id);
        }
        public List<Especialidad> GetAll()
        {
            return esp_data.GetAll();
        }
        public void DeleteOne(int ID)
        {
            esp_data.DeleteOne(ID);
        }
        public void Create(Especialidad esp)
        {
            esp_data.Create(esp);
        }
        public void Update (Especialidad esp)
        {
            esp_data.Update(esp);
        }
        public void Save(Especialidad esp)
        {
            esp_data.Save(esp);

        }
    }
}
