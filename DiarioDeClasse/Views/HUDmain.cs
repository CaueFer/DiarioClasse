using DiarioDeClasse.Models;
using DiarioDeClasse.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DiarioDeClasse.Views
{
    public partial class HUDmain : Form
    {
        bool sideBarOn;


        public TurmaService _turmaService;
        public DisciplinaService _disciplinaService;
        public ProfessorService _professorService;
        public AlunoService _alunoService;

        public HUDmain(TurmaService turmaService, DisciplinaService disciplinaService, ProfessorService professorService, AlunoService alunoService)
        {
            _turmaService = turmaService;
            _disciplinaService = disciplinaService;
            _professorService = professorService;
            _alunoService = alunoService;

            InitializeComponent();
            attDateTime();
        }

        private void attDateTime()
        {
            DateTime now = DateTime.Now;
            DayOfWeek dayOfWeek = now.DayOfWeek;

            labelDateTime.Text = "Dia Atual: " + dayOfWeek.ToString();

        }
        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            HUDaluno hudAluno = new HUDaluno(_alunoService);
            hudAluno.ShowDialog();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarOn)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarOn = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarOn = true;
                    sidebarTimer.Stop();
                }
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnMenuOpen_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        public string selectedTurma;
        private void selectTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectTurma.SelectedItem != null)
            {
                selectedTurma = selectTurma.SelectedItem.ToString();

                selectDisciplina.Text = "";
                attListviewAlunos();
            }
        }

        private void selectTurma_DropDown(object sender, EventArgs e)
        {
            labelResultSelectDisciplina.Text = "";
            labelAllResponses.Text = "";
            selectTurma.Items.Clear();

            List<TurmaModel> listTurma = new List<TurmaModel>();
            listTurma = _turmaService.ReturnTurmas();

            foreach (TurmaModel turma in listTurma)
            {
                string stringToSelect = ($"{turma.Name} - " + $"Fase: {turma.Periodo} - " + $"Turno: {turma.Turno}");

                selectTurma.Items.Add(stringToSelect);
            }
        }

        // MOSTRA AS DISCIPLINAS ===========================================================================
        private void selectDisciplina_DropDown(object sender, EventArgs e)
        {
            labelAllResponses.Text = "";
            selectDisciplina.Items.Clear();

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

                            selectDisciplina.Items.Add(stringToSelect);
                        }
                    }
                }
            }
            else labelResultSelectDisciplina.Text = (labelResultSelectDisciplina.Text == "Nenhuma turma selecionada!") ? "" : "Nenhuma turma selecionada!";

        }

        string selectedDisciplinaText;
        public void selectDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectDisciplina.SelectedItem != null)
            {
                selectedDisciplinaText = selectDisciplina.SelectedItem.ToString();

                var ListDisciplina = _disciplinaService.ReturnDisciplinas();

                foreach (var disciplina in ListDisciplina)
                {
                    if (selectedDisciplinaText == disciplina.Nome)
                    {
                        labelSelectedProfessor.Text = ("Professor: " + disciplina.Professor.Nome);
                    }
                }

                attListviewAlunos();
            }
        }

        public void attListviewAlunos()
        {

            listviewAlunosMain.Items.Clear();


            List<AlunoModel> listAlunos = new List<AlunoModel>();
            List<TurmaModel> listTurmas = new List<TurmaModel>();
            listTurmas = _turmaService.ReturnTurmas();

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

            if (selectDisciplina.SelectedItem != null)
            {
                if (listAlunos.Count > 0)
                {
                    foreach (var aluno in listAlunos)
                    {
                        ListViewItem item = new ListViewItem(aluno.Nome);
                        item.SubItems.Add(aluno.Matricula.ToString());

                        listviewAlunosMain.Items.Add(item);
                    }
                }
                else labelAllResponses.Text = "Lista de alunos vazia.";
            }
            else labelResultSelectDisciplina.Text = "Selecione disciplina.";

        }

        private void btnAddDisciplina_Click(object sender, EventArgs e)
        {
            HUDdisciplina hudDisciplina = new HUDdisciplina(_disciplinaService, _professorService);
            hudDisciplina.ShowDialog();
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            HUDprofessor hudProfessor = new HUDprofessor(_professorService);
            hudProfessor.ShowDialog();
        }

        private void btnAddTurma_Click(object sender, EventArgs e)
        {
            HUDturma hudTurma = new HUDturma(_turmaService, _alunoService, _disciplinaService);
            hudTurma.ShowDialog();
        }
    }
}
