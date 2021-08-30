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
    public class DictadoAdapter : Adapter
    {

        public List<Dictado> GetAll(int? idUsuario)
        {
            List<Dictado> cursosDocentes = new List<Dictado>();
            try
            {
                this.OpenConnection();
                     string query = "select dc.id_dictado, dc.cargo, per.legajo , CONCAT(per.apellido,' ', per.nombre) 'NombreCompleto', cur.id_curso ,mat.desc_materia,mat.hs_semanales,com.desc_comision " +
                    "from docentes_cursos dc " +
                    "inner join cursos cur " +
                    "on cur.id_curso = dc.id_curso " +
                    "inner join usuarios usr " +
                    "on usr.id_usuario = dc.id_docente " +
                    " inner join personas per   " +
                    "on per.id_persona = usr.id_persona " +
                    "inner join materias mat  " +
                    "on mat.id_materia = cur.id_materia " +
                    "inner join comisiones com " +
                    "on com.id_comision = cur.id_comision ";
                if( idUsuario != null)
                {
                    query += $" where dc.id_docente = {idUsuario} ";
                }
                SqlCommand cmdDictados = new SqlCommand(query, SqlConn);
                SqlDataReader reader = cmdDictados.ExecuteReader();
                while (reader.Read())
                {
                    Dictado dic = new Dictado();
                    dic.ID = (int)reader["id_dictado"];
                    dic.DescComision = (string)reader["desc_comision"];
                    dic.DescMateria = (string)reader["desc_materia"];
                    dic.NombreCompleto = (string)reader["NombreCompleto"];
                    dic.Legajo = (int)reader["legajo"];
                    dic.Cargo = (int)reader["cargo"];
                    dic.IdCurso = (int)reader["id_curso"];
                    cursosDocentes.Add(dic);

                }
                reader.Close();
                if( cursosDocentes.Count <= 0)
                {
                    MessageBox.Show("Todavia no tiene ningun curso asignado!!!");
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
            return cursosDocentes;
        }

        protected void Insert(Dictado dictado)
        {

            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("insert into docentes_cursos (id_curso, id_docente,cargo) values (@id_curso, @id_docente,@cargo)", SqlConn);
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = dictado.IdCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = dictado.IdDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = dictado.Cargo;

                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Curso asignado  con exito :)");
                //asi se obtiene el ID que asigna al BD automaticamente
            }
            catch (Exception Ex)
            {
                Exception Excepcionalejada = new Exception("Error al asignar el curso", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }

        public  Dictado GetOne(Dictado dictado)
        {
            Dictado dic = new Dictado();
         
            try
            {
                this.OpenConnection();

                SqlCommand cmdGetOne = new SqlCommand("select * from  docentes_cursos where id_curso = @id_curso  and  id_docente =@id_docente and cargo = @cargo ", SqlConn);
                cmdGetOne.Parameters.Add("@id_curso", SqlDbType.Int).Value = dictado.IdCurso;
                cmdGetOne.Parameters.Add("@id_docente", SqlDbType.Int).Value = dictado.IdDocente;
                cmdGetOne.Parameters.Add("@cargo", SqlDbType.Int).Value = dictado.Cargo;
                SqlDataReader reader = cmdGetOne.ExecuteReader();
                if (reader.Read())
                {
                    dic.ID = (int)reader["id_dictado"];
                }
                else
                {
                    dic = null;
                }
                   
                
              
            }
            catch (Exception Ex)
            {
                Exception Excepcionalejada = new Exception("Error al asignar el curso", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }
            return dic;

        }
        public void Save(Dictado dictado)
        {
            if (dictado.State == BusinessEntity.States.New)
            {
                this.Insert(dictado);
            }
            //else if (dictado.State == BusinessEntity.States.Modified)
            //{
            //    this.Update(dictado);
            //}
            //else if (dictado.State == BusinessEntity.States.Delete)
            //{
            //    this.Delete(dictado.ID);
            //}
            dictado.State = BusinessEntity.States.Unmodified;
        }
    }
}
