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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiarioDeClasse
{
    public partial class HUDaluno : Form
    {

        public AlunoService _alunoService;
        public HUDaluno(AlunoService alunoService)
        {
            _alunoService = alunoService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            resultLabel.Text = "";
            responseRemoveLabel.Text = "";


            string nomeAluno = txtName.Text;


            if (!string.IsNullOrEmpty(nomeAluno))
            {
                _alunoService.Adicionar(nomeAluno);
                txtName.Clear();
                txtName.Focus();


                resultLabel.Text = ($"Aluno {nomeAluno.ToUpper()} adicionado com sucesso!");
            }
            else
            {
                resultLabel.Text = ("Por favor, insira o nome do aluno.");
            }

            listAlunos.Items.Clear();
            List<AlunoModel> Listalunos = _alunoService.ReturnAlunos();

            foreach (var aluno in Listalunos)
            {
                ListViewItem item = new ListViewItem(aluno.Matricula.ToString());
                item.SubItems.Add(aluno.Nome);

                listAlunos.Items.Add(item);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }


        private void listBtn_Click(object sender, EventArgs e)
        {

            resultLabel.Text = "";
            responseRemoveLabel.Text = "";

            List<AlunoModel> Listalunos = new List<AlunoModel>();
            Listalunos = _alunoService.ReturnAlunos();

            listAlunos.Visible = !listAlunos.Visible;

            if (listAlunos.Visible == true)
            {
                listAlunos.Items.Clear();

                foreach (var aluno in Listalunos)
                {
                    ListViewItem item = new ListViewItem(aluno.Nome);
                    item.SubItems.Add(aluno.Matricula.ToString());

                    listAlunos.Items.Add(item);
                }
            }
        }

        private void listAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            responseRemoveLabel.Text = "";


            if (listAlunos.Items.Count > 0)
            {
                if (listAlunos.SelectedItems.Count > 0)
                {
                    int matriculaToRemove;
                    string matriculaText = listAlunos.SelectedItems[0].SubItems[1].Text;


                    if (int.TryParse(matriculaText, out matriculaToRemove))
                    {
                        if (_alunoService.RemoverUnico(matriculaToRemove))
                        {
                            responseRemoveLabel.Text = ("Aluno removido com sucesso!");
                        }
                        else throw new InvalidOperationException("ERRO REMOVE ALUNO");

                    }
                    else
                    {
                        throw new InvalidOperationException("ERRO MATRICULA TO INT");
                    }

                    //APENAS REMOVE DA TELA
                    listAlunos.Items.Remove(listAlunos.SelectedItems[0]);
                }
                else
                    responseRemoveLabel.Text = ("Nenhum aluno selecionado");


            }
            else
                responseRemoveLabel.Text = ("Nao existe aluno para remover");

        }


        private void responseRemoveLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
