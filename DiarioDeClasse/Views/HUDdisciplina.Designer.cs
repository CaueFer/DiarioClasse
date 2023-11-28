namespace DiarioDeClasse.Views
{
    partial class HUDdisciplina
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
            responseRemoveLabel = new Label();
            resultLabel = new Label();
            btnRemoveProfessor = new Button();
            labelNameDisciplina = new Label();
            btnMostrarList = new Button();
            listviewDisciplinas = new ListView();
            listDisciplinaNome = new ColumnHeader();
            listProfessor = new ColumnHeader();
            listDisciplinaSigla = new ColumnHeader();
            txtNameDisciplina = new TextBox();
            btnAddDisciplina = new Button();
            label1 = new Label();
            label2 = new Label();
            selectProfessor = new ComboBox();
            labelSiglaDisciplina = new Label();
            txtSiglaDisciplina = new TextBox();
            selectDisciplinaDia = new ComboBox();
            labelSelectDia = new Label();
            SuspendLayout();
            // 
            // responseRemoveLabel
            // 
            responseRemoveLabel.AutoSize = true;
            responseRemoveLabel.Location = new Point(375, 25);
            responseRemoveLabel.Name = "responseRemoveLabel";
            responseRemoveLabel.Size = new Size(0, 15);
            responseRemoveLabel.TabIndex = 16;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(39, 90);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 15;
            // 
            // btnRemoveProfessor
            // 
            btnRemoveProfessor.Location = new Point(38, 188);
            btnRemoveProfessor.Name = "btnRemoveProfessor";
            btnRemoveProfessor.Size = new Size(288, 26);
            btnRemoveProfessor.TabIndex = 14;
            btnRemoveProfessor.Text = "Remover";
            btnRemoveProfessor.UseVisualStyleBackColor = true;
            btnRemoveProfessor.Click += btnRemoveProfessor_Click;
            // 
            // labelNameDisciplina
            // 
            labelNameDisciplina.AutoSize = true;
            labelNameDisciplina.Location = new Point(38, 40);
            labelNameDisciplina.Name = "labelNameDisciplina";
            labelNameDisciplina.Size = new Size(96, 15);
            labelNameDisciplina.TabIndex = 13;
            labelNameDisciplina.Text = "Nome disciplina:";
            // 
            // btnMostrarList
            // 
            btnMostrarList.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrarList.Location = new Point(375, 43);
            btnMostrarList.Name = "btnMostrarList";
            btnMostrarList.Size = new Size(282, 23);
            btnMostrarList.TabIndex = 11;
            btnMostrarList.Text = "MOSTRAR";
            btnMostrarList.UseVisualStyleBackColor = true;
            btnMostrarList.Click += btnMostrarList_Click;
            // 
            // listviewDisciplinas
            // 
            listviewDisciplinas.Columns.AddRange(new ColumnHeader[] { listDisciplinaNome, listProfessor, listDisciplinaSigla });
            listviewDisciplinas.FullRowSelect = true;
            listviewDisciplinas.GridLines = true;
            listviewDisciplinas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewDisciplinas.Location = new Point(375, 62);
            listviewDisciplinas.Name = "listviewDisciplinas";
            listviewDisciplinas.Scrollable = false;
            listviewDisciplinas.Size = new Size(282, 187);
            listviewDisciplinas.TabIndex = 12;
            listviewDisciplinas.UseCompatibleStateImageBehavior = false;
            listviewDisciplinas.View = View.Details;
            listviewDisciplinas.Visible = false;
            // 
            // listDisciplinaNome
            // 
            listDisciplinaNome.Text = "Nome";
            listDisciplinaNome.Width = 120;
            // 
            // listProfessor
            // 
            listProfessor.Text = "Professor";
            listProfessor.Width = 120;
            // 
            // listDisciplinaSigla
            // 
            listDisciplinaSigla.Text = "Sigla";
            listDisciplinaSigla.Width = 40;
            // 
            // txtNameDisciplina
            // 
            txtNameDisciplina.Location = new Point(38, 62);
            txtNameDisciplina.Name = "txtNameDisciplina";
            txtNameDisciplina.Size = new Size(183, 23);
            txtNameDisciplina.TabIndex = 10;
            // 
            // btnAddDisciplina
            // 
            btnAddDisciplina.Location = new Point(39, 220);
            btnAddDisciplina.Name = "btnAddDisciplina";
            btnAddDisciplina.Size = new Size(287, 29);
            btnAddDisciplina.TabIndex = 9;
            btnAddDisciplina.Text = "Adicionar";
            btnAddDisciplina.UseVisualStyleBackColor = true;
            btnAddDisciplina.Click += btnAddDisciplina_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 173);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 122);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 18;
            label2.Text = "Selecione um professor:";
            // 
            // selectProfessor
            // 
            selectProfessor.FormattingEnabled = true;
            selectProfessor.Location = new Point(38, 140);
            selectProfessor.Name = "selectProfessor";
            selectProfessor.Size = new Size(183, 23);
            selectProfessor.TabIndex = 20;
            selectProfessor.DropDown += selectProfessor_DropDown;
            selectProfessor.SelectedIndexChanged += selectProfessor_SelectedIndexChanged;
            // 
            // labelSiglaDisciplina
            // 
            labelSiglaDisciplina.AutoSize = true;
            labelSiglaDisciplina.Location = new Point(227, 41);
            labelSiglaDisciplina.Name = "labelSiglaDisciplina";
            labelSiglaDisciplina.Size = new Size(35, 15);
            labelSiglaDisciplina.TabIndex = 22;
            labelSiglaDisciplina.Text = "Sigla:";
            // 
            // txtSiglaDisciplina
            // 
            txtSiglaDisciplina.Location = new Point(227, 62);
            txtSiglaDisciplina.MaxLength = 3;
            txtSiglaDisciplina.Name = "txtSiglaDisciplina";
            txtSiglaDisciplina.Size = new Size(82, 23);
            txtSiglaDisciplina.TabIndex = 21;
            // 
            // selectDisciplinaDia
            // 
            selectDisciplinaDia.FormattingEnabled = true;
            selectDisciplinaDia.Location = new Point(227, 140);
            selectDisciplinaDia.Name = "selectDisciplinaDia";
            selectDisciplinaDia.Size = new Size(82, 23);
            selectDisciplinaDia.TabIndex = 23;
            // 
            // labelSelectDia
            // 
            labelSelectDia.AutoSize = true;
            labelSelectDia.Location = new Point(225, 122);
            labelSelectDia.Name = "labelSelectDia";
            labelSelectDia.Size = new Size(79, 15);
            labelSelectDia.TabIndex = 24;
            labelSelectDia.Text = "Selecione dia:";
            // 
            // HUDdisciplina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 423);
            Controls.Add(labelSelectDia);
            Controls.Add(selectDisciplinaDia);
            Controls.Add(labelSiglaDisciplina);
            Controls.Add(txtSiglaDisciplina);
            Controls.Add(selectProfessor);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(responseRemoveLabel);
            Controls.Add(resultLabel);
            Controls.Add(btnRemoveProfessor);
            Controls.Add(labelNameDisciplina);
            Controls.Add(btnMostrarList);
            Controls.Add(listviewDisciplinas);
            Controls.Add(txtNameDisciplina);
            Controls.Add(btnAddDisciplina);
            Name = "HUDdisciplina";
            Text = "HUDdisciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label responseRemoveLabel;
        public Label resultLabel;
        private Button btnRemoveProfessor;
        private Label labelNameDisciplina;
        private Button btnMostrarList;
        private ListView listviewDisciplinas;
        private ColumnHeader listDisciplinaNome;
        private ColumnHeader listProfessor;
        private TextBox txtNameDisciplina;
        private Button btnAddDisciplina;
        public Label label1;
        private Label label2;
        private ComboBox selectProfessor;
        private Label labelSiglaDisciplina;
        private TextBox txtSiglaDisciplina;
        private ComboBox selectDisciplinaDia;
        private Label labelSelectDia;
        private ColumnHeader listDisciplinaSigla;
    }
}