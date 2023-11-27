namespace DiarioDeClasse.Views
{
    partial class HUDmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HUDmain));
            titleLabel = new Label();
            sideBar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            btnMenu = new PictureBox();
            panel2 = new Panel();
            btnAddTurma = new Button();
            panel3 = new Panel();
            btnAddProfessor = new Button();
            panel4 = new Panel();
            btnAddAluno = new Button();
            panel5 = new Panel();
            btnAddDisciplina = new Button();
            btnMenuOpen = new PictureBox();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            labelSelectTurma = new Label();
            selectTurma = new ComboBox();
            selectDisciplina = new ComboBox();
            labelSelectDisciplina = new Label();
            labelResultSelectDisciplina = new Label();
            labelListviewAlunos = new Label();
            listviewAlunosMain = new ListView();
            listviewAlunos = new ColumnHeader();
            listviewMatricula = new ColumnHeader();
            listviewPresente = new ColumnHeader();
            label2 = new Label();
            labelAllResponses = new Label();
            labelDateTime = new Label();
            labelSelectedProfessor = new Label();
            sideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenuOpen).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(308, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(199, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Diario de Classe";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sideBar
            // 
            sideBar.BackColor = SystemColors.ActiveCaptionText;
            sideBar.BackgroundImage = (Image)resources.GetObject("sideBar.BackgroundImage");
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel3);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel5);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.MaximumSize = new Size(163, 450);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(0, 450);
            sideBar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 20);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(17, 15);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(31, 29);
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddTurma);
            panel2.Location = new Point(3, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 35);
            panel2.TabIndex = 2;
            // 
            // btnAddTurma
            // 
            btnAddTurma.BackColor = Color.Black;
            btnAddTurma.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTurma.ForeColor = Color.White;
            btnAddTurma.Location = new Point(-18, -7);
            btnAddTurma.Name = "btnAddTurma";
            btnAddTurma.Size = new Size(199, 49);
            btnAddTurma.TabIndex = 2;
            btnAddTurma.Text = "Turma";
            btnAddTurma.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAddProfessor);
            panel3.Location = new Point(3, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 35);
            panel3.TabIndex = 2;
            // 
            // btnAddProfessor
            // 
            btnAddProfessor.BackColor = SystemColors.ActiveCaptionText;
            btnAddProfessor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProfessor.ForeColor = Color.White;
            btnAddProfessor.Location = new Point(-25, -20);
            btnAddProfessor.Name = "btnAddProfessor";
            btnAddProfessor.Size = new Size(212, 75);
            btnAddProfessor.TabIndex = 2;
            btnAddProfessor.Text = "Professor";
            btnAddProfessor.UseVisualStyleBackColor = false;
            btnAddProfessor.Click += btnAddProfessor_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAddAluno);
            panel4.Location = new Point(3, 147);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 42);
            panel4.TabIndex = 3;
            // 
            // btnAddAluno
            // 
            btnAddAluno.BackColor = SystemColors.ActiveCaptionText;
            btnAddAluno.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAluno.ForeColor = Color.White;
            btnAddAluno.Location = new Point(-19, -7);
            btnAddAluno.Name = "btnAddAluno";
            btnAddAluno.Size = new Size(197, 54);
            btnAddAluno.TabIndex = 2;
            btnAddAluno.Text = "Gerenciar Aluno";
            btnAddAluno.UseVisualStyleBackColor = false;
            btnAddAluno.Click += btnAddAluno_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAddDisciplina);
            panel5.Location = new Point(3, 195);
            panel5.Name = "panel5";
            panel5.Size = new Size(163, 47);
            panel5.TabIndex = 5;
            // 
            // btnAddDisciplina
            // 
            btnAddDisciplina.BackColor = SystemColors.ActiveCaptionText;
            btnAddDisciplina.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDisciplina.ForeColor = Color.White;
            btnAddDisciplina.Location = new Point(-20, -9);
            btnAddDisciplina.Name = "btnAddDisciplina";
            btnAddDisciplina.Size = new Size(207, 61);
            btnAddDisciplina.TabIndex = 13;
            btnAddDisciplina.Text = "Disciplinas";
            btnAddDisciplina.UseVisualStyleBackColor = false;
            btnAddDisciplina.Click += btnAddDisciplina_Click;
            // 
            // btnMenuOpen
            // 
            btnMenuOpen.BackColor = Color.Transparent;
            btnMenuOpen.Image = (Image)resources.GetObject("btnMenuOpen.Image");
            btnMenuOpen.Location = new Point(19, 14);
            btnMenuOpen.Name = "btnMenuOpen";
            btnMenuOpen.Size = new Size(31, 29);
            btnMenuOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenuOpen.TabIndex = 2;
            btnMenuOpen.TabStop = false;
            btnMenuOpen.Click += btnMenuOpen_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // labelSelectTurma
            // 
            labelSelectTurma.AutoSize = true;
            labelSelectTurma.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectTurma.Location = new Point(62, 104);
            labelSelectTurma.Name = "labelSelectTurma";
            labelSelectTurma.Size = new Size(155, 18);
            labelSelectTurma.TabIndex = 3;
            labelSelectTurma.Text = "Selecione uma turma";
            // 
            // selectTurma
            // 
            selectTurma.FormattingEnabled = true;
            selectTurma.Location = new Point(62, 125);
            selectTurma.Name = "selectTurma";
            selectTurma.Size = new Size(251, 23);
            selectTurma.TabIndex = 4;
            selectTurma.DropDown += selectTurma_DropDown;
            selectTurma.SelectedIndexChanged += selectTurma_SelectedIndexChanged;
            // 
            // selectDisciplina
            // 
            selectDisciplina.FormattingEnabled = true;
            selectDisciplina.Location = new Point(62, 197);
            selectDisciplina.Name = "selectDisciplina";
            selectDisciplina.Size = new Size(251, 23);
            selectDisciplina.TabIndex = 6;
            selectDisciplina.DropDown += selectDisciplina_DropDown;
            selectDisciplina.SelectedIndexChanged += selectDisciplina_SelectedIndexChanged;
            // 
            // labelSelectDisciplina
            // 
            labelSelectDisciplina.AutoSize = true;
            labelSelectDisciplina.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectDisciplina.Location = new Point(62, 176);
            labelSelectDisciplina.Name = "labelSelectDisciplina";
            labelSelectDisciplina.Size = new Size(182, 18);
            labelSelectDisciplina.TabIndex = 5;
            labelSelectDisciplina.Text = "Selecione uma disciplina";
            // 
            // labelResultSelectDisciplina
            // 
            labelResultSelectDisciplina.AutoSize = true;
            labelResultSelectDisciplina.ForeColor = Color.Red;
            labelResultSelectDisciplina.Location = new Point(62, 223);
            labelResultSelectDisciplina.Name = "labelResultSelectDisciplina";
            labelResultSelectDisciplina.Size = new Size(0, 15);
            labelResultSelectDisciplina.TabIndex = 7;
            labelResultSelectDisciplina.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelListviewAlunos
            // 
            labelListviewAlunos.AutoSize = true;
            labelListviewAlunos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelListviewAlunos.Location = new Point(460, 104);
            labelListviewAlunos.Name = "labelListviewAlunos";
            labelListviewAlunos.Size = new Size(113, 18);
            labelListviewAlunos.TabIndex = 8;
            labelListviewAlunos.Text = "Lista de alunos";
            // 
            // listviewAlunosMain
            // 
            listviewAlunosMain.BorderStyle = BorderStyle.FixedSingle;
            listviewAlunosMain.Columns.AddRange(new ColumnHeader[] { listviewAlunos, listviewMatricula, listviewPresente });
            listviewAlunosMain.FullRowSelect = true;
            listviewAlunosMain.GridLines = true;
            listviewAlunosMain.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewAlunosMain.Location = new Point(460, 125);
            listviewAlunosMain.Name = "listviewAlunosMain";
            listviewAlunosMain.Scrollable = false;
            listviewAlunosMain.Size = new Size(283, 257);
            listviewAlunosMain.TabIndex = 9;
            listviewAlunosMain.UseCompatibleStateImageBehavior = false;
            listviewAlunosMain.View = View.Details;
            // 
            // listviewAlunos
            // 
            listviewAlunos.Text = "Aluno";
            listviewAlunos.Width = 150;
            // 
            // listviewMatricula
            // 
            listviewMatricula.Text = "Matricula";
            listviewMatricula.Width = 90;
            // 
            // listviewPresente
            // 
            listviewPresente.Text = "Falta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 394);
            label2.Name = "label2";
            label2.Size = new Size(178, 15);
            label2.TabIndex = 10;
            label2.Text = "Marcar checkbox se aluno faltar!";
            // 
            // labelAllResponses
            // 
            labelAllResponses.AutoSize = true;
            labelAllResponses.BackColor = Color.Transparent;
            labelAllResponses.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAllResponses.ForeColor = Color.Red;
            labelAllResponses.Location = new Point(62, 364);
            labelAllResponses.Name = "labelAllResponses";
            labelAllResponses.Size = new Size(0, 18);
            labelAllResponses.TabIndex = 11;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateTime.Location = new Point(62, 309);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(78, 18);
            labelDateTime.TabIndex = 12;
            labelDateTime.Text = "Dia atual: ";
            // 
            // labelSelectedProfessor
            // 
            labelSelectedProfessor.AutoSize = true;
            labelSelectedProfessor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedProfessor.Location = new Point(62, 281);
            labelSelectedProfessor.Name = "labelSelectedProfessor";
            labelSelectedProfessor.Size = new Size(84, 18);
            labelSelectedProfessor.TabIndex = 13;
            labelSelectedProfessor.Text = "Professor: ";
            // 
            // HUDmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sideBar);
            Controls.Add(labelAllResponses);
            Controls.Add(label2);
            Controls.Add(listviewAlunosMain);
            Controls.Add(labelListviewAlunos);
            Controls.Add(selectTurma);
            Controls.Add(labelSelectTurma);
            Controls.Add(titleLabel);
            Controls.Add(btnMenuOpen);
            Controls.Add(labelResultSelectDisciplina);
            Controls.Add(selectDisciplina);
            Controls.Add(labelSelectDisciplina);
            Controls.Add(labelDateTime);
            Controls.Add(labelSelectedProfessor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "HUDmain";
            sideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenuOpen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private FlowLayoutPanel sideBar;
        private Panel panel2;
        private Button btnAddTurma;
        private Panel panel3;
        private Button btnAddProfessor;
        private Panel panel4;
        private Button btnAddAluno;
        private System.Windows.Forms.Timer sidebarTimer;
        private PictureBox btnMenuOpen;
        private Label labelSelectTurma;
        private ComboBox selectTurma;
        private Panel panel1;
        private Label label1;
        private PictureBox btnMenu;
        private ComboBox selectDisciplina;
        private Label labelSelectDisciplina;
        private Label labelResultSelectDisciplina;
        private Label labelListviewAlunos;
        private ListView listviewAlunosMain;
        private ColumnHeader listviewAlunos;
        private ColumnHeader listviewMatricula;
        private ColumnHeader listviewPresente;
        private Label label2;
        private Label labelAllResponses;
        private Panel panel5;
        private Button btnAddDisciplina;
        private Label labelDateTime;
        private Label labelSelectedProfessor;
    }
}