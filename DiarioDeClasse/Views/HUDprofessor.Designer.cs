namespace DiarioDeClasse.Views
{
    partial class HUDprofessor
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
            labelNameProfessor = new Label();
            btnListProfessor = new Button();
            listviewProfessor = new ListView();
            listNome = new ColumnHeader();
            listMatricula = new ColumnHeader();
            txtNameProfessor = new TextBox();
            btnAddProfessor = new Button();
            SuspendLayout();
            // 
            // responseRemoveLabel
            // 
            responseRemoveLabel.AutoSize = true;
            responseRemoveLabel.Location = new Point(35, 165);
            responseRemoveLabel.Name = "responseRemoveLabel";
            responseRemoveLabel.Size = new Size(0, 15);
            responseRemoveLabel.TabIndex = 16;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(54, 89);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 15;
            // 
            // btnRemoveProfessor
            // 
            btnRemoveProfessor.Location = new Point(166, 120);
            btnRemoveProfessor.Name = "btnRemoveProfessor";
            btnRemoveProfessor.Size = new Size(70, 26);
            btnRemoveProfessor.TabIndex = 14;
            btnRemoveProfessor.Text = "Remover";
            btnRemoveProfessor.UseVisualStyleBackColor = true;
            btnRemoveProfessor.Click += btnRemoveProfessor_Click;
            // 
            // labelNameProfessor
            // 
            labelNameProfessor.AutoSize = true;
            labelNameProfessor.Location = new Point(54, 40);
            labelNameProfessor.Name = "labelNameProfessor";
            labelNameProfessor.Size = new Size(95, 15);
            labelNameProfessor.TabIndex = 13;
            labelNameProfessor.Text = "Nome professor:";
            // 
            // btnListProfessor
            // 
            btnListProfessor.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnListProfessor.Location = new Point(35, 183);
            btnListProfessor.Name = "btnListProfessor";
            btnListProfessor.Size = new Size(243, 23);
            btnListProfessor.TabIndex = 11;
            btnListProfessor.Text = "MOSTRAR";
            btnListProfessor.UseVisualStyleBackColor = true;
            btnListProfessor.Click += btnListProfessor_Click;
            // 
            // listviewProfessor
            // 
            listviewProfessor.Columns.AddRange(new ColumnHeader[] { listNome, listMatricula });
            listviewProfessor.FullRowSelect = true;
            listviewProfessor.GridLines = true;
            listviewProfessor.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewProfessor.Location = new Point(35, 202);
            listviewProfessor.Name = "listviewProfessor";
            listviewProfessor.Scrollable = false;
            listviewProfessor.Size = new Size(243, 197);
            listviewProfessor.TabIndex = 12;
            listviewProfessor.UseCompatibleStateImageBehavior = false;
            listviewProfessor.View = View.Details;
            listviewProfessor.Visible = false;
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
            // txtNameProfessor
            // 
            txtNameProfessor.Location = new Point(53, 61);
            txtNameProfessor.Name = "txtNameProfessor";
            txtNameProfessor.Size = new Size(183, 23);
            txtNameProfessor.TabIndex = 10;
            // 
            // btnAddProfessor
            // 
            btnAddProfessor.Location = new Point(53, 117);
            btnAddProfessor.Name = "btnAddProfessor";
            btnAddProfessor.Size = new Size(70, 29);
            btnAddProfessor.TabIndex = 9;
            btnAddProfessor.Text = "Adicionar";
            btnAddProfessor.UseVisualStyleBackColor = true;
            btnAddProfessor.Click += btnAddProfessor_Click;
            // 
            // HUDprofessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 450);
            Controls.Add(responseRemoveLabel);
            Controls.Add(resultLabel);
            Controls.Add(btnRemoveProfessor);
            Controls.Add(labelNameProfessor);
            Controls.Add(btnListProfessor);
            Controls.Add(listviewProfessor);
            Controls.Add(txtNameProfessor);
            Controls.Add(btnAddProfessor);
            Name = "HUDprofessor";
            Text = "HUDprofessor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label responseRemoveLabel;
        public Label resultLabel;
        private Button btnRemoveProfessor;
        private Label labelNameProfessor;
        private Button btnListProfessor;
        private ListView listviewProfessor;
        private ColumnHeader listNome;
        private ColumnHeader listMatricula;
        private TextBox txtNameProfessor;
        private Button btnAddProfessor;
    }
}