﻿namespace View
{
    partial class FrmCadastrar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtmCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtmRg = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtmTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dateTimeDataNasc = new System.Windows.Forms.DateTimePicker();
            this.cbRgExp = new System.Windows.Forms.ComboBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.lblValidacaoCPF = new System.Windows.Forms.Label();
            this.lblValidarLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSexo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::View.Properties.Resources.checked21;
            this.btnSalvar.Location = new System.Drawing.Point(171, 362);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 63);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::View.Properties.Resources.clean32;
            this.btnLimpar.Location = new System.Drawing.Point(255, 362);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 63);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::View.Properties.Resources.delete30;
            this.btnCancelar.Location = new System.Drawing.Point(339, 362);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 63);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "RG";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 76);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(154, 76);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(121, 20);
            this.txtSobrenome.TabIndex = 5;
            // 
            // txtmCpf
            // 
            this.txtmCpf.Location = new System.Drawing.Point(18, 119);
            this.txtmCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtmCpf.Mask = "000.000.000-00";
            this.txtmCpf.Name = "txtmCpf";
            this.txtmCpf.Size = new System.Drawing.Size(104, 20);
            this.txtmCpf.TabIndex = 7;
            this.txtmCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtmCpf.Leave += new System.EventHandler(this.txtmCpf_Leave);
            // 
            // txtmRg
            // 
            this.txtmRg.Location = new System.Drawing.Point(145, 119);
            this.txtmRg.Margin = new System.Windows.Forms.Padding(2);
            this.txtmRg.Mask = "000.000.000";
            this.txtmRg.Name = "txtmRg";
            this.txtmRg.Size = new System.Drawing.Size(76, 20);
            this.txtmRg.TabIndex = 9;
            this.txtmRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Data de Nascimento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(126, 190);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 205);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 187);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Telefeone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 284);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Login";
            // 
            // txtmTelefone
            // 
            this.txtmTelefone.Location = new System.Drawing.Point(18, 205);
            this.txtmTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtmTelefone.Mask = "(00)0000-0000";
            this.txtmTelefone.Name = "txtmTelefone";
            this.txtmTelefone.Size = new System.Drawing.Size(91, 20);
            this.txtmTelefone.TabIndex = 15;
            this.txtmTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 144);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = " Celular";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(18, 302);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(104, 20);
            this.txtUsuario.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(145, 287);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Senha";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(18, 162);
            this.txtCel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCel.Mask = "(00)00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(91, 20);
            this.txtCel.TabIndex = 11;
            this.txtCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(148, 302);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(111, 20);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 144);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Rg Exp";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(18, 15);
            this.lblCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(18, 33);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(66, 20);
            this.txtCod.TabIndex = 1;
            this.txtCod.TabStop = false;
            // 
            // dateTimeDataNasc
            // 
            this.dateTimeDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataNasc.Location = new System.Drawing.Point(18, 248);
            this.dateTimeDataNasc.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDataNasc.Name = "dateTimeDataNasc";
            this.dateTimeDataNasc.Size = new System.Drawing.Size(94, 20);
            this.dateTimeDataNasc.TabIndex = 19;
            // 
            // cbRgExp
            // 
            this.cbRgExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRgExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRgExp.FormattingEnabled = true;
            this.cbRgExp.Location = new System.Drawing.Point(129, 162);
            this.cbRgExp.MaxDropDownItems = 27;
            this.cbRgExp.Name = "cbRgExp";
            this.cbRgExp.Size = new System.Drawing.Size(92, 21);
            this.cbRgExp.TabIndex = 13;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbtnMasculino);
            this.gbSexo.Controls.Add(this.rbtnFeminino);
            this.gbSexo.Location = new System.Drawing.Point(124, 230);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(155, 43);
            this.gbSexo.TabIndex = 20;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(5, 18);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(83, 18);
            this.rbtnFeminino.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // lblValidacaoCPF
            // 
            this.lblValidacaoCPF.AutoSize = true;
            this.lblValidacaoCPF.Location = new System.Drawing.Point(68, 101);
            this.lblValidacaoCPF.Name = "lblValidacaoCPF";
            this.lblValidacaoCPF.Size = new System.Drawing.Size(0, 13);
            this.lblValidacaoCPF.TabIndex = 25;
            // 
            // lblValidarLogin
            // 
            this.lblValidarLogin.AutoSize = true;
            this.lblValidarLogin.Location = new System.Drawing.Point(71, 283);
            this.lblValidarLogin.Name = "lblValidarLogin";
            this.lblValidarLogin.Size = new System.Drawing.Size(0, 13);
            this.lblValidarLogin.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblValidarLogin);
            this.panel1.Controls.Add(this.lblValidacaoCPF);
            this.panel1.Controls.Add(this.gbSexo);
            this.panel1.Controls.Add(this.cbRgExp);
            this.panel1.Controls.Add(this.dateTimeDataNasc);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.lblCod);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtCel);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtmTelefone);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtmRg);
            this.panel1.Controls.Add(this.txtmCpf);
            this.panel1.Controls.Add(this.txtSobrenome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 352);
            this.panel1.TabIndex = 0;
            // 
            // FrmCadastrar
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 431);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.FrmCadastrar_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.MaskedTextBox txtmCpf;
        private System.Windows.Forms.MaskedTextBox txtmRg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtmTelefone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DateTimePicker dateTimeDataNasc;
        private System.Windows.Forms.ComboBox cbRgExp;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Label lblValidacaoCPF;
        private System.Windows.Forms.Label lblValidarLogin;
        private System.Windows.Forms.Panel panel1;
    }
}