﻿using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CursoLogic
    {
        private CursoAdapter _cursoData;

        public CursoAdapter CursoData
        {
            get { return _cursoData; }
            set { _cursoData = value; }
        }

        private static CursoLogic   singleton;
        public static CursoLogic GetInstance()
        {
            if(singleton == null)
            {
                singleton = new CursoLogic();
            }
            return singleton;
        }
        public CursoLogic()
        {
            _cursoData = new CursoAdapter();
        }
        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }
        public Curso GetOne(int id)
        {
            return CursoData.GetOne(id);
        }
        public void Delete(int id)
        {
            CursoData.Delete(id);
        }
        public void Save(Curso curso)
        {
            CursoData.Save(curso);
        }
        

    }
}
