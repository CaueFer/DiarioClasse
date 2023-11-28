using DiarioDeClasse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Services
{
    public class TurmaService
    {
        DisciplinaService disciplinaService = new DisciplinaService();
        AlunoService alunoService = new AlunoService();
        List<DisciplinaModel> ListDisciplinas;
        List<AlunoModel> ListAlunos;
        List<TurmaModel> TurmaList;

        public TurmaService()
        {
            ListDisciplinas = disciplinaService.ReturnDisciplinas();
            ListAlunos = alunoService.ReturnAlunos();

            TurmaList = new List<TurmaModel>()
            {
                new TurmaModel { Id = 0, Name = "Engenharia Software A", Periodo = "1", Turno = "N" , Disciplinas = { ListDisciplinas[0], ListDisciplinas[1], ListDisciplinas[2] }, Alunos = {ListAlunos[0],ListAlunos[1], ListAlunos[2]}},
                new TurmaModel { Id = 1, Name = "Engenharia Software B", Periodo = "1", Turno = "N" , Disciplinas = { ListDisciplinas[3], ListDisciplinas[4], ListDisciplinas[0] }, Alunos = {ListAlunos[3],ListAlunos[4], ListAlunos[5]}},
                new TurmaModel { Id = 2, Name = "Engenharia Software A", Periodo = "2", Turno = "N" , Disciplinas = { ListDisciplinas[5], ListDisciplinas[0], ListDisciplinas[6] }, Alunos = {ListAlunos[6],ListAlunos[7], ListAlunos[8]}}
            };
        }


        public List<TurmaModel> ReturnTurmas()
        {
            return TurmaList;
        }

        public void Adicionar(string nome, string periodo, string turno, List<DisciplinaModel> disciplina, List<AlunoModel> alunos)
        {
            TurmaModel novaTurma = new TurmaModel { Id = TurmaList.Count+1, Name = nome, Periodo = periodo, Turno = turno, Disciplinas = disciplina, Alunos = alunos};

            TurmaList.Add(novaTurma);
        }

        public bool RemoveTurma(string nome)
        {
            TurmaModel novaTurma = TurmaList.Find(a => a.Name == nome);

            if (novaTurma != null)
            {
                TurmaList.Remove(novaTurma);

                return true;
            }
            else return false;
        }
    }

}
