namespace RegistroDeAcesso
{
    partial class F_AltUser
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
            lb_produtivo = new Label();
            tb_produtivo = new TextBox();
            groupBox1 = new GroupBox();
            tb_novasenha2 = new TextBox();
            label5 = new Label();
            tb_novasenha1 = new TextBox();
            label4 = new Label();
            btn_remove = new Button();
            rb_nivel2 = new RadioButton();
            rb_nivel1 = new RadioButton();
            rb_nivel0 = new RadioButton();
            btn_alterar = new Button();
            label3 = new Label();
            tb_newProdutivo = new TextBox();
            label2 = new Label();
            tb_newNome = new TextBox();
            label1 = new Label();
            btn_consultar = new Button();
            lb_info = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_produtivo
            // 
            lb_produtivo.AutoSize = true;
            lb_produtivo.Location = new Point(12, 12);
            lb_produtivo.Name = "lb_produtivo";
            lb_produtivo.Size = new Size(59, 15);
            lb_produtivo.TabIndex = 0;
            lb_produtivo.Text = "Produtivo";
            // 
            // tb_produtivo
            // 
            tb_produtivo.Location = new Point(12, 30);
            tb_produtivo.Name = "tb_produtivo";
            tb_produtivo.Size = new Size(118, 23);
            tb_produtivo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_novasenha2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_novasenha1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_remove);
            groupBox1.Controls.Add(rb_nivel2);
            groupBox1.Controls.Add(rb_nivel1);
            groupBox1.Controls.Add(rb_nivel0);
            groupBox1.Controls.Add(btn_alterar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_newProdutivo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_newNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(136, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 300);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados a serem alterados";
            // 
            // tb_novasenha2
            // 
            tb_novasenha2.Enabled = false;
            tb_novasenha2.Location = new Point(139, 131);
            tb_novasenha2.Name = "tb_novasenha2";
            tb_novasenha2.Size = new Size(100, 23);
            tb_novasenha2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 134);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 13;
            label5.Text = "Repetir Nova Senha";
            // 
            // tb_novasenha1
            // 
            tb_novasenha1.Enabled = false;
            tb_novasenha1.Location = new Point(139, 104);
            tb_novasenha1.Name = "tb_novasenha1";
            tb_novasenha1.Size = new Size(100, 23);
            tb_novasenha1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 106);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 11;
            label4.Text = "Nova Senha";
            // 
            // btn_remove
            // 
            btn_remove.Enabled = false;
            btn_remove.Location = new Point(8, 268);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(147, 23);
            btn_remove.TabIndex = 10;
            btn_remove.Text = "Remover Usuario";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // rb_nivel2
            // 
            rb_nivel2.AutoSize = true;
            rb_nivel2.Enabled = false;
            rb_nivel2.Location = new Point(18, 231);
            rb_nivel2.Name = "rb_nivel2";
            rb_nivel2.Size = new Size(137, 19);
            rb_nivel2.TabIndex = 9;
            rb_nivel2.TabStop = true;
            rb_nivel2.Text = "Nivel 2 - Acesso Total";
            rb_nivel2.UseVisualStyleBackColor = true;
            // 
            // rb_nivel1
            // 
            rb_nivel1.AutoSize = true;
            rb_nivel1.Enabled = false;
            rb_nivel1.Location = new Point(18, 206);
            rb_nivel1.Name = "rb_nivel1";
            rb_nivel1.Size = new Size(247, 19);
            rb_nivel1.TabIndex = 8;
            rb_nivel1.TabStop = true;
            rb_nivel1.Text = "Nivel 1 - Consultas e Cadastro de Usuarios";
            rb_nivel1.UseVisualStyleBackColor = true;
            // 
            // rb_nivel0
            // 
            rb_nivel0.AutoSize = true;
            rb_nivel0.Enabled = false;
            rb_nivel0.Location = new Point(18, 181);
            rb_nivel0.Name = "rb_nivel0";
            rb_nivel0.Size = new Size(183, 19);
            rb_nivel0.TabIndex = 7;
            rb_nivel0.TabStop = true;
            rb_nivel0.Text = "Nivel 0 - Apenas para Registro";
            rb_nivel0.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.Enabled = false;
            btn_alterar.Location = new Point(250, 269);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(132, 23);
            btn_alterar.TabIndex = 6;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 163);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Nivel de Acesso";
            // 
            // tb_newProdutivo
            // 
            tb_newProdutivo.Enabled = false;
            tb_newProdutivo.Location = new Point(73, 68);
            tb_newProdutivo.Name = "tb_newProdutivo";
            tb_newProdutivo.Size = new Size(127, 23);
            tb_newProdutivo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 71);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Produtivo";
            // 
            // tb_newNome
            // 
            tb_newNome.Enabled = false;
            tb_newNome.Location = new Point(73, 34);
            tb_newNome.Name = "tb_newNome";
            tb_newNome.Size = new Size(309, 23);
            tb_newNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(12, 59);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(118, 23);
            btn_consultar.TabIndex = 3;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // lb_info
            // 
            lb_info.Location = new Point(12, 112);
            lb_info.Name = "lb_info";
            lb_info.Size = new Size(110, 168);
            lb_info.TabIndex = 4;
            lb_info.Text = "Info";
            lb_info.Visible = false;
            // 
            // F_AltUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 324);
            Controls.Add(lb_info);
            Controls.Add(btn_consultar);
            Controls.Add(groupBox1);
            Controls.Add(tb_produtivo);
            Controls.Add(lb_produtivo);
            Name = "F_AltUser";
            Text = "F_AltUser";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_produtivo;
        private TextBox tb_produtivo;
        private GroupBox groupBox1;
        private Button btn_alterar;
        private Label label3;
        private TextBox tb_newProdutivo;
        private Label label2;
        private TextBox tb_newNome;
        private Label label1;
        private Button btn_consultar;
        private Label lb_info;
        private RadioButton rb_nivel0;
        private RadioButton rb_nivel2;
        private RadioButton rb_nivel1;
        private Button btn_remove;
        private TextBox tb_novasenha2;
        private Label label5;
        private TextBox tb_novasenha1;
        private Label label4;
    }
}