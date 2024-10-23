using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return $"{this.Id}; {this.Nome}; {this.Descricao}; {this.Valor}";
        }
    }
}
