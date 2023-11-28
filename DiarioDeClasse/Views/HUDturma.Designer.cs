namespace DiarioDeClasse.Views
{
    partial class HUDturma
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
            labelPeriodoTurma = new Label();
            txtPeriodoTurma = new TextBox();
            labelNameTurma = new Label();
            txtNameTurma = new TextBox();
            labelTurnoTurma = new Label();
            textTurnoTurma = new TextBox();
            responseRemoveLabel = new Label();
            btnMostrarList = new Button();
            listviewTurmas = new ListView();
            listNomeTurma = new ColumnHeader();
            listPeriodoTurma = new ColumnHeader();
            listTurnoTurma = new ColumnHeader();
            resultLabel = new Label();
            label1 = new Label();
            listviewAlunos = new ListView();
            listAlunoName = new ColumnHeader();
            listAlunoMatricula = new ColumnHeader();
            listviewSelectedAlunos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnAddAlunoToTurma = new Button();
            btnAddSelectedDisciplina = new Button();
            listviewSelectedDisciplinas = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listviewDisciplinas = new ListView();
            listDisciplinaNome = new ColumnHeader();
            listDisciplinaSigla = new ColumnHeader();
            label2 = new Label();
            btnRemoveAlunoToTurma = new Button();
            btnRemoveSelectDisciplina = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnAddTurma = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelPeriodoTurma
            // 
            labelPeriodoTurma.AutoSize = true;
            labelPeriodoTurma.Location = new Point(232, 39);
            labelPeriodoTurma.Name = "labelPeriodoTurma";
            labelPeriodoTurma.Size = new Size(54, 15);
            labelPeriodoTurma.TabIndex = 26;
            labelPeriodoTurma.Text = "Periodo: ";
            // 
            // txtPeriodoTurma
            // 
            txtPeriodoTurma.Location = new Point(232, 60);
            txtPeriodoTurma.MaxLength = 1;
            txtPeriodoTurma.Name = "txtPeriodoTurma";
            txtPeriodoTurma.Size = new Size(82, 23);
            txtPeriodoTurma.TabIndex = 25;
            // 
            // labelNameTurma
            // 
            labelNameTurma.AutoSize = true;
            labelNameTurma.Location = new Point(43, 38);
            labelNameTurma.Name = "labelNameTurma";
            labelNameTurma.Size = new Size(78, 15);
            labelNameTurma.TabIndex = 24;
            labelNameTurma.Text = "Nome turma:";
            // 
            // txtNameTurma
            // 
            txtNameTurma.Location = new Point(43, 60);
            txtNameTurma.Name = "txtNameTurma";
            txtNameTurma.Size = new Size(183, 23);
            txtNameTurma.TabIndex = 23;
            // 
            // labelTurnoTurma
            // 
            labelTurnoTurma.AutoSize = true;
            labelTurnoTurma.Location = new Point(321, 38);
            labelTurnoTurma.Name = "labelTurnoTurma";
            labelTurnoTurma.Size = new Size(44, 15);
            labelTurnoTurma.TabIndex = 28;
            labelTurnoTurma.Text = "Turno: ";
            // 
            // textTurnoTurma
            // 
            textTurnoTurma.Location = new Point(321, 59);
            textTurnoTurma.MaxLength = 1;
            textTurnoTurma.Name = "textTurnoTurma";
            textTurnoTurma.Size = new Size(82, 23);
            textTurnoTurma.TabIndex = 27;
            // 
            // responseRemoveLabel
            // 
            responseRemoveLabel.AutoSize = true;
            responseRemoveLabel.Location = new Point(449, 23);
            responseRemoveLabel.Name = "responseRemoveLabel";
            responseRemoveLabel.Size = new Size(0, 15);
            responseRemoveLabel.TabIndex = 31;
            // 
            // btnMostrarList
            // 
            btnMostrarList.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrarList.Location = new Point(610, 101);
            btnMostrarList.Name = "btnMostrarList";
            btnMostrarList.Size = new Size(300, 23);
            btnMostrarList.TabIndex = 29;
            btnMostrarList.Text = "MOSTRAR";
            btnMostrarList.UseVisualStyleBackColor = true;
            btnMostrarList.Click += btnMostrarList_Click;
            // 
            // listviewTurmas
            // 
            listviewTurmas.Columns.AddRange(new ColumnHeader[] { listNomeTurma, listPeriodoTurma, listTurnoTurma });
            listviewTurmas.FullRowSelect = true;
            listviewTurmas.GridLines = true;
            listviewTurmas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewTurmas.Location = new Point(610, 120);
            listviewTurmas.Name = "listviewTurmas";
            listviewTurmas.Scrollable = false;
            listviewTurmas.Size = new Size(300, 239);
            listviewTurmas.TabIndex = 30;
            listviewTurmas.UseCompatibleStateImageBehavior = false;
            listviewTurmas.View = View.Details;
            listviewTurmas.Visible = false;
            // 
            // listNomeTurma
            // 
            listNomeTurma.Text = "Nome";
            listNomeTurma.Width = 180;
            // 
            // listPeriodoTurma
            // 
            listPeriodoTurma.Text = "Periodo";
            // 
            // listTurnoTurma
            // 
            listTurnoTurma.Text = "Turno";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(43, 86);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 122);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 24;
            label1.Text = "Selecione alunos:";
            // 
            // listviewAlunos
            // 
            listviewAlunos.Columns.AddRange(new ColumnHeader[] { listAlunoName, listAlunoMatricula });
            listviewAlunos.FullRowSelect = true;
            listviewAlunos.GridLines = true;
            listviewAlunos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewAlunos.Location = new Point(43, 140);
            listviewAlunos.MultiSelect = false;
            listviewAlunos.Name = "listviewAlunos";
            listviewAlunos.Size = new Size(203, 156);
            listviewAlunos.TabIndex = 33;
            listviewAlunos.UseCompatibleStateImageBehavior = false;
            listviewAlunos.View = View.Details;
            // 
            // listAlunoName
            // 
            listAlunoName.Text = "Nome";
            listAlunoName.Width = 110;
            // 
            // listAlunoMatricula
            // 
            listAlunoMatricula.Text = "Matricula";
            listAlunoMatricula.TextAlign = HorizontalAlignment.Center;
            listAlunoMatricula.Width = 70;
            // 
            // listviewSelectedAlunos
            // 
            listviewSelectedAlunos.AllowColumnReorder = true;
            listviewSelectedAlunos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listviewSelectedAlunos.FullRowSelect = true;
            listviewSelectedAlunos.GridLines = true;
            listviewSelectedAlunos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewSelectedAlunos.Location = new Point(351, 140);
            listviewSelectedAlunos.MultiSelect = false;
            listviewSelectedAlunos.Name = "listviewSelectedAlunos";
            listviewSelectedAlunos.Size = new Size(185, 156);
            listviewSelectedAlunos.TabIndex = 35;
            listviewSelectedAlunos.UseCompatibleStateImageBehavior = false;
            listviewSelectedAlunos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Matricula";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 70;
            // 
            // btnAddAlunoToTurma
            // 
            btnAddAlunoToTurma.Location = new Point(261, 188);
            btnAddAlunoToTurma.Name = "btnAddAlunoToTurma";
            btnAddAlunoToTurma.Size = new Size(75, 23);
            btnAddAlunoToTurma.TabIndex = 36;
            btnAddAlunoToTurma.Text = "=>";
            btnAddAlunoToTurma.UseVisualStyleBackColor = true;
            btnAddAlunoToTurma.Click += btnAddAlunoToTurma_Click;
            // 
            // btnAddSelectedDisciplina
            // 
            btnAddSelectedDisciplina.Location = new Point(261, 368);
            btnAddSelectedDisciplina.Name = "btnAddSelectedDisciplina";
            btnAddSelectedDisciplina.Size = new Size(75, 23);
            btnAddSelectedDisciplina.TabIndex = 40;
            btnAddSelectedDisciplina.Text = "=>";
            btnAddSelectedDisciplina.UseVisualStyleBackColor = true;
            btnAddSelectedDisciplina.Click += btnAddSelectedDisciplina_Click;
            // 
            // listviewSelectedDisciplinas
            // 
            listviewSelectedDisciplinas.AllowColumnReorder = true;
            listviewSelectedDisciplinas.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listviewSelectedDisciplinas.FullRowSelect = true;
            listviewSelectedDisciplinas.GridLines = true;
            listviewSelectedDisciplinas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewSelectedDisciplinas.Location = new Point(351, 338);
            listviewSelectedDisciplinas.MultiSelect = false;
            listviewSelectedDisciplinas.Name = "listviewSelectedDisciplinas";
            listviewSelectedDisciplinas.Size = new Size(185, 106);
            listviewSelectedDisciplinas.TabIndex = 39;
            listviewSelectedDisciplinas.UseCompatibleStateImageBehavior = false;
            listviewSelectedDisciplinas.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nome";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Sigla";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 70;
            // 
            // listviewDisciplinas
            // 
            listviewDisciplinas.Columns.AddRange(new ColumnHeader[] { listDisciplinaNome, listDisciplinaSigla });
            listviewDisciplinas.FullRowSelect = true;
            listviewDisciplinas.GridLines = true;
            listviewDisciplinas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewDisciplinas.Location = new Point(43, 338);
            listviewDisciplinas.MultiSelect = false;
            listviewDisciplinas.Name = "listviewDisciplinas";
            listviewDisciplinas.Size = new Size(203, 106);
            listviewDisciplinas.TabIndex = 38;
            listviewDisciplinas.UseCompatibleStateImageBehavior = false;
            listviewDisciplinas.View = View.Details;
            // 
            // listDisciplinaNome
            // 
            listDisciplinaNome.Text = "Nome";
            listDisciplinaNome.Width = 110;
            // 
            // listDisciplinaSigla
            // 
            listDisciplinaSigla.Text = "Sigla";
            listDisciplinaSigla.TextAlign = HorizontalAlignment.Center;
            listDisciplinaSigla.Width = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 320);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 37;
            label2.Text = "Selecione disciplinas:";
            // 
            // btnRemoveAlunoToTurma
            // 
            btnRemoveAlunoToTurma.Location = new Point(261, 217);
            btnRemoveAlunoToTurma.Name = "btnRemoveAlunoToTurma";
            btnRemoveAlunoToTurma.Size = new Size(75, 23);
            btnRemoveAlunoToTurma.TabIndex = 41;
            btnRemoveAlunoToTurma.Text = "<=";
            btnRemoveAlunoToTurma.UseVisualStyleBackColor = true;
            btnRemoveAlunoToTurma.Click += btnRemoveAlunoToTurma_Click;
            // 
            // btnRemoveSelectDisciplina
            // 
            btnRemoveSelectDisciplina.Location = new Point(261, 397);
            btnRemoveSelectDisciplina.Name = "btnRemoveSelectDisciplina";
            btnRemoveSelectDisciplina.Size = new Size(75, 23);
            btnRemoveSelectDisciplina.TabIndex = 42;
            btnRemoveSelectDisciplina.Text = "<=";
            btnRemoveSelectDisciplina.UseVisualStyleBackColor = true;
            btnRemoveSelectDisciplina.Click += btnRemoveSelectDisciplina_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(572, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1, 446);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(610, 67);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 44;
            label3.Text = "Lista disciplinas";
            // 
            // btnAddTurma
            // 
            btnAddTurma.Location = new Point(217, 466);
            btnAddTurma.Name = "btnAddTurma";
            btnAddTurma.Size = new Size(157, 43);
            btnAddTurma.TabIndex = 45;
            btnAddTurma.Text = "ADICIONAR";
            btnAddTurma.UseVisualStyleBackColor = true;
            btnAddTurma.Click += btnAddTurma_Click;
            // 
            // HUDturma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 546);
            Controls.Add(btnAddTurma);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnRemoveSelectDisciplina);
            Controls.Add(btnRemoveAlunoToTurma);
            Controls.Add(btnAddSelectedDisciplina);
            Controls.Add(listviewSelectedDisciplinas);
            Controls.Add(listviewDisciplinas);
            Controls.Add(label2);
            Controls.Add(btnAddAlunoToTurma);
            Controls.Add(listviewSelectedAlunos);
            Controls.Add(listviewAlunos);
            Controls.Add(resultLabel);
            Controls.Add(responseRemoveLabel);
            Controls.Add(btnMostrarList);
            Controls.Add(listviewTurmas);
            Controls.Add(labelTurnoTurma);
            Controls.Add(textTurnoTurma);
            Controls.Add(labelPeriodoTurma);
            Controls.Add(txtPeriodoTurma);
            Controls.Add(label1);
            Controls.Add(labelNameTurma);
            Controls.Add(txtNameTurma);
            Name = "HUDturma";
            Text = "HUDturma";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPeriodoTurma;
        private TextBox txtPeriodoTurma;
        private Label labelNameTurma;
        private TextBox txtNameTurma;
        private Label labelTurnoTurma;
        private TextBox textTurnoTurma;
        private Label responseRemoveLabel;
        private Button btnMostrarList;
        private ListView listviewTurmas;
        private ColumnHeader listNomeTurma;
        private ColumnHeader listPeriodoTurma;
        private ColumnHeader listTurnoTurma;
        public Label resultLabel;
        private Label label1;
        private ListView listviewAlunos;
        private ColumnHeader listAlunoName;
        private ColumnHeader listAlunoMatricula;
        private ListView listviewSelectedAlunos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnAddAlunoToTurma;
        private Button btnAddSelectedDisciplina;
        private ListView listviewSelectedDisciplinas;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listviewDisciplinas;
        private ColumnHeader listDisciplinaNome;
        private ColumnHeader listDisciplinaSigla;
        private Label label2;
        private Button btnRemoveAlunoToTurma;
        private Button btnRemoveSelectDisciplina;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnAddTurma;
    }
}