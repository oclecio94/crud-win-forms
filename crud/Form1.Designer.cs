namespace crud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgPessoa = new DataGridView();
            ID = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            Nome = new Label();
            txtCpf = new TextBox();
            CPF = new Label();
            txtEmail = new TextBox();
            Email = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            SuspendLayout();
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(12, 224);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.Size = new Size(776, 214);
            dgPessoa.TabIndex = 0;
            dgPessoa.CellClick += dgPessoa_CellClick;
            dgPessoa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(12, 18);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 1;
            ID.Text = "ID";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(12, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(263, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(12, 90);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(263, 23);
            txtNome.TabIndex = 4;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(12, 72);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 3;
            Nome.Text = "Nome";
            // 
            // txtCpf
            // 
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Location = new Point(12, 140);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(263, 23);
            txtCpf.TabIndex = 6;
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Location = new Point(12, 122);
            CPF.Name = "CPF";
            CPF.Size = new Size(28, 15);
            CPF.TabIndex = 5;
            CPF.Text = "CPF";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(12, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 23);
            txtEmail.TabIndex = 8;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(12, 177);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 7;
            Email.Text = "Email";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(323, 195);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(404, 195);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(485, 195);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(566, 195);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtEmail);
            Controls.Add(Email);
            Controls.Add(txtCpf);
            Controls.Add(CPF);
            Controls.Add(txtNome);
            Controls.Add(Nome);
            Controls.Add(txtId);
            Controls.Add(ID);
            Controls.Add(dgPessoa);
            Name = "Form1";
            Text = "CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPessoa;
        private Label ID;
        private TextBox txtId;
        private TextBox txtNome;
        private Label Nome;
        private TextBox txtCpf;
        private Label CPF;
        private TextBox txtEmail;
        private Label Email;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnLimpar;
    }
}
