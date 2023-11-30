using DiarioDeClasse.Models;
using DiarioDeClasse.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiarioDeClasse.Views
{
    public partial class HUDfaltas : Form
    {
        public TurmaService _turmaService;
        public DisciplinaService _disciplinaService;
        public ProfessorService _professorService;
        public AlunoService _alunoService;
        public FaltaService _faltaService;

        public HUDfaltas(TurmaService turmaService, DisciplinaService disciplinaService, ProfessorService professorService, AlunoService alunoService, FaltaService faltaservice)
        {
            _turmaService = turmaService;
            _disciplinaService = disciplinaService;
            _professorService = professorService;
            _alunoService = alunoService;
            _faltaService = faltaservice;

            InitializeComponent();
            attDateTime();
        }

        private void attDateTime()
        {
            DateTime now = DateTime.Now;
            DayOfWeek dayOfWeek = now.DayOfWeek;

            labelDateTime.Text = "Dia Atual: " + dayOfWeek.ToString();

        }

        //MOSTRAR TURMAS ===========================================================================
        public string selectedTurma;
        private void selectTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectTurmaFaltas.SelectedItem != null)
            {
                selectedTurma = selectTurmaFaltas.SelectedItem.ToString();

                selectDisciplinaFaltas.Text = "";
                attListviewAlunos();
            }
        }

        private void selectTurma_DropDown(object sender, EventArgs e)
        {
            labelResultSelectDisciplina.Text = "";
            labelAllResponses.Text = "";
            selectTurmaFaltas.Items.Clear();

            List<TurmaModel> listTurma = new List<TurmaModel>();
            listTurma = _turmaService.ReturnTurmas();

            foreach (TurmaModel turma in listTurma)
            {
                string stringToSelect = ($"{turma.Name} - " + $"Fase: {turma.Periodo} - " + $"Turno: {turma.Turno}");

                selectTurmaFaltas.Items.Add(stringToSelect);
            }
        }

        // MOSTRA AS DISCIPLINAS ===========================================================================

        string selectedDisciplinaText;
        private void selectDisciplina_DropDown(object sender, EventArgs e)
        {
            labelAllResponses.Text = "";
            selectDisciplinaFaltas.Items.Clear();

            if (selectedTurma != null)
            {
                List<TurmaModel> listTurma = new List<TurmaModel>();
                listTurma = _turmaService.ReturnTurmas();

                foreach (TurmaModel turma in listTurma)
                {
                    if (selectedTurma == ($"{turma.Name} - " + $"Fase: {turma.Periodo} - " + $"Turno: {turma.Turno}"))
                    {
                        List<DisciplinaModel> listDisciplinas = new List<DisciplinaModel>();
                        listDisciplinas = turma.Disciplinas;
                        foreach (DisciplinaModel disciplina in listDisciplinas)
                        {
                            string stringToSelect = ($"{disciplina.Nome}");

                            selectDisciplinaFaltas.Items.Add(stringToSelect);
                        }
                    }
                }
            }
            else labelResultSelectDisciplina.Text = (labelResultSelectDisciplina.Text == "Nenhuma turma selecionada!") ? "" : "Nenhuma turma selecionada!";

        }
        public void selectDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectDisciplinaFaltas.SelectedItem != null)
            {
                selectedDisciplinaText = selectDisciplinaFaltas.SelectedItem.ToString();

                attListviewAlunos();
            }
        }

        //listviewAlunosMainFaltas
        public void attListviewAlunos()
        {

            listviewAlunosMainFaltas.Items.Clear();


            List<AlunoModel> listAlunos = new List<AlunoModel>();
            List<TurmaModel> listTurmas = new List<TurmaModel>();
            List<FaltaModel> listFaltas = new List<FaltaModel>();

            listTurmas = _turmaService.ReturnTurmas();
            listFaltas = _faltaService.ReturnFaltas();
            listAlunos.Clear();

            foreach (var turma in listTurmas)
            {
                if (selectedTurma == ($"{turma.Name} - " + $"Fase: {turma.Periodo} - " + $"Turno: {turma.Turno}"))
                {
                    List<DisciplinaModel> listDisciplinas = new List<DisciplinaModel>();
                    listDisciplinas = turma.Disciplinas;
                    foreach (var disciplina in listDisciplinas)
                    {
                        if (selectedDisciplinaText == disciplina.Nome)
                        {
                            listAlunos.AddRange(turma.Alunos);
                        }
                    }
                }
            }


            //ATUALIZA QUANTIDADE DE FALTAS
            foreach (var aluno in listAlunos) aluno.QntFaltas = 0;

            if (listFaltas.Count > 0)
            {
                foreach (var falta in listFaltas)
                {
                    foreach (var aluno in listAlunos)
                    {
                        if (aluno.Nome == falta.aluno.Nome && selectedDisciplinaText == falta.disciplina.Nome)
                        {
                            aluno.QntFaltas++;
                        }
                    }
                }
            }

            // ATT LISTVIEW ALUNOS
            if (selectDisciplinaFaltas.SelectedItem != null)
            {
                if (listAlunos.Count > 0)
                {
                    foreach (var aluno in listAlunos)
                    {
                        ListViewItem item = new ListViewItem(aluno.Nome);
                        item.SubItems.Add(aluno.Matricula.ToString());
                        item.SubItems.Add(aluno.QntFaltas.ToString());

                        listviewAlunosMainFaltas.Items.Add(item);
                    }
                }
                else labelAllResponses.Text = "Lista de alunos vazia.";
            }
            else labelResultSelectDisciplina.Text = "Selecione disciplina.";

        }
    }
}
