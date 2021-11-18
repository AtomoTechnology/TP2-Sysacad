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
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias m inner join planes p  on m.id_plan = p.id_plan", SqlConn);
                SqlDataReader reader = cmdMateria.ExecuteReader();
                while (reader.Read())
                {
                    Materia mat = new Materia();
                    mat.ID = (int)reader["id_materia"];
                    mat.DescMateria = (string)reader["desc_materia"];
                    mat.HsSemanales = (int)reader["hs_semanales"];
                    mat.HsTotales = (int)reader["hs_totales"];
                    mat.IdPlan = (int)reader["id_plan"];
                    mat.DescPlan = (string)reader["desc_plan"];
                    materias.Add(mat);
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
            return materias;
        }

        public Materia GetOne(int ID)
        {

            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias where id_materia = @id", SqlConn);
                cmdMateria.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader reader = cmdMateria.ExecuteReader();
                if (reader.Read())
                {
                    mat.ID = (int)reader["id_materia"];
                    mat.DescMateria = (string)reader["desc_materia"];
                    mat.HsSemanales = (int)reader["hs_semanales"];
                    mat.HsTotales = (int)reader["hs_totales"];
                    mat.IdPlan = (int)reader["id_plan"];
                    mat.State = BusinessEntity.States.Unmodified;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de las materias", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mat;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete  from materias where id_materia = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
                //MessageBox.Show("Materia borrada con exito :)");

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la materia", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Materia materia)
        {

            try
            {

                this.OpenConnection();


                SqlCommand cmdSave = new SqlCommand("insert into materias (desc_materia,hs_semanales,hs_totales,id_plan )" +
                    "values (@desc_materia,@hs_semanales,@hs_totales,@id_plan)", SqlConn);
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.DescMateria;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HsSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HsTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IdPlan;
                cmdSave.ExecuteNonQuery();               
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al crear la materia", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }
        protected void Update(Materia materia)
        {

            try
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(

                "UPDATE materias SET desc_materia = @desc_materia, hs_semanales = @hs_semanales, " +
                "hs_totales = @hs_totales, id_plan = @id_plan " +
                "WHERE id_materia=@id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.DescMateria;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.VarChar, 50).Value = materia.HsSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.VarChar, 50).Value = materia.HsTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IdPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al actualizar la materia", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }

        public void Save(Materia materia)
        {

            if (materia.State == BusinessEntity.States.Delete)
            {
                this.Delete(materia.ID);

            }
            else if (materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);

            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                this.Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;

        }
    }
}

