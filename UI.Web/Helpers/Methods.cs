using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace UI.Web.Helpers
{
    public class Methods
    {
        private static string key = "tp2grupo01";
        public static  bool PaginaEnEstadoEdicion()
        {
            
            if (HttpContext.Current.Request.QueryString["id"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Usuario ValidatePermission(string path)
        {
            if (HttpContext.Current.Session["current_user"] == null)
            {
                HttpContext.Current.Response.Redirect("SignIn.aspx");
                return null;
            }
            else
            {
                var user = ((Usuario)HttpContext.Current.Session["current_user"]);
                if( user.TipoPersona == 3 )
                {
                    if( path != "MisDatos" && path != "NuevoInscripto" && path != "UserMateria" && path != "PasswordChange" && path != "NewPassword")
                    {
                        HttpContext.Current.Response.Redirect("Index.aspx");
                    }
                }
                else if(user.TipoPersona == 2)
                {
                    if (path != "MisDatos" && path != "MisCursos" && path != "RegistrarNota" && path != "PasswordChange" && path!= "NewPassword")
                    {
                        HttpContext.Current.Response.Redirect("Index.aspx");
                    }
                }
                else
                {
                    if (path == "UserMateria")
                    {
                        HttpContext.Current.Response.Redirect("Index.aspx");
                    }
                }
                return user;
            }
        }

        public static  string Encriptar(string texto)
        {
            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;
            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar =
            UTF8Encoding.UTF8.GetBytes(texto);

            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform =
            tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado =
            cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
            0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado,
            0, ArrayResultado.Length);
        }

        public static  string Desencriptar(string textoEncriptado)
        {
            byte[] keyArray;
            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar =
            Convert.FromBase64String(textoEncriptado);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5
            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform =
            tdes.CreateDecryptor();

            byte[] resultArray =
            cTransform.TransformFinalBlock(Array_a_Descifrar,
            0, Array_a_Descifrar.Length);

            tdes.Clear();
            //se regresa en forma de cadena
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}