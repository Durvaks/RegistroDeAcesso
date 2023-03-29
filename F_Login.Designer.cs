namespace RegistroDeAcesso
{
    partial class F_Login
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
            tb_username = new TextBox();
            tb_senha = new TextBox();
            Password = new Label();
            btn_logar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 18);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(54, 36);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(108, 23);
            tb_username.TabIndex = 1;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(54, 96);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '*';
            tb_senha.Size = new Size(108, 23);
            tb_senha.TabIndex = 3;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(54, 78);
            Password.Name = "Password";
            Password.Size = new Size(39, 15);
            Password.TabIndex = 2;
            Password.Text = "Senha";
            Password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_logar
            // 
            btn_logar.Location = new Point(116, 142);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(75, 23);
            btn_logar.TabIndex = 4;
            btn_logar.Text = "Logar";
            btn_logar.UseVisualStyleBackColor = true;
            btn_logar.Click += btn_logar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(35, 142);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 177);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_logar);
            Controls.Add(tb_senha);
            Controls.Add(Password);
            Controls.Add(tb_username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_username;
        private TextBox tb_senha;
        private Label Password;
        private Button btn_logar;
        private Button btn_cancelar;
    }
}