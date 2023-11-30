using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Models
{
    public class FaltaModel
    {
        public AlunoModel aluno { get; set; }
        public DisciplinaModel disciplina { get; set; }
        public DayOfWeek dia { get; set; }
    }
}
