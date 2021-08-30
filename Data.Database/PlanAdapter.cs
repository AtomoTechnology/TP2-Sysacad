using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("select * from planes pl inner join especialidades esp on esp.id_especialidad = pl.id_especialidad", SqlConn);
                SqlDataReader reader = cmdPlan.ExecuteReader();
                while (reader.Read())
                {
                    Plan p = new Plan();
                    p.ID = (int)reader["id_plan"];
                    p.DescPlan = (string)reader["desc_plan"];
                    p.IdEspecialidad = (int)reader["id_especialidad"];
                    p.DescEspecialidad = (string)reader["desc_especialidad"];
                    planes.Add(p);

                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                this.CloseConnection();
            }
            return planes;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("delete  from planes where id_plan = @idPlan", SqlConn);
                cmdPlan.Parameters.Add("@idPlan", SqlDbType.Int).Value = ID;
                cmdPlan.ExecuteNonQuery();
                MessageBox.Show("Plan borrado con exito :)", "Delete Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public Plan GetOne(int ID)
        {
            Plan p = new Plan();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("select *  from planes where id_plan = @idPlan", SqlConn);
                cmdPlan.Parameters.Add("@idPlan", SqlDbType.Int).Value = ID;
                SqlDataReader reader = cmdPlan.ExecuteReader();

                if (reader.Read())
                {
                    p.ID = (int)reader["id_plan"];
                    p.DescPlan = (string)reader["desc_plan"];
                    p.IdEspecialidad = (int)reader["id_especialidad"];
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                this.CloseConnection();
            }
            return p;
        }
        protected void Insert(Plan plan)
        {

            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("insert into planes (desc_plan, id_especialidad) values (@desc_plan, @id_especialidad)", SqlConn);
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.DescPlan;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IdEspecialidad;
                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Plan agregado con exito :)");
                //asi se obtiene el ID que asigna al BD automaticamente
            }
            catch (Exception Ex)
            {
                Exception Excepcionalejada = new Exception("Error al crear el plan", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }
        protected void Update(Plan plan)
        {

            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(

                "UPDATE planes SET desc_plan = @desc_plan , id_especialidad = @id_especialidad WHERE id_plan=@id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.DescPlan;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IdEspecialidad;
                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Plan actualizado con exito :)");
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al actualizar el plan", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }
        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            else if (plan.State == BusinessEntity.States.Delete)
            {
                this.Delete(plan.ID);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

        public List<Materia> ReportePlanes( int? idPlan , int? idMateria )
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                string query = "select * from planes pl inner join materias mat  on mat.id_plan = pl.id_plan ";
                if(idPlan != null)
                {
                    query += $" where pl.id_plan = { idPlan} ";
                }
                if (idMateria !=null)
                {
                    query += $" where mat.id_materia = { idMateria} ";
                }

                SqlCommand cmdPlan = new SqlCommand(query, SqlConn);
                SqlDataReader reader = cmdPlan.ExecuteReader();
                while (reader.Read())
                {
                    Materia m = new Materia();
                    m.ID = (int)reader["id_plan"];
                    m.DescPlan = (string)reader["desc_plan"];
                    m.IdPlan = (int)reader["id_plan"];
                    m.DescMateria = (string)reader["desc_materia"];
                    m.HsSemanales = (int)reader["hs_semanales"];
                    m.HsTotales = (int)reader["hs_totales"];


                    materias.Add(m);

                }
                if (materias.Count <= 0)
                    MessageBox.Show("No hay resultado!!!");
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                this.CloseConnection();
            }
            
            return materias;
        }
    }
}
