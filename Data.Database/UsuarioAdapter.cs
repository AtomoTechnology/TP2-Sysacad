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


        public List<Usuario> GetAll(int? tipoPersona = null)
        {

            List<Usuario> usuarios = new List<Usuario>();
            this.OpenConnection();
            string query = "Select * from usuarios usr " +
                "inner join personas per on usr.id_persona = per.id_persona " +
                "inner join planes pl on pl.id_plan = per.id_plan ";
            if (tipoPersona != null)
            {
                query += $" where tipo_persona = {tipoPersona} ";
            }
            //MessageBox.Show(query);

            SqlCommand cmdUsuario = new SqlCommand(query, SqlConn);
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
                usr.IdPlan = (int)drUsuarios["id_plan"];
                usr.DescPlan = (string)drUsuarios["desc_plan"];
                usr.IdPersona = (int)drUsuarios["id_persona"];
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
                SqlCommand cmdUsuario = new SqlCommand("select * from usuarios usr" +
                    " inner join personas per on usr.id_persona = per.id_persona " +
                    "inner join planes pl on pl.id_plan = per.id_plan" +
                    "  where id_usuario = @id", SqlConn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuario.ExecuteReader();
                if (drUsuarios.Read())
                {
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
                    usr.IdPlan = (int)drUsuarios["id_plan"];
                    usr.DescPlan = (string)drUsuarios["desc_plan"];
                    usr.IdPersona = (int)drUsuarios["id_persona"];

                }
                drUsuarios.Close();
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
        public Business.Entities.Usuario GetOneByEmailUserLegajo(Usuario usuario)
        {

            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("select * from usuarios usr" +
                    " inner join personas per on usr.id_persona = per.id_persona " +
                    "inner join planes pl on pl.id_plan = per.id_plan" +
                    "  where ( legajo = @legajo or email = @email or nombre_usuario = @nombre_usuario) and id_usuario != @id_usuario ", SqlConn);
                cmdUsuario.Parameters.Add("@legajo", SqlDbType.Int).Value = usuario.Legajo;
                cmdUsuario.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuario.ID;
                cmdUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;

                SqlDataReader drUsuarios = cmdUsuario.ExecuteReader();
                if (drUsuarios.Read())
                {
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
                    usr.IdPlan = (int)drUsuarios["id_plan"];
                    usr.DescPlan = (string)drUsuarios["desc_plan"];
                    usr.IdPersona = (int)drUsuarios["id_persona"];

                }
                else
                {
                    usr = null;
                }
                drUsuarios.Close();
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
            Usuario res = this.GetOne(ID);
            if (res != null)
            {
                try
                {
                    this.OpenConnection();
                    using (var dbTr = SqlConn.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmdDelete = new SqlCommand("delete  from usuarios where id_usuario = @id ", SqlConn, dbTr);
                            cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                            cmdDelete.ExecuteNonQuery();

                            SqlCommand cmdDeletePersona = new SqlCommand("delete  from personas where id_persona = @id_persona ", SqlConn, dbTr);
                            cmdDeletePersona.Parameters.Add("@id_persona", SqlDbType.Int).Value = res.IdPersona;
                            cmdDeletePersona.ExecuteNonQuery();
                            dbTr.Commit();


                        }
                        catch (Exception ex)
                        {
                            dbTr.Rollback();
                            Exception ExcepcionManejada = new Exception("Error al eliminar el  usuario", ex);
                            throw ExcepcionManejada;
                        }
                        finally
                        {
                            this.CloseConnection();
                        }
                    }
                }
                catch (Exception ex)
                {

                    Exception ExcepcionManejada = new Exception("Error al eliminar el  usuario", ex);

                    throw ExcepcionManejada;
                }


            }
            else
            {
                Exception ExcepcionManejada = new Exception("No existe un usuario con este ID!!");
                throw ExcepcionManejada;              
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
                            SqlConn, dbTr);
                        cmdSavePersona.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                        cmdSavePersona.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                        cmdSavePersona.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                        cmdSavePersona.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.Direccion;
                        cmdSavePersona.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.Telefono;
                        cmdSavePersona.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = usuario.FechaNac;
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
                            SqlConn, dbTr);
                        cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                        cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                        cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                        cmdSave.Parameters.Add("@id_persona", SqlDbType.Int).Value = idPersona;
                        cmdSave.ExecuteNonQuery();

                        //}
                        dbTr.Commit();
                    }
                    catch (Exception ex)
                    {
                        dbTr.Rollback();
                        Exception Excepcionalejada = new Exception("Error al realizar la operación!!!", ex); throw Excepcionalejada;
                    }
                    finally
                    {
                        this.CloseConnection();
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
                using (var dbTr = SqlConn.BeginTransaction())
                {
                    try
                    {


                        SqlCommand cmdUpdateUser = new SqlCommand(

                        "UPDATE usuarios SET nombre_usuario = @nombre_usuario, " +
                        "habilitado = @habilitado " +
                        "WHERE id_usuario=@id", SqlConn, dbTr);


                        cmdUpdateUser.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                        cmdUpdateUser.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                        cmdUpdateUser.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                        cmdUpdateUser.ExecuteNonQuery();
                        //cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                        SqlCommand cmdUpdatePerson = new SqlCommand(
                       "UPDATE personas SET    nombre = @nombre, apellido = @apellido, email = @email, legajo = @legajo , direccion = @direccion ,telefono= @telefono ,tipo_persona = @tipo_persona, fecha_nac = @fecha_nac ,id_plan = @id_plan " +
                       "WHERE id_persona=@id_persona", SqlConn, dbTr);

                        cmdUpdatePerson.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.IdPersona;
                        cmdUpdatePerson.Parameters.Add("@legajo", SqlDbType.Int).Value = usuario.Legajo;
                        cmdUpdatePerson.Parameters.Add("@id_plan", SqlDbType.Int).Value = usuario.IdPlan;

                        cmdUpdatePerson.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = usuario.TipoPersona;
                        cmdUpdatePerson.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                        cmdUpdatePerson.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                        cmdUpdatePerson.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                        cmdUpdatePerson.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.Direccion;
                        cmdUpdatePerson.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.Telefono;

                        cmdUpdatePerson.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = usuario.FechaNac;


                        cmdUpdatePerson.ExecuteNonQuery();
                        dbTr.Commit();

                    }
                    catch (Exception Ex)
                    {
                        dbTr.Rollback();
                        Exception Excepcionalejada = new Exception("Error al realizar la operacion!!!", Ex); throw Excepcionalejada;
                    }

                    finally
                    {

                        this.CloseConnection();
                    }
                }




            }
            catch (Exception ex)
            {

                Exception Excepcionalejada = new Exception("Error al realizar la operación!!!", ex); throw Excepcionalejada;
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
                SqlCommand cmdUsuario = new SqlCommand("select * from usuarios usr inner join personas per on usr.id_persona = per.id_persona where usr.nombre_usuario = @nombre_usuario AND usr.clave = @clave", SqlConn);
                cmdUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = password;
                cmdUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = username;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usr = new Usuario();
                    usr.ID = (int)drUsuario["id_usuario"];
                    usr.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    usr.Legajo = (int)drUsuario["legajo"];
                    usr.IdPersona = (int)drUsuario["id_persona"];
                    //usr.Clave = (string)drUsuario["clave"];
                    //usr.Habilitado = (bool)drUsuario["habilitado"];
                    //usr.Email = (string)drUsuario["email"];
                    usr.Nombre = (string)drUsuario["nombre"];
                    usr.Apellido = (string)drUsuario["apellido"];
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

        public void UpdatePassword(int ID , string clave)
        {
            try
            {
                this.OpenConnection();
                using (var dbTr = SqlConn.BeginTransaction())
                {
                    try
                    {                   

                         SqlCommand cmdUpdateUser = new SqlCommand("UPDATE usuarios SET clave = @clave  " +                     
                        "WHERE id_usuario=@id", SqlConn, dbTr);
                        cmdUpdateUser.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                        cmdUpdateUser.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = clave;
                        cmdUpdateUser.ExecuteNonQuery();                    
                        dbTr.Commit();
                    }
                    catch (Exception ex)
                    {
                        dbTr.Rollback();
                        MessageBox.Show("Error al realizar la operación!!!");
                        Exception Excepcionalejada = new Exception("Error al realizar la operación!!!", ex); throw Excepcionalejada;
                    }
                    finally
                    {
                        this.CloseConnection();
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
    }
}
