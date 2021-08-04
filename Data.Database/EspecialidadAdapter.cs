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
    public class EspecialidadAdapter : Adapter
    {


        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdEsp = new SqlCommand("SELECT * FROM especialidades", this.SqlConn);
                SqlDataReader reader = cmdEsp.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = (int)reader["id_especialidad"];
                    esp.desc_especialidad = (String)reader["desc_especialidad"];
                    especialidades.Add(esp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la especialidad", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return especialidades;
        }
        public Business.Entities.Especialidad GetOne(int id)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEsp = new SqlCommand("SELECT * FROM especialidades WHERE id_especialidad = @id", this.SqlConn);
                cmdEsp.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmdEsp.ExecuteReader();

                if (reader.Read())
                {
                    esp.desc_especialidad = (String)reader["desc_especialidad"];
                    esp.ID = (int)reader["id_especialidad"];

                }

            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la especialidad", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;
        }
        public void DeleteOne(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdEsp = new SqlCommand("DELETE  FROM especialidades WHERE id_especialidad = @id", this.SqlConn);
                cmdEsp.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdEsp.ExecuteNonQuery();

                MessageBox.Show("Especialidad borrado con exito");


            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la especialidad", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Update(Especialidad esp)
        {

            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(

                "UPDATE especialidades SET desc_especialidad = @desc_especialidad WHERE id_especialidad=@id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = esp.ID;

                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = esp.desc_especialidad;
                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Especialidad actualizado con exito");
            }
            catch (Exception Ex)
            {
                Exception Excepcionalejada = new Exception("Error al actualizar la especialidad", Ex); throw Excepcionalejada;
            }

            finally
            {
                this.CloseConnection();
            }

        }
        public void Create(Especialidad esp)
        {
            try
            {

                this.OpenConnection();
                SqlCommand cmdEsp = new SqlCommand("insert into  especialidades (desc_especialidad) " + "values (@desc_especialidad)", this.SqlConn);
                cmdEsp.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = esp.desc_especialidad;
                cmdEsp.ExecuteNonQuery();
                MessageBox.Show("Especialidad creado con exito");

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la especialidad", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Especialidad esp)
        {
            if (esp.State == BusinessEntity.States.Delete)
            {
                this.DeleteOne(esp.ID);

            }
            else if (esp.State == BusinessEntity.States.New)
            {
                this.Create(esp);

            }
            else if (esp.State == BusinessEntity.States.Modified)
            {
                this.Update(esp);
            }
            esp.State = BusinessEntity.States.Unmodified;
        }
    }
}
