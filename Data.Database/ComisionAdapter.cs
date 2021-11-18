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
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones com  inner join planes pl on com.id_plan = pl.id_plan", SqlConn);
                SqlDataReader reader = cmdComision.ExecuteReader();
                while (reader.Read())
                {
                    Comision com = new Comision();
                    com.ID = (int)reader["id_comision"];
                    com.DescComision = (string)reader["desc_comision"];
                    com.AnioEspecialidad = (int)reader["anio_especialidad"];
                    com.IdPlan = (int)reader["id_plan"];
                    com.DescPlan = (string)reader["desc_plan"];
                    comisiones.Add(com);
                }
                //cerramos el dataReader 
                reader.Close();

            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception(ex.Message);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }



            return comisiones;
        }

        public Comision GetOne(int ID)
        {

            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Comision com = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from comisiones where id_comision = @id", SqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    com.ID = (int)reader["id_comision"];
                    com.DescComision = (string)reader["desc_comision"];
                    com.AnioEspecialidad = (int)reader["anio_especialidad"];
                    com.IdPlan = (int)reader["id_plan"];

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la comision", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return com;
        }

        public List<Comision> GetComisionPlanes(int idPlan)
        {

            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            List<Comision> comisiones = new List<Comision>();
          
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from comisiones where id_Plan = @id", SqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idPlan;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Comision com = new Comision();
                    com.ID = (int)reader["id_comision"];
                    com.DescComision = (string)reader["desc_comision"];
                    com.AnioEspecialidad = (int)reader["anio_especialidad"];
                    com.IdPlan = (int)reader["id_plan"];
                    comisiones.Add(com);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete  from comisiones where id_comision = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Comision comision)
        {

            try
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("insert into comisiones (desc_comision,anio_especialidad,id_plan )" +
                    "values (@desc_comision,@anio_especialidad,@id_plan)", SqlConn);
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.DescComision;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IdPlan;
                cmdSave.ExecuteNonQuery();
                //asi se obtiene el ID que asigna al BD automaticamente
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al crear la comision", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }
        protected void Update(Comision comision)
        {

            try
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(

                "UPDATE comisiones SET desc_comision = @desc_comision, anio_especialidad = @anio_especialidad, " +
                "id_plan = @id_plan " +
                "WHERE id_comision=@id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.DescComision;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IdPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al actualizar la comision", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }

        public void Save(Comision comision)
        {

            if (comision.State == BusinessEntity.States.Delete)
            {
                this.Delete(comision.ID);

            }
            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);

            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;

        }
    }
}
