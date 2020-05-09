namespace ProjetoCeará
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.grpbotoes = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblShelflife = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnhexcluir = new System.Windows.Forms.RadioButton();
            this.rbtnheditar = new System.Windows.Forms.RadioButton();
            this.rbtnhinserir = new System.Windows.Forms.RadioButton();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.grpbotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(223, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "CADASTROS DE CLIENTES";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(156, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "BUSCAR...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Location = new System.Drawing.Point(464, 405);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(182, 17);
            this.guna2RadioButton1.TabIndex = 54;
            this.guna2RadioButton1.TabStop = true;
            this.guna2RadioButton1.Text = "Tenho Certeza que Quero Excluir";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UseVisualStyleBackColor = true;
            // 
            // grpbotoes
            // 
            this.grpbotoes.Controls.Add(this.rbtnhexcluir);
            this.grpbotoes.Controls.Add(this.rbtnheditar);
            this.grpbotoes.Controls.Add(this.rbtnhinserir);
            this.grpbotoes.Controls.Add(this.btninserir);
            this.grpbotoes.Controls.Add(this.button5);
            this.grpbotoes.Controls.Add(this.button6);
            this.grpbotoes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpbotoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpbotoes.Location = new System.Drawing.Point(63, 373);
            this.grpbotoes.Name = "grpbotoes";
            this.grpbotoes.ShadowDecoration.Parent = this.grpbotoes;
            this.grpbotoes.Size = new System.Drawing.Size(387, 97);
            this.grpbotoes.TabIndex = 70;
            // 
            // btninserir
            // 
            this.btninserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btninserir.BackColor = System.Drawing.Color.OrangeRed;
            this.btninserir.FlatAppearance.BorderSize = 0;
            this.btninserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btninserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninserir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.ForeColor = System.Drawing.Color.White;
            this.btninserir.Image = ((System.Drawing.Image)(resources.GetObject("btninserir.Image")));
            this.btninserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninserir.Location = new System.Drawing.Point(9, 6);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(107, 45);
            this.btninserir.TabIndex = 13;
            this.btninserir.Text = "Inserir";
            this.btninserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(128, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 45);
            this.button5.TabIndex = 14;
            this.button5.Text = "Editar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(256, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 45);
            this.button6.TabIndex = 15;
            this.button6.Text = "Excluir";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(562, 355);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(32, 28);
            this.guna2Button1.TabIndex = 67;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Control;
            this.txtid.Location = new System.Drawing.Point(516, 169);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(172, 20);
            this.txtid.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "ID";
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(516, 299);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(172, 20);
            this.txtconta.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Conta";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(516, 273);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(172, 20);
            this.txttel.TabIndex = 61;
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(516, 247);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(172, 20);
            this.txtdoc.TabIndex = 60;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(516, 193);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(174, 20);
            this.txtname.TabIndex = 59;
            // 
            // lblShelflife
            // 
            this.lblShelflife.AutoSize = true;
            this.lblShelflife.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelflife.Location = new System.Drawing.Point(445, 275);
            this.lblShelflife.Name = "lblShelflife";
            this.lblShelflife.Size = new System.Drawing.Size(65, 18);
            this.lblShelflife.TabIndex = 58;
            this.lblShelflife.Text = "Telefone";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(424, 246);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 18);
            this.lblDescription.TabIndex = 57;
            this.lblDescription.Text = "Documentos";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(432, 221);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 18);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Sobrenome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(458, 192);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(49, 18);
            this.lblId.TabIndex = 55;
            this.lblId.Text = "Nome";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.OrangeRed;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(179, 373);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(0, 0);
            this.button7.TabIndex = 53;
            this.button7.Text = "Vendas";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(516, 325);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(172, 20);
            this.txtcodigo.TabIndex = 71;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(516, 222);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(172, 20);
            this.txtlastname.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "Código";
            // 
            // rbtnhexcluir
            // 
            this.rbtnhexcluir.AutoSize = true;
            this.rbtnhexcluir.Location = new System.Drawing.Point(276, 66);
            this.rbtnhexcluir.Name = "rbtnhexcluir";
            this.rbtnhexcluir.Size = new System.Drawing.Size(60, 19);
            this.rbtnhexcluir.TabIndex = 34;
            this.rbtnhexcluir.TabStop = true;
            this.rbtnhexcluir.Text = "Excluir";
            this.rbtnhexcluir.UseVisualStyleBackColor = true;
            // 
            // rbtnheditar
            // 
            this.rbtnheditar.AutoSize = true;
            this.rbtnheditar.Location = new System.Drawing.Point(165, 66);
            this.rbtnheditar.Name = "rbtnheditar";
            this.rbtnheditar.Size = new System.Drawing.Size(55, 19);
            this.rbtnheditar.TabIndex = 33;
            this.rbtnheditar.TabStop = true;
            this.rbtnheditar.Text = "Editar";
            this.rbtnheditar.UseVisualStyleBackColor = true;
            // 
            // rbtnhinserir
            // 
            this.rbtnhinserir.AutoSize = true;
            this.rbtnhinserir.Location = new System.Drawing.Point(52, 66);
            this.rbtnhinserir.Name = "rbtnhinserir";
            this.rbtnhinserir.Size = new System.Drawing.Size(57, 19);
            this.rbtnhinserir.TabIndex = 32;
            this.rbtnhinserir.TabStop = true;
            this.rbtnhinserir.Text = "Inserir";
            this.rbtnhinserir.UseVisualStyleBackColor = true;
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Location = new System.Drawing.Point(12, 149);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.Size = new System.Drawing.Size(403, 193);
            this.dgvlista.TabIndex = 74;
            this.dgvlista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlista_CellClick);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.guna2RadioButton1);
            this.Controls.Add(this.grpbotoes);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtdoc);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblShelflife);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.grpbotoes.ResumeLayout(false);
            this.grpbotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2GroupBox grpbotoes;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblShelflife;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnhexcluir;
        private System.Windows.Forms.RadioButton rbtnheditar;
        private System.Windows.Forms.RadioButton rbtnhinserir;
        private System.Windows.Forms.DataGridView dgvlista;
    }
}