namespace View
{
    partial class FrmConsultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridViewConsultar = new System.Windows.Forms.DataGridView();
            this.coIdAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRgExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procurar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(225, 26);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(323, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // dataGridViewConsultar
            // 
            this.dataGridViewConsultar.AllowUserToAddRows = false;
            this.dataGridViewConsultar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewConsultar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coIdAluno,
            this.colNome,
            this.colSobrenome,
            this.colCpf,
            this.colRg,
            this.colRgExp,
            this.colDataNascimento,
            this.colEmail,
            this.colSexo,
            this.colTelefone,
            this.colCelular,
            this.colUsuario});
            this.dataGridViewConsultar.Location = new System.Drawing.Point(9, 66);
            this.dataGridViewConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewConsultar.MultiSelect = false;
            this.dataGridViewConsultar.Name = "dataGridViewConsultar";
            this.dataGridViewConsultar.ReadOnly = true;
            this.dataGridViewConsultar.RowTemplate.Height = 24;
            this.dataGridViewConsultar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultar.Size = new System.Drawing.Size(810, 314);
            this.dataGridViewConsultar.TabIndex = 3;
            this.dataGridViewConsultar.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewConsultar_CellMouseDoubleClick);
            // 
            // coIdAluno
            // 
            this.coIdAluno.DataPropertyName = "idAluno";
            dataGridViewCellStyle2.Format = "#,##0";
            this.coIdAluno.DefaultCellStyle = dataGridViewCellStyle2;
            this.coIdAluno.HeaderText = "ID Aluno";
            this.coIdAluno.Name = "coIdAluno";
            this.coIdAluno.ReadOnly = true;
            this.coIdAluno.Width = 50;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 60;
            // 
            // colSobrenome
            // 
            this.colSobrenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSobrenome.DataPropertyName = "Sobrenome";
            this.colSobrenome.HeaderText = "Sobrenome";
            this.colSobrenome.Name = "colSobrenome";
            this.colSobrenome.ReadOnly = true;
            this.colSobrenome.Width = 86;
            // 
            // colCpf
            // 
            this.colCpf.DataPropertyName = "Cpf";
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colRg
            // 
            this.colRg.DataPropertyName = "Rg";
            this.colRg.HeaderText = "RG";
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            // 
            // colRgExp
            // 
            this.colRgExp.DataPropertyName = "RgExp";
            this.colRgExp.HeaderText = "RG Exp.";
            this.colRgExp.Name = "colRgExp";
            this.colRgExp.ReadOnly = true;
            this.colRgExp.Width = 40;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.DataPropertyName = "dataNascimento";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.colDataNascimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDataNascimento.HeaderText = "Data de Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            this.colDataNascimento.Width = 90;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-Mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 61;
            // 
            // colSexo
            // 
            this.colSexo.DataPropertyName = "Sexo";
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSexo.Width = 80;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 80;
            // 
            // colCelular
            // 
            this.colCelular.DataPropertyName = "Celular";
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            this.colCelular.Width = 80;
            // 
            // colUsuario
            // 
            this.colUsuario.DataPropertyName = "Usuario";
            this.colUsuario.HeaderText = "Usuário";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AccessibleName = "Pesquisar";
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(551, 22);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(129, 25);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Image = global::View.Properties.Resources.door32;
            this.btnSair.Location = new System.Drawing.Point(718, 385);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 54);
            this.btnSair.TabIndex = 6;
            this.btnSair.Tag = "Fechar";
            this.btnSair.Text = "Fechar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.AccessibleDescription = "Deletar registro";
            this.btnDeletar.AccessibleName = "Excluir";
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.Image = global::View.Properties.Resources.delete96;
            this.btnDeletar.Location = new System.Drawing.Point(615, 385);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(104, 54);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Tag = "Excluir";
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleDescription = "Editar um registro";
            this.btnEditar.AccessibleName = "Editar";
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Image = global::View.Properties.Resources.edit26;
            this.btnEditar.Location = new System.Drawing.Point(408, 385);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 54);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Tag = "Editar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.AccessibleDescription = "Consultar um registro";
            this.btnConsultar.AccessibleName = "Consultar";
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Image = global::View.Properties.Resources.magnifying_glass;
            this.btnConsultar.Location = new System.Drawing.Point(512, 385);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 54);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Tag = "Consultar";
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AccessibleDescription = "Cadastrar Novo Aluno";
            this.btnCadastrar.AccessibleName = "Inserir";
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(304, 385);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 54);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Tag = "Inserir";
            this.btnCadastrar.Text = "Inserir";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 444);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGridViewConsultar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewConsultar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn coIdAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRgExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
    }
}