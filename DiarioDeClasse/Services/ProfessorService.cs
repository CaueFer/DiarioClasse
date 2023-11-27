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


        public void Adicionar(string nome)
        {

            ProfessorModel novoProfessor = new ProfessorModel { Nome = nome, Matricula = GeradorMatriculaUnica() };

            listaProfessores.Add(novoProfessor);
        }

        public bool RemoverUnico(int matricula)
        {

            ProfessorModel professor = listaProfessores.Find(a => a.Matricula == matricula);
            if (listaProfessores != null)
            {
                listaProfessores.Remove(professor);

                return true;
            }
            else
            {
                return false;
            }
        }
            
        private int GeradorMatriculaUnica()
        {
            Random random = new Random();
            int maxTentativas = 100;

            for (int tentativa = 1; tentativa <= maxTentativas; tentativa++)
            {
                int number = random.Next(0, 9999);

                ProfessorModel professor = listaProfessores.Find(a => a.Matricula == number);
                if (professor == null)
                {
                    return number;
                }
            }
            throw new InvalidOperationException("MAX CAP DE MATRICULA");
        }
    }
}
