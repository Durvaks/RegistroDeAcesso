namespace RegistroDeAcesso
{
    partial class F_CadUser
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_produtivo = new TextBox();
            tb_nome = new TextBox();
            tb_senha1 = new TextBox();
            tb_senha2 = new TextBox();
            button1 = new Button();
            btn_cad = new Button();
            lb_span = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Produtivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 72);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 132);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 125);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 3;
            label4.Text = "Repetir Senha";
            // 
            // tb_produtivo
            // 
            tb_produtivo.Location = new Point(98, 20);
            tb_produtivo.Margin = new Padding(3, 4, 3, 4);
            tb_produtivo.Name = "tb_produtivo";
            tb_produtivo.Size = new Size(147, 27);
            tb_produtivo.TabIndex = 4;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(98, 68);
            tb_nome.Margin = new Padding(3, 4, 3, 4);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(347, 27);
            tb_nome.TabIndex = 5;
            // 
            // tb_senha1
            // 
            tb_senha1.Location = new Point(98, 121);
            tb_senha1.Margin = new Padding(3, 4, 3, 4);
            tb_senha1.Name = "tb_senha1";
            tb_senha1.PasswordChar = '*';
            tb_senha1.Size = new Size(114, 27);
            tb_senha1.TabIndex = 6;
            // 
            // tb_senha2
            // 
            tb_senha2.Location = new Point(326, 121);
            tb_senha2.Margin = new Padding(3, 4, 3, 4);
            tb_senha2.Name = "tb_senha2";
            tb_senha2.PasswordChar = '*';
            tb_senha2.Size = new Size(114, 27);
            tb_senha2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Cornsilk;
            button1.Location = new Point(246, 193);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 8;
            button1.Text = "Retornar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_cad
            // 
            btn_cad.BackColor = Color.Turquoise;
            btn_cad.Location = new Point(354, 193);
            btn_cad.Margin = new Padding(3, 4, 3, 4);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(86, 31);
            btn_cad.TabIndex = 9;
            btn_cad.Text = "Cadastrar";
            btn_cad.UseVisualStyleBackColor = false;
            btn_cad.Click += btn_cad_Click;
            // 
            // lb_span
            // 
            lb_span.AutoSize = true;
            lb_span.ForeColor = Color.Red;
            lb_span.Location = new Point(43, 199);
            lb_span.Name = "lb_span";
            lb_span.Size = new Size(40, 20);
            lb_span.TabIndex = 10;
            lb_span.Text = "span";
            lb_span.Visible = false;
            // 
            // F_CadUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 255);
            Controls.Add(lb_span);
            Controls.Add(btn_cad);
            Controls.Add(button1);
            Controls.Add(tb_senha2);
            Controls.Add(tb_senha1);
            Controls.Add(tb_nome);
            Controls.Add(tb_produtivo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F_CadUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_CadUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_produtivo;
        private TextBox tb_nome;
        private TextBox tb_senha1;
        private TextBox tb_senha2;
        private Button button1;
        private Button btn_cad;
        private Label lb_span;
    }
}