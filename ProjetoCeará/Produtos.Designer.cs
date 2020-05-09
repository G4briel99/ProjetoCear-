namespace ProjetoCeará
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.datevalidade = new System.Windows.Forms.DateTimePicker();
            this.rbtnconfirmar = new System.Windows.Forms.RadioButton();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btnexcluirprod = new System.Windows.Forms.Button();
            this.btneditarprod = new System.Windows.Forms.Button();
            this.btninserirprod = new System.Windows.Forms.Button();
            this.grpbotoes = new System.Windows.Forms.GroupBox();
            this.rbtnhinserir = new System.Windows.Forms.RadioButton();
            this.rbtnheditar = new System.Windows.Forms.RadioButton();
            this.rbtnhexcluir = new System.Windows.Forms.RadioButton();
            this.btnpesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.grpbotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUTOS";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpesquisa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtpesquisa.Location = new System.Drawing.Point(12, 95);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(403, 20);
            this.txtpesquisa.TabIndex = 12;
            this.txtpesquisa.Text = "BUSCAR...";
            this.txtpesquisa.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(546, 170);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 13;
            // 
            // txtdesc
            // 
            this.txtdesc.Enabled = false;
            this.txtdesc.Location = new System.Drawing.Point(546, 208);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(100, 20);
            this.txtdesc.TabIndex = 14;
            // 
            // txtpreco
            // 
            this.txtpreco.Enabled = false;
            this.txtpreco.Location = new System.Drawing.Point(546, 290);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 16;
            // 
            // txtquantidade
            // 
            this.txtquantidade.Enabled = false;
            this.txtquantidade.Location = new System.Drawing.Point(546, 333);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(100, 20);
            this.txtquantidade.TabIndex = 17;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(546, 135);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Validade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nome";
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Location = new System.Drawing.Point(12, 160);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.Size = new System.Drawing.Size(403, 193);
            this.dgvlista.TabIndex = 25;
            this.dgvlista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlista_CellClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnrefresh.BorderRadius = 20;
            this.btnrefresh.BorderThickness = 1;
            this.btnrefresh.CheckedState.Parent = this.btnrefresh;
            this.btnrefresh.CustomImages.Parent = this.btnrefresh;
            this.btnrefresh.FillColor = System.Drawing.Color.OrangeRed;
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.HoverState.Parent = this.btnrefresh;
            this.btnrefresh.Location = new System.Drawing.Point(421, 139);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ShadowDecoration.Parent = this.btnrefresh;
            this.btnrefresh.Size = new System.Drawing.Size(53, 51);
            this.btnrefresh.TabIndex = 26;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // datevalidade
            // 
            this.datevalidade.CustomFormat = "dd/MM/yyyy";
            this.datevalidade.Enabled = false;
            this.datevalidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datevalidade.Location = new System.Drawing.Point(546, 249);
            this.datevalidade.Name = "datevalidade";
            this.datevalidade.Size = new System.Drawing.Size(100, 20);
            this.datevalidade.TabIndex = 27;
            // 
            // rbtnconfirmar
            // 
            this.rbtnconfirmar.AutoSize = true;
            this.rbtnconfirmar.Location = new System.Drawing.Point(386, 428);
            this.rbtnconfirmar.Name = "rbtnconfirmar";
            this.rbtnconfirmar.Size = new System.Drawing.Size(174, 17);
            this.rbtnconfirmar.TabIndex = 28;
            this.rbtnconfirmar.TabStop = true;
            this.rbtnconfirmar.Text = "Você deseja realmente deletar?";
            this.rbtnconfirmar.UseVisualStyleBackColor = true;
            this.rbtnconfirmar.CheckedChanged += new System.EventHandler(this.rbtnconfirmar_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.CheckedState.Parent = this.btnclear;
            this.btnclear.CustomImages.Parent = this.btnclear;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.HoverState.Parent = this.btnclear;
            this.btnclear.Location = new System.Drawing.Point(570, 371);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.Parent = this.btnclear;
            this.btnclear.Size = new System.Drawing.Size(76, 45);
            this.btnclear.TabIndex = 29;
            this.btnclear.Text = "x";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexcluirprod
            // 
            this.btnexcluirprod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcluirprod.BackColor = System.Drawing.Color.OrangeRed;
            this.btnexcluirprod.FlatAppearance.BorderSize = 0;
            this.btnexcluirprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnexcluirprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluirprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluirprod.ForeColor = System.Drawing.Color.White;
            this.btnexcluirprod.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluirprod.Image")));
            this.btnexcluirprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluirprod.Location = new System.Drawing.Point(234, 5);
            this.btnexcluirprod.Name = "btnexcluirprod";
            this.btnexcluirprod.Size = new System.Drawing.Size(107, 45);
            this.btnexcluirprod.TabIndex = 8;
            this.btnexcluirprod.Text = "Excluir";
            this.btnexcluirprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcluirprod.UseVisualStyleBackColor = false;
            this.btnexcluirprod.Click += new System.EventHandler(this.btnexcluirprod_Click);
            // 
            // btneditarprod
            // 
            this.btneditarprod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditarprod.BackColor = System.Drawing.Color.OrangeRed;
            this.btneditarprod.FlatAppearance.BorderSize = 0;
            this.btneditarprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btneditarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditarprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditarprod.ForeColor = System.Drawing.Color.White;
            this.btneditarprod.Image = ((System.Drawing.Image)(resources.GetObject("btneditarprod.Image")));
            this.btneditarprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditarprod.Location = new System.Drawing.Point(121, 5);
            this.btneditarprod.Name = "btneditarprod";
            this.btneditarprod.Size = new System.Drawing.Size(107, 45);
            this.btneditarprod.TabIndex = 9;
            this.btneditarprod.Text = "Editar";
            this.btneditarprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditarprod.UseVisualStyleBackColor = false;
            this.btneditarprod.Click += new System.EventHandler(this.btneditarprod_Click);
            // 
            // btninserirprod
            // 
            this.btninserirprod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btninserirprod.BackColor = System.Drawing.Color.OrangeRed;
            this.btninserirprod.FlatAppearance.BorderSize = 0;
            this.btninserirprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btninserirprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninserirprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserirprod.ForeColor = System.Drawing.Color.White;
            this.btninserirprod.Image = ((System.Drawing.Image)(resources.GetObject("btninserirprod.Image")));
            this.btninserirprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninserirprod.Location = new System.Drawing.Point(8, 5);
            this.btninserirprod.Name = "btninserirprod";
            this.btninserirprod.Size = new System.Drawing.Size(107, 45);
            this.btninserirprod.TabIndex = 7;
            this.btninserirprod.Text = "Inserir";
            this.btninserirprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninserirprod.UseVisualStyleBackColor = false;
            this.btninserirprod.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // grpbotoes
            // 
            this.grpbotoes.BackColor = System.Drawing.Color.Transparent;
            this.grpbotoes.Controls.Add(this.rbtnhexcluir);
            this.grpbotoes.Controls.Add(this.rbtnheditar);
            this.grpbotoes.Controls.Add(this.rbtnhinserir);
            this.grpbotoes.Controls.Add(this.btninserirprod);
            this.grpbotoes.Controls.Add(this.btneditarprod);
            this.grpbotoes.Controls.Add(this.btnexcluirprod);
            this.grpbotoes.Location = new System.Drawing.Point(12, 371);
            this.grpbotoes.Name = "grpbotoes";
            this.grpbotoes.Size = new System.Drawing.Size(359, 85);
            this.grpbotoes.TabIndex = 30;
            this.grpbotoes.TabStop = false;
            // 
            // rbtnhinserir
            // 
            this.rbtnhinserir.AutoSize = true;
            this.rbtnhinserir.Location = new System.Drawing.Point(37, 56);
            this.rbtnhinserir.Name = "rbtnhinserir";
            this.rbtnhinserir.Size = new System.Drawing.Size(53, 17);
            this.rbtnhinserir.TabIndex = 29;
            this.rbtnhinserir.TabStop = true;
            this.rbtnhinserir.Text = "Inserir";
            this.rbtnhinserir.UseVisualStyleBackColor = true;
            this.rbtnhinserir.CheckedChanged += new System.EventHandler(this.rbtnhinserir_CheckedChanged);
            // 
            // rbtnheditar
            // 
            this.rbtnheditar.AutoSize = true;
            this.rbtnheditar.Location = new System.Drawing.Point(150, 56);
            this.rbtnheditar.Name = "rbtnheditar";
            this.rbtnheditar.Size = new System.Drawing.Size(52, 17);
            this.rbtnheditar.TabIndex = 30;
            this.rbtnheditar.TabStop = true;
            this.rbtnheditar.Text = "Editar";
            this.rbtnheditar.UseVisualStyleBackColor = true;
            this.rbtnheditar.CheckedChanged += new System.EventHandler(this.rbtnheditar_CheckedChanged);
            // 
            // rbtnhexcluir
            // 
            this.rbtnhexcluir.AutoSize = true;
            this.rbtnhexcluir.Location = new System.Drawing.Point(261, 56);
            this.rbtnhexcluir.Name = "rbtnhexcluir";
            this.rbtnhexcluir.Size = new System.Drawing.Size(56, 17);
            this.rbtnhexcluir.TabIndex = 31;
            this.rbtnhexcluir.TabStop = true;
            this.rbtnhexcluir.Text = "Excluir";
            this.rbtnhexcluir.UseVisualStyleBackColor = true;
            this.rbtnhexcluir.CheckedChanged += new System.EventHandler(this.rbtnhexcluir_CheckedChanged);
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Location = new System.Drawing.Point(433, 91);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisa.TabIndex = 31;
            this.btnpesquisa.Text = "button1";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.grpbotoes);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.rbtnconfirmar);
            this.Controls.Add(this.datevalidade);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.grpbotoes.ResumeLayout(false);
            this.grpbotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvlista;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.DateTimePicker datevalidade;
        private System.Windows.Forms.RadioButton rbtnconfirmar;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private System.Windows.Forms.Button btnexcluirprod;
        private System.Windows.Forms.Button btneditarprod;
        private System.Windows.Forms.Button btninserirprod;
        private System.Windows.Forms.GroupBox grpbotoes;
        private System.Windows.Forms.RadioButton rbtnhexcluir;
        private System.Windows.Forms.RadioButton rbtnheditar;
        private System.Windows.Forms.RadioButton rbtnhinserir;
        private System.Windows.Forms.Button btnpesquisa;
    }
}