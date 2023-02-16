namespace GenericTrue
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNascimento = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lboCodigo = new System.Windows.Forms.ListBox();
            this.lboNome = new System.Windows.Forms.ListBox();
            this.lboCPF = new System.Windows.Forms.ListBox();
            this.lboEndereco = new System.Windows.Forms.ListBox();
            this.lboNascimento = new System.Windows.Forms.ListBox();
            this.lboTelefone = new System.Windows.Forms.ListBox();
            this.lboEmail = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(152, 24);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(47, 20);
            this.txbCodigo.TabIndex = 0;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(152, 62);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(152, 105);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 2;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(152, 148);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(100, 20);
            this.txbEndereco.TabIndex = 3;
            // 
            // txbNascimento
            // 
            this.txbNascimento.Location = new System.Drawing.Point(403, 60);
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(100, 20);
            this.txbNascimento.TabIndex = 4;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(403, 103);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 5;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(403, 146);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Saint Carell PERSONAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(528, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 37);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lboCodigo
            // 
            this.lboCodigo.FormattingEnabled = true;
            this.lboCodigo.Location = new System.Drawing.Point(60, 174);
            this.lboCodigo.Name = "lboCodigo";
            this.lboCodigo.Size = new System.Drawing.Size(39, 264);
            this.lboCodigo.TabIndex = 8;
            this.lboCodigo.SelectedIndexChanged += new System.EventHandler(this.lboCodigo_SelectedIndexChanged);
            // 
            // lboNome
            // 
            this.lboNome.FormattingEnabled = true;
            this.lboNome.Location = new System.Drawing.Point(105, 174);
            this.lboNome.Name = "lboNome";
            this.lboNome.Size = new System.Drawing.Size(120, 264);
            this.lboNome.TabIndex = 9;
            this.lboNome.SelectedIndexChanged += new System.EventHandler(this.lboNome_SelectedIndexChanged);
            // 
            // lboCPF
            // 
            this.lboCPF.FormattingEnabled = true;
            this.lboCPF.Location = new System.Drawing.Point(231, 174);
            this.lboCPF.Name = "lboCPF";
            this.lboCPF.Size = new System.Drawing.Size(79, 264);
            this.lboCPF.TabIndex = 10;
            this.lboCPF.SelectedIndexChanged += new System.EventHandler(this.lboCPF_SelectedIndexChanged);
            // 
            // lboEndereco
            // 
            this.lboEndereco.FormattingEnabled = true;
            this.lboEndereco.Location = new System.Drawing.Point(316, 174);
            this.lboEndereco.Name = "lboEndereco";
            this.lboEndereco.Size = new System.Drawing.Size(161, 264);
            this.lboEndereco.TabIndex = 11;
            this.lboEndereco.SelectedIndexChanged += new System.EventHandler(this.lboEndereco_SelectedIndexChanged);
            // 
            // lboNascimento
            // 
            this.lboNascimento.FormattingEnabled = true;
            this.lboNascimento.Location = new System.Drawing.Point(483, 174);
            this.lboNascimento.Name = "lboNascimento";
            this.lboNascimento.Size = new System.Drawing.Size(120, 264);
            this.lboNascimento.TabIndex = 12;
            this.lboNascimento.SelectedIndexChanged += new System.EventHandler(this.lboNascimento_SelectedIndexChanged);
            // 
            // lboTelefone
            // 
            this.lboTelefone.FormattingEnabled = true;
            this.lboTelefone.Location = new System.Drawing.Point(609, 174);
            this.lboTelefone.Name = "lboTelefone";
            this.lboTelefone.Size = new System.Drawing.Size(63, 264);
            this.lboTelefone.TabIndex = 13;
            this.lboTelefone.SelectedIndexChanged += new System.EventHandler(this.lboTelefone_SelectedIndexChanged);
            // 
            // lboEmail
            // 
            this.lboEmail.FormattingEnabled = true;
            this.lboEmail.Location = new System.Drawing.Point(678, 174);
            this.lboEmail.Name = "lboEmail";
            this.lboEmail.Size = new System.Drawing.Size(120, 264);
            this.lboEmail.TabIndex = 14;
            this.lboEmail.SelectedIndexChanged += new System.EventHandler(this.lboEmail_SelectedIndexChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Saint Carell PERSONAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(528, 84);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(125, 37);
            this.btnRemover.TabIndex = 15;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Saint Carell PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Saint Carell PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Saint Carell PERSONAL", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cpf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Saint Carell PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Endereco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Saint Carell PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(272, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Saint Carell PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(272, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Saint Carell PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(272, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Saint Carell PERSONAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(276, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(125, 37);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Saint Carell PERSONAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(528, 127);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 37);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lboEmail);
            this.Controls.Add(this.lboTelefone);
            this.Controls.Add(this.lboNascimento);
            this.Controls.Add(this.lboEndereco);
            this.Controls.Add(this.lboCPF);
            this.Controls.Add(this.lboNome);
            this.Controls.Add(this.lboCodigo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbNascimento);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNascimento;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lboCodigo;
        private System.Windows.Forms.ListBox lboNome;
        private System.Windows.Forms.ListBox lboCPF;
        private System.Windows.Forms.ListBox lboEndereco;
        private System.Windows.Forms.ListBox lboNascimento;
        private System.Windows.Forms.ListBox lboTelefone;
        private System.Windows.Forms.ListBox lboEmail;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
    }
}

