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
                SqlCommand cmdMateria = new SqlCommand(
                    "select ai.id_inscripcion , mat.desc_materia, com.desc_comision ,per.legajo,ai.id_curso," +
                    " CONCAT(per.nombre , ' ',  per.apellido) NombreCompleto, ai.condicion , isnull(ai.nota,-1) nota  from alumnos_inscripciones ai " +
                    "inner join personas per on per.id_persona = ai.id_alumno " +
                    "inner join cursos cur on cur.id_curso = ai.id_curso " +
                    "inner join materias mat on mat.id_materia = cur.id_materia " +
                    " inner join comisiones com on com.id_comision = cur.id_comision",
                    SqlConn);
                SqlDataReader reader = cmdMateria.ExecuteReader();
                while (reader.Read())
                {
                    Inscripcion ins = new Inscripcion();
                    ins.IdCurso = (int)reader["id_curso"];
                    ins.ID = (int)reader["id_inscripcion"];
                    ins.DescMateria = (string)reader["desc_materia"];
                    ins.DescComision = (string)reader["desc_comision"];
                    ins.NombreCompleto = (string)reader["NombreCompleto"];
                    ins.Condicion = (string)reader["condicion"];
                    ins.Nota = (int)reader["nota"];
                    ins.Legajo = (int)reader["legajo"];

                    //var n = 0 ;
                    //reader["nota"]  ? n = 10 : n= 20;

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

        public Inscripcion GetOne(int ID)
        {

            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Inscripcion ins = new Inscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand(
                    "select ai.id_inscripcion , ai.id_curso , ai.id_alumno, mat.desc_materia, com.desc_comision ,cur.cupo , per.legajo,ai.id_curso," +
                    " CONCAT(per.nombre , ' ',  per.apellido) NombreCompleto, ai.condicion , isnull(ai.nota,-1) nota from alumnos_inscripciones ai " +
                    "inner join personas per on per.id_persona = ai.id_alumno " +
                    "inner join cursos cur on cur.id_curso = ai.id_curso " +
                    "inner join materias mat on mat.id_materia = cur.id_materia " +
                    " inner join comisiones com on com.id_comision = cur.id_comision" +
                    "  where id_inscripcion = @id",
                    SqlConn);
                cmdMateria.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader reader = cmdMateria.ExecuteReader();
                if (reader.Read())
                {
                    ins.ID = (int)reader["id_inscripcion"];
                    ins.IdCurso = (int)reader["id_curso"];
                    ins.IdCurso = (int)reader["id_curso"];
                    ins.IdAlumno = (int)reader["id_alumno"];
                    ins.DescMateria = (string)reader["desc_materia"];
                    ins.DescComision = (string)reader["desc_comision"];
                    ins.NombreCompleto = (string)reader["NombreCompleto"];
                    ins.Condicion = (string)reader["condicion"];
                    ins.Nota = (int)reader["nota"];
                    ins.Legajo = (int)reader["legajo"];
                    ins.CursoCupo = (int)reader["cupo"];


                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de l inscripcion", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return ins;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete  from alumnos_inscripciones where id_inscripcion = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Inscripcion borrada con exito :)");

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la inscripcion", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Inscripcion ins)
        {
            if (ins.CursoCupo > 0)
            {


                try
                {

                    this.OpenConnection();

                    SqlCommand cmdSave = new SqlCommand(
                        "insert into alumnos_inscripciones" +
                        " (id_alumno,id_curso,condicion,nota )" +
                        "values (@id_alumno,@id_curso,@condicon,null)"
                        , SqlConn);
                    cmdSave.Parameters.Add("@condicon", SqlDbType.VarChar, 50).Value = ins.Condicion;
                    cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ins.IdAlumno;
                    cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = ins.IdCurso;
                    cmdSave.ExecuteNonQuery();
                    MessageBox.Show("Inscripcion realizada con exito :)");

                    SqlCommand updateCursoCupo = new SqlCommand("UPDATE cursos SET  cupo = @cupo WHERE id_curso=@id", SqlConn);
                    updateCursoCupo.Parameters.Add("@id", SqlDbType.Int).Value = ins.IdCurso;
                    updateCursoCupo.Parameters.Add("@cupo", SqlDbType.Int).Value = ins.CursoCupo - 1;
                    updateCursoCupo.ExecuteNonQuery();
                    //asi se obtiene el ID que asigna al BD automaticamente
                }
                catch (Exception Ex)
                {

                    Exception Excepcionalejada = new Exception("Error al realizar la inscipcion", Ex); throw Excepcionalejada;
                }

                finally
                {

                    this.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Lo siento!! Ya no hay más cupo para eso curso","Agotación de Cupo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        protected void Update(Inscripcion ins)
        {

            try
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                "UPDATE alumnos_inscripciones SET nota = @nota, condicion = @condicion, " +
                "id_alumno = @id_alumno, id_curso = @id_curso " +
                "WHERE id_inscripcion = @id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = ins.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ins.IdAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = ins.IdCurso;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = ins.Nota;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = ins.Condicion;
                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Inscripcion actualizada con exito :)");
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al actualizar la inscripcion", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }

        public void Save(Inscripcion ins)
        {

            if (ins.State == BusinessEntity.States.Delete)
            {
                this.Delete(ins.ID);

            }
            else if (ins.State == BusinessEntity.States.New)
            {
                this.Insert(ins);

            }
            else if (ins.State == BusinessEntity.States.Modified)
            {
                this.Update(ins);
            }
            ins.State = BusinessEntity.States.Unmodified;

        }
    }
}

