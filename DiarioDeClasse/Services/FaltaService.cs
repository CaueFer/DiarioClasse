using DiarioDeClasse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Services
{
    public class FaltaService
    {
        AlunoService alunoService = new AlunoService();
        DisciplinaService disciplinaService = new DisciplinaService();

        List<FaltaModel> listFaltas;
        List<AlunoModel> ListAlunos;
        List<DisciplinaModel> listaDisciplinas;
        public FaltaService() 
        {
            ListAlunos = alunoService.ReturnAlunos();
            listaDisciplinas = disciplinaService.ReturnDisciplinas();

            listFaltas = new List<FaltaModel>()
            {
                new FaltaModel { aluno = ListAlunos[0], disciplina = listaDisciplinas[0], dia = DayOfWeek.Monday},
                new FaltaModel { aluno = ListAlunos[0], disciplina = listaDisciplinas[0], dia = DayOfWeek.Monday}
            };
        }

        public List<FaltaModel> ReturnFaltas()
        {
            return listFaltas;
        }

        public void Adicionar(DisciplinaModel disciplina, AlunoModel aluno, DayOfWeek dia)
        {

            FaltaModel novaFalta = new FaltaModel { aluno = aluno, disciplina = disciplina, dia = dia};

            listFaltas.Add(novaFalta);
        }

        public bool RemoveFalta(string nome)
        {
            FaltaModel faltaModel = listFaltas.Find(a => a.aluno.Nome == nome);

            if (faltaModel != null)
            {
                listFaltas.Remove(faltaModel);

                return true;
            }
            else return false;
        }
    }
}
