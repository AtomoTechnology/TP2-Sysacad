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
        public List<Inscripcion> GetAll(int? idDocente , int? idAlumno , int? idCom , int? idMat  )
        {
            List<Inscripcion> inscripciones = new List<Inscripcion>();
            try
            {
                this.OpenConnection();
                string query = "select distinct ai.id_inscripcion , mat.desc_materia, com.desc_comision ,per.legajo,ai.id_curso," +
                    " CONCAT(per.nombre , ' ',  per.apellido) NombreCompleto, ai.condicion , isnull(ai.nota,'') nota  from alumnos_inscripciones ai " +                     
                    "inner join personas per on per.id_persona = ai.id_alumno " +
                    "inner join cursos cur on cur.id_curso = ai.id_curso " +
                    "inner join materias mat on mat.id_materia = cur.id_materia " +
                    " inner join comisiones com on com.id_comision = cur.id_comision ";
                if (idDocente != null)
                {
                    if( idCom != null && idMat != null)
                    {
                        query += $"  inner join docentes_cursos dc on dc.id_curso = ai.id_curso  where dc.id_docente = {idDocente} and cur.id_comision = { idCom } and cur.id_materia = {idMat} ";

                    }
                    else
                    {

                    query += $"  inner join docentes_cursos dc on dc.id_curso = ai.id_curso  where dc.id_docente = {idDocente} ";
                    }
                }
                if (idAlumno != null)
                    query += $"where ai.id_alumno = {idAlumno} ";

                //if( idAlumno != null)
                //    query += $" where usr.id_usuario = {idDocente} ";

                SqlCommand cmdMateria = new SqlCommand(query,SqlConn);
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
                "UPDATE alumnos_inscripciones SET nota = @nota, condicion = @condicion " +              
                " WHERE id_inscripcion = @id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = ins.ID;
                //cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ins.IdAlumno;
                //cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = ins.IdCurso;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = ins.Nota;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = ins.Condicion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al actualizar la inscripcion", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }
            //MessageBox.Show("Inscripcion actualizada con exito :)");


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
        public List<Inscripcion> ReporteCursos( int? idCurso , string orderBy, string condicion)
        {
            List<Inscripcion> inscripciones = new List<Inscripcion>();
            try
            {
                this.OpenConnection();
                string query = "select ins.id_curso , per.legajo, CONCAT(per.apellido ,' ', per.nombre) NombreCompleto , ins.condicion " +
                    ",isnull(ins.nota,'') nota , mat.desc_materia ,com.desc_comision , cur.cupo  " +
                    "from alumnos_inscripciones ins " +
                    "inner join cursos cur " +
                    "on cur.id_curso = ins.id_curso " +
                      "inner join personas per " +
                    "on per.id_persona = ins.id_alumno  " +
                    "inner join usuarios usr " +
                    "on usr.id_persona = per.id_persona " +                  
                    "inner join materias mat " +
                    "on mat.id_materia = cur.id_materia " +
                    "inner join comisiones com " +
                    "on com.id_comision = cur.id_comision ";
                if(idCurso != null)
                {
                    query += $" where ins.id_curso = {idCurso} ";

                }
                if( condicion != "" && idCurso != null)
                {
                    query += $" and ins.condicion = '{condicion}'  ";
                }else if( condicion !="" && idCurso == null)
                {
                    query += $" where  ins.condicion = '{condicion}' ";
                }
                if (orderBy != null)
                {
                    query += $" order by {orderBy} ";
                }
                //MessageBox.Show(query);
                SqlCommand cmdInscripcion = new SqlCommand(query,SqlConn);
                SqlDataReader reader = cmdInscripcion.ExecuteReader();
                while (reader.Read())
                {
                    Inscripcion ins = new Inscripcion();
                    ins.IdCurso = (int)reader["id_curso"];
                    //ins.ID = (int)reader["id_inscripcion"];
                    ins.DescMateria = (string)reader["desc_materia"];
                    ins.DescComision = (string)reader["desc_comision"];
                    ins.NombreCompleto = (string)reader["NombreCompleto"];
                    ins.Condicion = (string)reader["condicion"];
                    ins.Nota = (int)reader["nota"];
                    ins.CursoCupo = (int)reader["cupo"];
                    //ins.Nota = !String.IsNullOrEmpty(reader["nota"].ToString()) ? (int)reader["nota"]: 0;
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
        public List<Inscripcion> GetMateriasAprobadasAlumnos(int idAlumno)
        {
            List<Inscripcion> inscripciones = new List<Inscripcion>();
            try
            {
                this.OpenConnection();
                string query = "select ai.id_inscripcion , mat.desc_materia, com.desc_comision ,per.legajo,ai.id_curso," +
                    " CONCAT(per.nombre , ' ',  per.apellido) NombreCompleto, ai.condicion , isnull(ai.nota,'') nota  from alumnos_inscripciones ai " +
                      "inner join personas per on per.id_persona = ai.id_alumno " +
                     "inner join usuarios usr on usr.id_persona = per.id_persona " +                  
                    "inner join cursos cur on cur.id_curso = ai.id_curso " +
                    "inner join materias mat on mat.id_materia = cur.id_materia " +
                    " inner join comisiones com on com.id_comision = cur.id_comision" +
                    " where ai.id_alumno = @idAlumno and  ai.condicion = 'Aprobada' ";

              
                SqlCommand cmdMateria = new SqlCommand(query, SqlConn);
                cmdMateria.Parameters.Add("@idAlumno", SqlDbType.Int).Value = idAlumno;
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

    }
}

