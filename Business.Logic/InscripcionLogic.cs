using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Logic
{
    public class InscripcionLogic : BusinessLogic
    {

        private static InscripcionLogic singleton;
        public static InscripcionLogic GetInstance()
        {
            if (singleton == null)
            {
                singleton = new InscripcionLogic();
            }
            return singleton;
        }

        public List<Inscripcion> GetAll(int? idDocente = null, int? idAlumno = null, int? idCom = null, int? idMat = null)
        {
            return InscripcionAdapter.GetInstance().GetAll(idDocente, idAlumno, idCom, idMat);
        }
        public Inscripcion GetOne(int ID)
        {
            return InscripcionAdapter.GetInstance().GetOne(ID);
        }
        public void Delete(int ID)
        {
            try
            {
                var ins = this.GetOne(ID);
                var curso = CursoLogic.GetInstance().GetOne(ins.IdCurso);

                curso.Cupo = curso.Cupo + 1;
                curso.State = BusinessEntity.States.Modified;
                CursoLogic.GetInstance().Save(curso);
                InscripcionAdapter.GetInstance().Delete(ID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void Save(Inscripcion ins)
        {
            // validacion 
            if (ins.State == BusinessEntity.States.New)
            {

                try
                {
                    var curso = CursoLogic.GetInstance().GetOne(ins.IdCurso);
                    if (curso.Cupo > 0)
                    {

                        InscripcionAdapter.GetInstance().Save(ins);
                    }
                    else
                    {
                        Exception exception = new Exception("No hay cupo disponible");
                        throw exception;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                InscripcionAdapter.GetInstance().Save(ins);

            }





        }
        public List<Inscripcion> ReporteCursos(int? idCurso = null, string orderBy = null, string condicion = "")
        {
            return InscripcionAdapter.GetInstance().ReporteCursos(idCurso, orderBy, condicion);
        }
        public List<Inscripcion> GetMateriasAprobadasAlumnos(int idAlumno)
        {
            return InscripcionAdapter.GetInstance().GetMateriasAprobadasAlumnos(idAlumno);
        }
    }
}
