using DiarioDeClasse.Models;
using DiarioDeClasse.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Services
{
    public class AlunoService
    {

        public static List<AlunoModel> Alunos = new List<AlunoModel>();
        public static List<int> Matriculas = new List<int>();


        public AlunoService()
        {
            Alunos = new List<AlunoModel>()
            {
                new AlunoModel { Nome = "Caue Fernandes", Matricula = 1111},
                new AlunoModel { Nome = "Walter Theodoro", Matricula = 2222},
                new AlunoModel { Nome = "Luiz Passos", Matricula = 3333},
                new AlunoModel { Nome = "Helio Costa", Matricula = 4444},
                new AlunoModel { Nome = "Eduzin Japonego", Matricula = 5555},
                new AlunoModel { Nome = "Matheus Chad", Matricula = 6666},
                new AlunoModel { Nome = "Afaunabeto", Matricula = 7777},
                new AlunoModel { Nome = "Joas Ziem", Matricula = 8888},
                new AlunoModel { Nome = "Marcos Santos", Matricula = 9999}
            };
        }

        public List<AlunoModel> ReturnAlunos()
        {
            return Alunos;
        }

        public void Adicionar(string nome)
        {

            AlunoModel novoAluno = new AlunoModel { Nome = nome, Matricula = GeradorMatriculaUnica() };

            Alunos.Add(novoAluno);
        }

        public void RemoveAll(AlunoModel aluno)
        {
            Alunos.Remove(aluno);
        }

        public bool RemoverUnico(int matricula)
        {

            AlunoModel aluno = Alunos.Find(a => a.Matricula == matricula);
            if (aluno != null)
            {
                Alunos.Remove(aluno);

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

                AlunoModel aluno = Alunos.Find(a => a.Matricula == number);
                if (aluno == null)
                {
                    return number;
                }
            }

            throw new InvalidOperationException("MAX CAP DE MATRICULA");
        }


    }
}
