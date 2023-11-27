using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Models
{
    public class AlunoModel
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public static implicit operator List<object>(AlunoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
