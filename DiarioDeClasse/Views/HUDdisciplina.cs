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
using System.Xml.Linq;

namespace DiarioDeClasse.Views
{
    public partial class HUDdisciplina : Form
    {
        public DisciplinaService _disciplinaService;
        public ProfessorService _professorService;
        public HUDdisciplina(DisciplinaService disciplinaservice, ProfessorService professorService)
        {
            _disciplinaService = disciplinaservice;
            _professorService = professorService;
            InitializeComponent();

            List<string> itens = new List<string>
                {
                    "Segunda",
                    "Terca",
                    "Quarta",
                    "Quinta",
                    "Sexta",
                    "Sabado",
                    "Domingo"
                };
            selectDisciplinaDia.Items.AddRange(itens.ToArray());
            _professorService = professorService;
        }

        private void btnAddDisciplina_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            responseRemoveLabel.Text = "";


            string nomeDisciplina = txtNameDisciplina.Text;
            string siglaDisciplina = txtSiglaDisciplina.Text;
            DayOfWeek diaDisciplina = new DayOfWeek();

            if (selectProfessor.SelectedItem != null)
            {
                List<ProfessorModel> listProfessores = _professorService.ReturnProfessores();
                ProfessorModel professorDisciplina = listProfessores.Find(a => a.Nome == selectProfessor.SelectedItem.ToString());
  
                if (selectDisciplinaDia.SelectedItem != null)
                {
                    string diaSelecionado = selectDisciplinaDia.SelectedItem.ToString();
                    switch (diaSelecionado)
                    {
                        case "Segunda":
                            diaDisciplina = DayOfWeek.Monday;
                            break;

                        case "Terca":
                            diaDisciplina = DayOfWeek.Tuesday;
                            break;

                        case "Quarta":
                            diaDisciplina = DayOfWeek.Wednesday;
                            break;

                        case "Quinta":
                            diaDisciplina = DayOfWeek.Thursday;
                            break;

                        case "Sexta":
                            diaDisciplina = DayOfWeek.Friday;
                            break;

                        case "Sabado":
                            diaDisciplina = DayOfWeek.Saturday;
                            break;

                        case "Domingo":
                            diaDisciplina = DayOfWeek.Sunday;
                            break;
                    }

                    if (!string.IsNullOrEmpty(nomeDisciplina))
                    {
                        if (!string.IsNullOrEmpty(siglaDisciplina))
                        {
                                _disciplinaService.Adicionar(nomeDisciplina, siglaDisciplina, diaDisciplina, professorDisciplina);
                                txtNameDisciplina.Clear();
                                txtNameDisciplina.Focus();

                                resultLabel.Text = ($"Disciplina {nomeDisciplina.ToUpper()} adicionada com sucesso!");  
                        }
                        else resultLabel.Text = ("Por favor, insira a sigla da disciplina.");
                    }
                    else resultLabel.Text = ("Por favor, insira o nome da disciplina.");


                    listviewDisciplinas.Items.Clear();
                    List<DisciplinaModel> Listdisciplinas = _disciplinaService.ReturnDisciplinas();

                    foreach (var disciplina in Listdisciplinas)
                    {
                        ListViewItem item = new ListViewItem(disciplina.Nome);
                        item.SubItems.Add(disciplina.Sigla);
                        item.SubItems.Add(disciplina.Professor.Nome);

                        listviewDisciplinas.Items.Add(item);
                    }
                }
                else resultLabel.Text = ("Por favor, selecione um dia.");

            }
            else resultLabel.Text = ("Por favor, selecione um professor.");
            
        }

        private void selectProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void selectProfessor_DropDown(object sender, EventArgs e)
        {
            selectProfessor.Items.Clear();
            List<ProfessorModel> professores = new List<ProfessorModel>();
            professores = _professorService.ReturnProfessores();

            foreach (var professor in professores)
            {
                selectProfessor.Items.Add(professor.Nome);
            }

        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            responseRemoveLabel.Text = "";


            if (listviewDisciplinas.Items.Count > 0)
            {
                if (listviewDisciplinas.SelectedItems.Count > 0)
                {
                    string nomeToRemove = listviewDisciplinas.SelectedItems[0].SubItems[0].Text;


                    if (nomeToRemove != null)
                    {
                        if (_disciplinaService.RemoveDisciplina(nomeToRemove))
                        {
                            responseRemoveLabel.Text = "Disciplina removida com sucesso!";
                        }
                        else throw new InvalidOperationException("ERRO REMOVE DISCIPLINA");
                    }

                    //APENAS REMOVE DA TELA
                    listviewDisciplinas.Items.Remove(listviewDisciplinas.SelectedItems[0]);
                }
                else
                    responseRemoveLabel.Text = ("Nenhuma disciplina selecionada");
            }
            else
                responseRemoveLabel.Text = ("Nao existe disciplina para remover");
        }

        private void btnMostrarList_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            responseRemoveLabel.Text = "";

            listviewDisciplinas.Visible = !listviewDisciplinas.Visible;

            if (listviewDisciplinas.Visible == true)
            {
                listviewDisciplinas.Items.Clear();
                List<DisciplinaModel> Listdisciplinas = _disciplinaService.ReturnDisciplinas();

                foreach (var disciplina in Listdisciplinas)
                {
                    ListViewItem item = new ListViewItem(disciplina.Nome);
                    item.SubItems.Add(disciplina.Professor.Nome);
                    item.SubItems.Add(disciplina.Sigla);

                    listviewDisciplinas.Items.Add(item);
                }
            }
        }
    }
}
