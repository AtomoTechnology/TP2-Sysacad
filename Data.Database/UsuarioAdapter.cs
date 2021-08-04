using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {


        public List<Usuario> GetAll()
        {

            List<Usuario> usuarios = new List<Usuario>();
            this.OpenConnection();
            SqlCommand cmdUsuario = new SqlCommand("Select * from usuarios usr inner join personas per on usr.id_persona = per.id_persona inner join planes pl on pl.id_plan = per.id_plan  ", SqlConn);
            SqlDataReader drUsuarios = cmdUsuario.ExecuteReader();
            while (drUsuarios.Read())
            {
                Usuario usr = new Usuario();
                usr.ID = (int)drUsuarios["id_usuario"];
                usr.Legajo = (int)drUsuarios["legajo"];
                usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                usr.Clave = (string)drUsuarios["clave"];
                usr.Habilitado = (bool)drUsuarios["habilitado"];
                usr.Nombre = (string)drUsuarios["nombre"];
                usr.Apellido = (string)drUsuarios["apellido"];
                usr.Email = (string)drUsuarios["email"];
                usr.Direccion = (string)drUsuarios["direccion"];
                usr.Telefono = (string)drUsuarios["telefono"];
                usr.FechaNac = (DateTime)drUsuarios["fecha_nac"];
                usr.TipoPersona = (int)drUsuarios["tipo_persona"];
                switch (usr.TipoPersona)
                {
                    case 1:
                    usr.DescTipoPersona = "Administrativo";
                        break;
                    case 2:
                        usr.DescTipoPersona = "Docente";
                        break;
                    case 3:
                        usr.DescTipoPersona = "Alumnno";
                        break;
                    default:
                        break;
                }
             
                usr.IdPlan = (int)drUsuarios["id_plan"];
                usr.DescPlan = (string)drUsuarios["desc_plan"];

                usuarios.Add(usr);
            }
            //cerramos el dataReader 
            drUsuarios.Close();
            //cerramos la connexion
            this.CloseConnection();

            return usuarios;
        }

        public Business.Entities.Usuario GetOne(int ID)
        {

            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("select * from usuarios where id_usuario = @id", SqlConn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usr.ID = (int)drUsuario["id_usuario"];
                    usr.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    usr.Clave = (string)drUsuario["clave"];
                    usr.Habilitado = (bool)drUsuario["habilitado"];
                    usr.Nombre = (string)drUsuario["nombre"];
                    usr.Apellido = (string)drUsuario["apellido"];
                    usr.Email = (string)drUsuario["email"];

                }
                drUsuario.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos del usuario", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete  from usuarios where id_usuario = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Usuario borrado con exito :)");

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el  usuario", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Usuario usuario)
        {

            try
            {

                this.OpenConnection();
                using (var dbTr = SqlConn.BeginTransaction())
                {

                    try
                    {

                        SqlCommand cmdSavePersona = new SqlCommand("insert into personas (nombre, apellido,direccion, email,telefono,fecha_nac,legajo,tipo_persona,id_plan)" +
                            "values (@nombre, @apellido,@direccion, @email,@telefono, @fecha_nac, @legajo,@tipo_persona,@id_plan )" +
                            "select @@identity",    //esta lanea es para recuperar el ID que asigna el sql automaticamente 
                            SqlConn,dbTr);
                        cmdSavePersona.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                        cmdSavePersona.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                        cmdSavePersona.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                        cmdSavePersona.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.Direccion;
                        cmdSavePersona.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.Telefono;
                        cmdSavePersona.Parameters.Add("@fecha_nac", SqlDbType.VarChar, 50).Value = usuario.FechaNac;
                        cmdSavePersona.Parameters.Add("@legajo", SqlDbType.VarChar, 50).Value = usuario.Legajo;
                        cmdSavePersona.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = usuario.TipoPersona;
                        cmdSavePersona.Parameters.Add("@id_plan", SqlDbType.Int).Value = usuario.IdPlan;
                        //var result = cmdSavePersona.ExecuteNonQuery();
                        //if (result == 1)
                        //{
                            int idPersona = Decimal.ToInt32((decimal)cmdSavePersona.ExecuteScalar());

                            SqlCommand cmdSave = new SqlCommand("insert into usuarios (nombre_usuario, clave, habilitado, id_persona)" +
                                "values (@nombre_usuario, @clave, @habilitado, @id_persona)" +
                                "select @@identity",    //esta lanea es para recuperar el ID que asigna el sql automaticamente 
                                SqlConn,dbTr);
                            cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                            cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                            cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                            cmdSave.Parameters.Add("@id_persona", SqlDbType.Int).Value = idPersona;
                            cmdSave.ExecuteNonQuery();
                            MessageBox.Show("Operación realizada con exito. )");

                        //}
                        dbTr.Commit();
                    }
                    catch (Exception ex )
                    {
                        dbTr.Rollback();
                        MessageBox.Show("Error al realizar la operación!!!");
                        Exception Excepcionalejada = new Exception("Error al realizar la operación!!!", ex); throw Excepcionalejada;
                    }

                }

            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al realizar la operación!!!", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }
        protected void Update(Usuario usuario)
        {

            try
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(

                "UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave, " +
                "habilitado = @habilitado, nombre = @nombre, apellido = @apellido, email = @email " +
                "WHERE id_usuario=@id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado con exito :)");
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al actualizar el usuario", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }

        public void Save(Usuario usuario)
        {

            if (usuario.State == BusinessEntity.States.Delete)
            {
                this.Delete(usuario.ID);

            }
            else if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);

            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;

        }
        public Usuario LogIn(string username, string password)
        {
            Usuario usr = null;
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("select usr.id_usuario , usr.nombre_usuario , per.tipo_persona from usuarios usr inner join personas per on usr.id_persona = per.id_persona where usr.nombre_usuario = @nombre_usuario AND usr.clave = @clave", SqlConn);
                cmdUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = password;
                cmdUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = username;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usr = new Usuario();
                    usr.ID = (int)drUsuario["id_usuario"];
                    usr.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    //usr.Clave = (string)drUsuario["clave"];
                    //usr.Habilitado = (bool)drUsuario["habilitado"];
                    //usr.Nombre = (string)drUsuario["nombre"];
                    //usr.Apellido = (string)drUsuario["apellido"];
                    //usr.Email = (string)drUsuario["email"];
                    usr.TipoPersona = (int)drUsuario["tipo_persona"];

                }
                drUsuario.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos del usuario", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;
        }
    }
}
