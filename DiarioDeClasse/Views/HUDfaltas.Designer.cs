namespace DiarioDeClasse.Views
{
    partial class HUDfaltas
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
            labelAllResponses = new Label();
            selectTurmaFaltas = new ComboBox();
            labelSelectTurma = new Label();
            labelResultSelectDisciplina = new Label();
            selectDisciplinaFaltas = new ComboBox();
            labelSelectDisciplina = new Label();
            labelDateTime = new Label();
            listviewAlunosMainFaltas = new ListView();
            listviewAlunos = new ColumnHeader();
            listviewMatricula = new ColumnHeader();
            labelListviewAlunos = new Label();
            btnAddFalta = new Button();
            SuspendLayout();
            // 
            // labelAllResponses
            // 
            labelAllResponses.AutoSize = true;
            labelAllResponses.BackColor = Color.Transparent;
            labelAllResponses.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAllResponses.ForeColor = Color.Red;
            labelAllResponses.Location = new Point(46, 345);
            labelAllResponses.Name = "labelAllResponses";
            labelAllResponses.Size = new Size(0, 18);
            labelAllResponses.TabIndex = 19;
            // 
            // selectTurmaFaltas
            // 
            selectTurmaFaltas.FormattingEnabled = true;
            selectTurmaFaltas.Location = new Point(46, 68);
            selectTurmaFaltas.Name = "selectTurmaFaltas";
            selectTurmaFaltas.Size = new Size(251, 23);
            selectTurmaFaltas.TabIndex = 15;
            selectTurmaFaltas.DropDown += selectTurmaFaltas_DropDown;
            selectTurmaFaltas.SelectedIndexChanged += selectTurmaFaltas_SelectedIndexChanged;
            // 
            // labelSelectTurma
            // 
            labelSelectTurma.AutoSize = true;
            labelSelectTurma.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectTurma.Location = new Point(46, 47);
            labelSelectTurma.Name = "labelSelectTurma";
            labelSelectTurma.Size = new Size(155, 18);
            labelSelectTurma.TabIndex = 14;
            labelSelectTurma.Text = "Selecione uma turma";
            // 
            // labelResultSelectDisciplina
            // 
            labelResultSelectDisciplina.AutoSize = true;
            labelResultSelectDisciplina.ForeColor = Color.Red;
            labelResultSelectDisciplina.Location = new Point(46, 166);
            labelResultSelectDisciplina.Name = "labelResultSelectDisciplina";
            labelResultSelectDisciplina.Size = new Size(0, 15);
            labelResultSelectDisciplina.TabIndex = 18;
            labelResultSelectDisciplina.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectDisciplinaFaltas
            // 
            selectDisciplinaFaltas.FormattingEnabled = true;
            selectDisciplinaFaltas.Location = new Point(46, 140);
            selectDisciplinaFaltas.Name = "selectDisciplinaFaltas";
            selectDisciplinaFaltas.Size = new Size(251, 23);
            selectDisciplinaFaltas.TabIndex = 17;
            selectDisciplinaFaltas.DropDown += selectDisciplinaFaltas_DropDown;
            selectDisciplinaFaltas.SelectedIndexChanged += selectDisciplinaFaltas_SelectedIndexChanged;
            // 
            // labelSelectDisciplina
            // 
            labelSelectDisciplina.AutoSize = true;
            labelSelectDisciplina.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectDisciplina.Location = new Point(46, 119);
            labelSelectDisciplina.Name = "labelSelectDisciplina";
            labelSelectDisciplina.Size = new Size(182, 18);
            labelSelectDisciplina.TabIndex = 16;
            labelSelectDisciplina.Text = "Selecione uma disciplina";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateTime.Location = new Point(46, 298);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(78, 18);
            labelDateTime.TabIndex = 20;
            labelDateTime.Text = "Dia atual: ";
            // 
            // listviewAlunosMainFaltas
            // 
            listviewAlunosMainFaltas.BorderStyle = BorderStyle.FixedSingle;
            listviewAlunosMainFaltas.Columns.AddRange(new ColumnHeader[] { listviewAlunos, listviewMatricula });
            listviewAlunosMainFaltas.FullRowSelect = true;
            listviewAlunosMainFaltas.GridLines = true;
            listviewAlunosMainFaltas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewAlunosMainFaltas.Location = new Point(350, 68);
            listviewAlunosMainFaltas.MultiSelect = false;
            listviewAlunosMainFaltas.Name = "listviewAlunosMainFaltas";
            listviewAlunosMainFaltas.Scrollable = false;
            listviewAlunosMainFaltas.Size = new Size(240, 257);
            listviewAlunosMainFaltas.TabIndex = 22;
            listviewAlunosMainFaltas.UseCompatibleStateImageBehavior = false;
            listviewAlunosMainFaltas.View = View.Details;
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
            // labelListviewAlunos
            // 
            labelListviewAlunos.AutoSize = true;
            labelListviewAlunos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelListviewAlunos.Location = new Point(350, 47);
            labelListviewAlunos.Name = "labelListviewAlunos";
            labelListviewAlunos.Size = new Size(113, 18);
            labelListviewAlunos.TabIndex = 21;
            labelListviewAlunos.Text = "Lista de alunos";
            // 
            // btnAddFalta
            // 
            btnAddFalta.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFalta.Location = new Point(350, 345);
            btnAddFalta.Name = "btnAddFalta";
            btnAddFalta.Size = new Size(244, 39);
            btnAddFalta.TabIndex = 23;
            btnAddFalta.Text = "Adicionar falta";
            btnAddFalta.UseVisualStyleBackColor = true;
            // 
            // HUDfaltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 411);
            Controls.Add(btnAddFalta);
            Controls.Add(listviewAlunosMainFaltas);
            Controls.Add(labelListviewAlunos);
            Controls.Add(labelAllResponses);
            Controls.Add(selectTurmaFaltas);
            Controls.Add(labelSelectTurma);
            Controls.Add(labelResultSelectDisciplina);
            Controls.Add(selectDisciplinaFaltas);
            Controls.Add(labelSelectDisciplina);
            Controls.Add(labelDateTime);
            Name = "HUDfaltas";
            Text = "HUDfaltas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAllResponses;
        private ComboBox selectTurmaFaltas;
        private Label labelSelectTurma;
        private Label labelResultSelectDisciplina;
        private ComboBox selectDisciplinaFaltas;
        private Label labelSelectDisciplina;
        private Label labelDateTime;
        private ListView listviewAlunosMainFaltas;
        private ColumnHeader listviewAlunos;
        private ColumnHeader listviewMatricula;
        private Label labelListviewAlunos;
        private Button btnAddFalta;
    }
}