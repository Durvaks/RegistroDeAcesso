namespace RegistroDeAcesso
{
    partial class F_CadColaborador
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
            tb_produtivo = new TextBox();
            tb_nome = new TextBox();
            btn_cadastrar = new Button();
            cb_setor = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Produtivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 58);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 107);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Setor";
            // 
            // tb_produtivo
            // 
            tb_produtivo.Location = new Point(117, 9);
            tb_produtivo.Name = "tb_produtivo";
            tb_produtivo.Size = new Size(125, 27);
            tb_produtivo.TabIndex = 3;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(117, 58);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(462, 27);
            tb_nome.TabIndex = 4;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(485, 103);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(94, 29);
            btn_cadastrar.TabIndex = 6;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // cb_setor
            // 
            cb_setor.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_setor.FormattingEnabled = true;
            cb_setor.Items.AddRange(new object[] { "Outros", "Operacional", "Area de Apoio" });
            cb_setor.Location = new Point(117, 107);
            cb_setor.Name = "cb_setor";
            cb_setor.Size = new Size(151, 28);
            cb_setor.TabIndex = 7;
            // 
            // F_CadColaborador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 149);
            Controls.Add(cb_setor);
            Controls.Add(btn_cadastrar);
            Controls.Add(tb_nome);
            Controls.Add(tb_produtivo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "F_CadColaborador";
            Text = "Cadastrar Colaborador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_produtivo;
        private TextBox tb_nome;
        private Button btn_cadastrar;
        private ComboBox cb_setor;
    }
}