using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Models
{
    public class TurmaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Turno { get; set; }
        public string Periodo { get; set; }

        public List<DisciplinaModel> Disciplinas { get; set; } = new List<DisciplinaModel>();

        public List<AlunoModel> Alunos { get; set; } = new List<AlunoModel>();
    }
}
