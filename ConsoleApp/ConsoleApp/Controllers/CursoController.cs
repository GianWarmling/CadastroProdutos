using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Controllers
{
    public class CursoController
    {
        private static int _id = 0;

        private static List<Curso> _listaCursos = new List<Curso>();

        public void Create(Curso model)
        {
            _id += 1;
            model.Id = _id;
            _listaCursos.Add(model);
        }
        public void Update(Curso model) 
        {
            Curso modelOld = GetById(model.Id);
            int index = _listaCursos.IndexOf(modelOld);
            _listaCursos[index] = model;
        }
        public void Delete(int id)
        {
            Curso model = GetById(id);
            _listaCursos.Remove(model);
        }
        public List<Curso> GetAll() 
        {
            return _listaCursos;
        }
        public Curso GetById(int id) 
        {
            Curso model = _listaCursos.Find(c => c.Id == id);
            return model;
        }
    }
}
