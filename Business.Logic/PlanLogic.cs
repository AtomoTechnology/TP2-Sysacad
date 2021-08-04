using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        PlanAdapter adapterPlan ;
        private static PlanLogic singleton;


        public static PlanLogic GetInstance()
        {

            if (singleton == null)
            {
                singleton = new PlanLogic();
            }

            return singleton;

        }
        public PlanLogic()
        {
            adapterPlan = new PlanAdapter();
        }
        public List<Plan> GetAll()
        {
            return adapterPlan.GetAll();
        }
        public void Delete( int ID )
        {
            adapterPlan.Delete(ID);
        }
        public Plan GetOne(int ID)
        {
           return  adapterPlan.GetOne(ID);
        }
        public void Save(Plan plan)
        {
            adapterPlan.Save(plan);
        }
    }
}
