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
using static System.Windows.Forms.DataFormats;

namespace DiarioDeClasse.Views
{
    public partial class HUDlogin : Form
    {
        public TurmaService _turmaService;
        public DisciplinaService _disciplinaService;
        public ProfessorService _professorService;
        public AlunoService _alunoService;
        public HUDlogin(TurmaService turmaService, DisciplinaService disciplinaService, ProfessorService professorService, AlunoService alunoService)
        {
            _turmaService = turmaService;
            _disciplinaService = disciplinaService;
            _professorService = professorService;
            _alunoService = alunoService;

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HUDmain hudmain = new HUDmain(_turmaService, _disciplinaService, _professorService, _alunoService);
            hudmain.FormClosed += HUDmain_FormClosed;
            this.Hide();
            hudmain.Show();
        }

        private void HUDmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); 
        }
    }
}
