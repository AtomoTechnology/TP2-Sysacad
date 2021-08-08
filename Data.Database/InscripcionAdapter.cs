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
    public class InscripcionAdapter : Adapter
    {
        private static InscripcionAdapter singleton;
        public static InscripcionAdapter GetInstance()
        {
            if (singleton == null)
            {
                singleton = new InscripcionAdapter();
            }
            return singleton;
        }
        public List<Inscripcion> GetAll()
        {
            List<Inscripcion> inscripciones = new List<Inscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select ai.id_inscripcion , mat.desc_materia, com.desc_comision , CONCAT(per.nombre , ' ',  per.apellido) NombreCompleto, ai.condicion , ai.nota  from alumnos_inscripciones ai inner join personas per on per.id_persona = ai.id_alumno inner join cursos cur on cur.id_curso = ai.id_curso inner join materias mat on mat.id_materia = cur.id_materia  inner join comisiones com on com.id_comision = cur.id_comision", SqlConn);
                SqlDataReader reader = cmdMateria.ExecuteReader();
                while (reader.Read())
                {
                    Inscripcion ins = new Inscripcion();
                    ins.ID = (int)reader["id_inscripcion"];
                    ins.DescMateria = (string)reader["desc_materia"];
                    ins.DescComision = (string)reader["desc_comision"];
                    ins.NombreCompleto = (string)reader["NombreCompleto"];
                    ins.Condicion = (string)reader["condicion"];
                    //var n = 0 ;
                    //reader["nota"]  ? n = 10 : n= 20;

                    //ins.Nota =   reader["nota"] == null ? 0 : (int)reader["nota"];
                    //ins.HsSemanales = (int)reader["hs_semanales"];
                    //ins.HsTotales = (int)reader["hs_totales"];
                    //ins.IdPlan = (int)reader["id_plan"];
                    //ins.DescPlan = (string)reader["desc_plan"];
                    inscripciones.Add(ins);
                }
                //cerramos el dataReader 
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



            return inscripciones;
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
                MessageBox.Show("Materia borrada con exito :)");

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
                MessageBox.Show("Materia agregada con exito :)");
                //asi se obtiene el ID que asigna al BD automaticamente
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
                MessageBox.Show("Materia actualizada con exito :)");
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

