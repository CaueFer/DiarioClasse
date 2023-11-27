namespace DiarioDeClasse
{
    partial class HUDaluno
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
            btnAddAluno = new Button();
            txtName = new TextBox();
            listBtn = new Button();
            listAlunos = new ListView();
            listNome = new ColumnHeader();
            listMatricula = new ColumnHeader();
            labelName = new Label();
            btnRemoveAluno = new Button();
            resultLabel = new Label();
            responseRemoveLabel = new Label();
            SuspendLayout();
            // 
            // btnAddAluno
            // 
            btnAddAluno.Location = new Point(55, 114);
            btnAddAluno.Name = "btnAddAluno";
            btnAddAluno.Size = new Size(70, 29);
            btnAddAluno.TabIndex = 0;
            btnAddAluno.Text = "Adicionar";
            btnAddAluno.UseVisualStyleBackColor = true;
            btnAddAluno.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(55, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // listBtn
            // 
            listBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBtn.Location = new Point(37, 180);
            listBtn.Name = "listBtn";
            listBtn.Size = new Size(243, 23);
            listBtn.TabIndex = 3;
            listBtn.Text = "MOSTRAR";
            listBtn.UseVisualStyleBackColor = true;
            listBtn.Click += listBtn_Click;
            // 
            // listAlunos
            // 
            listAlunos.Columns.AddRange(new ColumnHeader[] { listNome, listMatricula });
            listAlunos.FullRowSelect = true;
            listAlunos.GridLines = true;
            listAlunos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listAlunos.Location = new Point(37, 199);
            listAlunos.Name = "listAlunos";
            listAlunos.Scrollable = false;
            listAlunos.Size = new Size(243, 197);
            listAlunos.TabIndex = 4;
            listAlunos.UseCompatibleStateImageBehavior = false;
            listAlunos.View = View.Details;
            listAlunos.Visible = false;
            listAlunos.SelectedIndexChanged += listAlunos_SelectedIndexChanged;
            // 
            // listNome
            // 
            listNome.Text = "Nome";
            listNome.Width = 120;
            // 
            // listMatricula
            // 
            listMatricula.Text = "Matricula";
            listMatricula.Width = 120;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(55, 31);
            labelName.Name = "labelName";
            labelName.Size = new Size(76, 15);
            labelName.TabIndex = 5;
            labelName.Text = "Nome aluno:";
            // 
            // btnRemoveAluno
            // 
            btnRemoveAluno.Location = new Point(168, 117);
            btnRemoveAluno.Name = "btnRemoveAluno";
            btnRemoveAluno.Size = new Size(70, 26);
            btnRemoveAluno.TabIndex = 6;
            btnRemoveAluno.Text = "Remover";
            btnRemoveAluno.UseVisualStyleBackColor = true;
            btnRemoveAluno.Click += removeBtn_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(56, 86);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 7;
            // 
            // responseRemoveLabel
            // 
            responseRemoveLabel.AutoSize = true;
            responseRemoveLabel.Location = new Point(37, 162);
            responseRemoveLabel.Name = "responseRemoveLabel";
            responseRemoveLabel.Size = new Size(0, 15);
            responseRemoveLabel.TabIndex = 8;
            responseRemoveLabel.Click += responseRemoveLabel_Click;
            // 
            // HUDaluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 450);
            Controls.Add(responseRemoveLabel);
            Controls.Add(resultLabel);
            Controls.Add(btnRemoveAluno);
            Controls.Add(labelName);
            Controls.Add(listBtn);
            Controls.Add(listAlunos);
            Controls.Add(txtName);
            Controls.Add(btnAddAluno);
            Name = "HUDaluno";
            Text = "HUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAluno;
        private TextBox txtName;
        private Button listBtn;
        private ListView listAlunos;
        private ColumnHeader listNome;
        private ColumnHeader listMatricula;
        private Label labelName;
        private Button btnRemoveAluno;
        public Label resultLabel;
        private Label responseRemoveLabel;
    }
}