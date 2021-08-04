using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private string _nombreUsuario;
        private string _nombre;
        private string _clave;
        private string _apellido;
        private string _email;
        private bool _habilitado;
       // private int _idPersona;
        private int _tipopersona;
        private string _direccion;
        private string _telefono;
        private DateTime _fechaNac; 
        private int _legajo;
        private int _idPlan;
        private string  _descPlan;
        private string _descTipoPersona;

        public string DescTipoPersona
        {
            get { return _descTipoPersona; }
            set { _descTipoPersona = value; }
        }


        public string  DescPlan
        {
            get { return _descPlan; }
            set { _descPlan = value; }
        }


        public int IdPlan
        {
            get { return _idPlan; }
            set { _idPlan = value; }
        }


        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }



        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }


        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }



        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }



        public int TipoPersona
        {
            get { return _tipopersona; }
            set { _tipopersona = value; }
        }




        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }


        public string  Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

     

        public string  Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
       

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
     

        public string  Email
        {
            get { return _email; }
            set { _email = value; }
        }
 

        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }



    }
}
