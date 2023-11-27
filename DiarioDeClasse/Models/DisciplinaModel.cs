using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Models
{
    public class DisciplinaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public DayOfWeek Dia { get; set; }

        public ProfessorModel Professor { get; set; }   = new ProfessorModel();
    }
}
