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
using static System.Windows.Forms.ListView;

namespace DiarioDeClasse.Views
{
    public partial class HUDturma : Form
    {
        public TurmaService _turmaservice;
        public AlunoService _alunoservice;
        public DisciplinaService _disciplinaservice;
        public HUDturma(TurmaService turmaservice, AlunoService alunoservice, DisciplinaService disciplinaservice)
        {
            _turmaservice = turmaservice;
            _alunoservice = alunoservice;
            _disciplinaservice = disciplinaservice;
            InitializeComponent();

            AttListAlunos();
            AttListDisciplinas();
        }

        private void btnMostrarList_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            responseRemoveLabel.Text = "";

            listviewTurmas.Visible = !listviewTurmas.Visible;

            attListTurmas();
        }

        public void attListTurmas()
        {
            if (listviewTurmas.Visible == true)
            {
                listviewTurmas.Items.Clear();
                List<TurmaModel> ListTurmas = _turmaservice.ReturnTurmas();

                foreach (var turma in ListTurmas)
                {
                    ListViewItem item = new ListViewItem(turma.Name);
                    item.SubItems.Add(turma.Periodo);
                    item.SubItems.Add(turma.Turno);

                    listviewTurmas.Items.Add(item);
                }
            }
        }

        public void AttListAlunos()
        {
            List<AlunoModel> listAlunos = _alunoservice.ReturnAlunos();

            foreach (var aluno in listAlunos)
            {
                ListViewItem item = new ListViewItem(aluno.Nome);
                item.SubItems.Add(aluno.Matricula.ToString());

                listviewAlunos.Items.Add(item);
            }
        }

        public void AttListDisciplinas()
        {
            List<DisciplinaModel> listDisciplinas = _disciplinaservice.ReturnDisciplinas();

            foreach (var disciplina in listDisciplinas)
            {
                ListViewItem item = new ListViewItem(disciplina.Nome);
                item.SubItems.Add(disciplina.Sigla);

                listviewDisciplinas.Items.Add(item);
            }
        }

        private void btnAddAlunoToTurma_Click(object sender, EventArgs e)
        {
            if (listviewAlunos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = (ListViewItem)listviewAlunos.SelectedItems[0].Clone();

                if (!JaAdicionado(selectedItem, "aluno"))
                {
                    listviewSelectedAlunos.Items.Add(selectedItem);
                }
            }
        }

        private void btnAddSelectedDisciplina_Click(object sender, EventArgs e)
        {
            if (listviewDisciplinas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = (ListViewItem)listviewDisciplinas.SelectedItems[0].Clone();

                if (!JaAdicionado(selectedItem, ""))
                {
                    listviewSelectedDisciplinas.Items.Add(selectedItem);
                }
            }
        }
        private bool JaAdicionado(ListViewItem listItem, string a)
        {
            ListViewItemCollection list;
            if (a == "aluno")
            {
                list = listviewSelectedAlunos.Items;
            }
            else
            {
                list = listviewSelectedDisciplinas.Items;
            }

            foreach (ListViewItem item in list)
            {
                if (item.Text == listItem.Text && item.SubItems[1].Text == listItem.SubItems[1].Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnRemoveAlunoToTurma_Click(object sender, EventArgs e)
        {
            if (listviewSelectedAlunos.SelectedItems.Count > 0)
            {
                listviewSelectedAlunos.SelectedItems[0].Remove();
            }
        }

        private void btnRemoveSelectDisciplina_Click(object sender, EventArgs e)
        {
            if (listviewSelectedDisciplinas.SelectedItems.Count > 0)
            {
                listviewSelectedDisciplinas.SelectedItems[0].Remove();
            }
        }


        private void btnAddTurma_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            string nomeTurma = txtNameTurma.Text, periodoTurma = txtPeriodoTurma.Text, turnoTurma = txtTurnoTurma.Text;
            if (!string.IsNullOrEmpty(nomeTurma))
            {
                if (!string.IsNullOrEmpty(periodoTurma))
                {
                    if (!string.IsNullOrEmpty(turnoTurma))
                    {
                        if(listviewSelectedDisciplinas.Items.Count > 0)
                        {
                            if(listviewSelectedAlunos.Items.Count > 0)
                            {
                                List<DisciplinaModel> listDisciplinas = _disciplinaservice.ReturnDisciplinas();
                                List<DisciplinaModel> listSelectedDisciplinas = new List<DisciplinaModel>();
                                foreach(var item in listviewSelectedDisciplinas.Items) 
                                {
                                    foreach (var disciplina in listDisciplinas)
                                    {
                                        if (disciplina.Nome == item.ToString())
                                        {
                                            listSelectedDisciplinas.Add(disciplina);
                                        }
                                    }
                                }

                                List<AlunoModel> listAlunos = _alunoservice.ReturnAlunos();
                                List<AlunoModel> listSelectedAlunos = new List<AlunoModel>();
                                foreach (var item in listviewSelectedAlunos.Items)
                                {
                                    foreach (var aluno in listSelectedAlunos)
                                    {
                                        if (aluno.Nome == item.ToString())
                                        {
                                            listSelectedAlunos.Add(aluno);
                                        }
                                    }
                                }

                                _turmaservice.Adicionar(nomeTurma, periodoTurma, turnoTurma, listDisciplinas, listAlunos);
                                attListTurmas();

                                txtNameTurma.Clear();
                                txtPeriodoTurma.Clear();
                                txtTurnoTurma.Clear();
                                listviewSelectedAlunos.Items.Clear();
                                listviewSelectedDisciplinas.Items.Clear();


                                txtNameTurma.Focus();

                                resultLabel.Text = ($"Turma {nomeTurma.ToUpper()} adicionada com sucesso!");
                            }
                        }
                        else resultLabel.Text = "Por favor, selecione ao menos uma disciplina";
                    }
                    else resultLabel.Text = "Por favor, insira turno da turma";
                }
                else resultLabel.Text = "Por favor, insira periodo da turma";
            }
            else resultLabel.Text = "Por favor, insira nome da turma";
        }
    }
}
