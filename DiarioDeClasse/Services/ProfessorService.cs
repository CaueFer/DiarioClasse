using DiarioDeClasse.Models;
using DiarioDeClasse.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Services
{
    public class ProfessorService
    {
        List<ProfessorModel> listaProfessores = new List<ProfessorModel>
        {
            new ProfessorModel { Nome = "Edicarsia", Matricula = 1001},
            new ProfessorModel { Nome = "Mansera", Matricula = 1002 },
            new ProfessorModel { Nome = "Manfredo", Matricula = 1003 }
        };


        public List<ProfessorModel> ReturnProfessores()
        {
            return listaProfessores;
        }
    }
}
