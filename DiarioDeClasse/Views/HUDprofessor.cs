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
    public partial class HUDprofessor : Form
    {

        public ProfessorService _professorService;
        public HUDprofessor(ProfessorService professorservice)
        {
            _professorService = professorservice;
            InitializeComponent();
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            responseRemoveLabel.Text = "";


            string nomeProfessor = txtNameProfessor.Text;


            if (!string.IsNullOrEmpty(nomeProfessor))
            {
                _professorService.Adicionar(nomeProfessor);
                txtNameProfessor.Clear();
                txtNameProfessor.Focus();


                resultLabel.Text = ($"Professor {nomeProfessor.ToUpper()} adicionado com sucesso!");
            }
            else
            {
                resultLabel.Text = ("Por favor, insira o nome do professor.");
            }

            listviewProfessor.Items.Clear();
            List<ProfessorModel> Listprofessores = _professorService.ReturnProfessores();

            foreach (var professor in Listprofessores)
            {
                ListViewItem item = new ListViewItem(professor.Nome);
                item.SubItems.Add(professor.Matricula.ToString());

                listviewProfessor.Items.Add(item);
            }
        }

        private void btnListProfessor_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            responseRemoveLabel.Text = "";

            List<ProfessorModel> Listprofessores = new List<ProfessorModel>();
            Listprofessores = _professorService.ReturnProfessores();

            listviewProfessor.Visible = !listviewProfessor.Visible;

            if (listviewProfessor.Visible == true)
            {
                listviewProfessor.Items.Clear();

                foreach (var professor in Listprofessores)
                {
                    ListViewItem item = new ListViewItem(professor.Nome);
                    item.SubItems.Add(professor.Matricula.ToString());

                    listviewProfessor.Items.Add(item);
                }
            }
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            responseRemoveLabel.Text = "";


            if (listviewProfessor.Items.Count > 0)
            {
                if (listviewProfessor.SelectedItems.Count > 0)
                {
                    int matriculaToRemove;
                    string matriculaText = listviewProfessor.SelectedItems[0].SubItems[1].Text;


                    if (int.TryParse(matriculaText, out matriculaToRemove))
                    {
                        if (_professorService.RemoverUnico(matriculaToRemove))
                        {
                            responseRemoveLabel.Text = ("Professor removido com sucesso!");
                        }
                        else throw new InvalidOperationException("ERRO REMOVE PROFESSOR");

                    }
                    else
                    {
                        throw new InvalidOperationException("ERRO MATRICULA TO INT");
                    }

                    //APENAS REMOVE DA TELA
                    listviewProfessor.Items.Remove(listviewProfessor.SelectedItems[0]);
                }
                else
                    responseRemoveLabel.Text = ("Nenhum professor selecionado");


            }
            else
                responseRemoveLabel.Text = ("Nao existe professor para remover");
        }
    }
}
