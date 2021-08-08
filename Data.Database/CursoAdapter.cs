using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos c inner join comisiones com on com.id_comision = c.id_comision inner join materias m on m.id_materia = c.id_materia", SqlConn);
                SqlDataReader reader = cmdCursos.ExecuteReader();
                while (reader.Read())
                {
                    Curso cur = new Curso();
                    cur.ID = (int)reader["id_curso"];
                    cur.IdMateria = (int)reader["id_materia"];
                    cur.IdComision = (int)reader["id_comision"];
                    cur.AnioCalendario = (int)reader["anio_calendario"];
                    cur.Cupo = (int)reader["cupo"];
                    cur.DescComision = (string)reader["desc_comision"];
                    cur.DescMateria = (string)reader["desc_materia"];
                    cursos.Add(cur);
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



            return cursos;
        }

        public Curso GetOne(int ID)
        {

            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select * from cursos where id_curso = @id", SqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader reader = cmdCurso.ExecuteReader();
                if (reader.Read())
                {
                    cur.ID = (int)reader["id_curso"];
                    cur.IdMateria = (int)reader["id_materia"];
                    cur.IdComision = (int)reader["id_comision"];
                    cur.AnioCalendario = (int)reader["anio_calendario"];
                    cur.Cupo = (int)reader["cupo"];

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos del curso", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cur;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete  from cursos where id_curso = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Curso borrado con exito :)");

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el curso", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Curso curso)
        {

            try
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("insert into cursos (id_materia,id_comision,anio_calendario,cupo )" +
                    "values (@id_materia,@id_comision,@anio_calendario,@cupo)", SqlConn);
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IdMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IdComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Curso agregado con exito :)");
                //asi se obtiene el ID que asigna al BD automaticamente
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al crear el curso ", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }
        protected void Update(Curso curso)
        {

            try
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(

                "UPDATE cursos SET id_materia = @id_materia, id_comision = @id_comision, " +
                "anio_calendario = @anio_calendario, cupo = @cupo " +
                "WHERE id_curso=@id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IdMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IdComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;


                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Curso actualizado con exito :)");
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al actualizar el curso", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }

        public void Save(Curso curso)
        {

            if (curso.State == BusinessEntity.States.Delete)
            {
                this.Delete(curso.ID);

            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);

            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;

        }
    }
}
