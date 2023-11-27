using DiarioDeClasse.Models;
using DiarioDeClasse.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Services
{
    public class DisciplinaService
    {
        ProfessorService professorService = new ProfessorService();
        List<ProfessorModel> ListProfessores;
        List<DisciplinaModel> listaDisciplinas;

        public DisciplinaService()
        {
            ListProfessores = professorService.ReturnProfessores();

            listaDisciplinas = new List<DisciplinaModel>()
            {
                new DisciplinaModel { Id = 1, Nome = "Progamacao Orientada a Objetos", Sigla = "POO", Dia = DayOfWeek.Monday, Professor = ListProfessores[0]},
                new DisciplinaModel { Id = 2, Nome = "Fundamentos da Progamacao", Sigla = "FDP", Dia = DayOfWeek.Tuesday, Professor = ListProfessores[1]},
                new DisciplinaModel { Id = 3, Nome = "UI e UX Design", Sigla = "UIX", Dia = DayOfWeek.Wednesday, Professor = ListProfessores[2]},
                new DisciplinaModel { Id = 4, Nome = "Disciplina A", Sigla = "AAA", Dia = DayOfWeek.Tuesday , Professor = ListProfessores[0]},
                new DisciplinaModel { Id = 5, Nome = "Disciplina AB", Sigla = "ABB", Dia = DayOfWeek.Wednesday , Professor = ListProfessores[1]},
                new DisciplinaModel { Id = 6, Nome = "Disciplina ABC", Sigla = "ABC", Dia = DayOfWeek.Tuesday , Professor = ListProfessores[2]},
                new DisciplinaModel { Id = 7, Nome = "Disciplina ABCD", Sigla = "BCD", Dia = DayOfWeek.Wednesday , Professor = ListProfessores[0]}
            };
        }

           
        public List<DisciplinaModel> ReturnDisciplinas()
        {
            return listaDisciplinas;
        }

        public void Adicionar(string nome, string sigla, DayOfWeek dia, ProfessorModel professor)
        {
            DisciplinaModel novaDisciplina = new DisciplinaModel { Nome = nome, Sigla = sigla, Dia = dia, Professor = professor };

            listaDisciplinas.Add(novaDisciplina);
        }

        public bool RemoveDisciplina(string nome)
        {
            DisciplinaModel disciplinaModel = listaDisciplinas.Find(a => a.Nome == nome);

            if(disciplinaModel != null) 
            {
                listaDisciplinas.Remove(disciplinaModel);

                return true;
            } else return false;
        }

    }
}
