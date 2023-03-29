namespace RegistroDeAcesso
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lb_acesso = new Label();
            lb_nivel = new Label();
            label1 = new Label();
            tb_usercode = new TextBox();
            lb_username = new Label();
            btn_addAcess = new Button();
            btn_export = new Button();
            dataGridView1 = new DataGridView();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarProdutivoToolStripMenuItem = new ToolStripMenuItem();
            alterarProdutivoToolStripMenuItem = new ToolStripMenuItem();
            alterarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            importarColaboradoresToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_acesso
            // 
            lb_acesso.AutoSize = true;
            lb_acesso.Location = new Point(16, 511);
            lb_acesso.Name = "lb_acesso";
            lb_acesso.Size = new Size(82, 20);
            lb_acesso.TabIndex = 0;
            lb_acesso.Text = "User Name";
            // 
            // lb_nivel
            // 
            lb_nivel.AutoSize = true;
            lb_nivel.Location = new Point(311, 511);
            lb_nivel.Name = "lb_nivel";
            lb_nivel.Size = new Size(43, 20);
            lb_nivel.TabIndex = 1;
            lb_nivel.Text = "Nivel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Produtivo";
            // 
            // tb_usercode
            // 
            tb_usercode.Location = new Point(101, 63);
            tb_usercode.Margin = new Padding(3, 4, 3, 4);
            tb_usercode.Name = "tb_usercode";
            tb_usercode.Size = new Size(163, 27);
            tb_usercode.TabIndex = 4;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.ForeColor = Color.DarkCyan;
            lb_username.Location = new Point(101, 32);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(108, 20);
            lb_username.TabIndex = 5;
            lb_username.Text = "Ultima entrada";
            lb_username.Visible = false;
            // 
            // btn_addAcess
            // 
            btn_addAcess.Location = new Point(591, 67);
            btn_addAcess.Margin = new Padding(3, 4, 3, 4);
            btn_addAcess.Name = "btn_addAcess";
            btn_addAcess.Size = new Size(105, 31);
            btn_addAcess.TabIndex = 6;
            btn_addAcess.Text = "Registrar";
            btn_addAcess.UseVisualStyleBackColor = true;
            btn_addAcess.Click += btn_addAcess_Click;
            // 
            // btn_export
            // 
            btn_export.Location = new Point(610, 500);
            btn_export.Margin = new Padding(3, 4, 3, 4);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(86, 31);
            btn_export.TabIndex = 7;
            btn_export.Text = "Exportar";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.DarkSlateGray;
            dataGridView1.Location = new Point(23, 105);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(673, 387);
            dataGridView1.TabIndex = 8;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cadastrarProdutivoToolStripMenuItem, alterarProdutivoToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(79, 24);
            toolStripMenuItem1.Text = "Usuarios";
            // 
            // cadastrarProdutivoToolStripMenuItem
            // 
            cadastrarProdutivoToolStripMenuItem.Name = "cadastrarProdutivoToolStripMenuItem";
            cadastrarProdutivoToolStripMenuItem.Size = new Size(224, 26);
            cadastrarProdutivoToolStripMenuItem.Text = "Cadastrar";
            cadastrarProdutivoToolStripMenuItem.Click += cadastrarProdutivoToolStripMenuItem_Click;
            // 
            // alterarProdutivoToolStripMenuItem
            // 
            alterarProdutivoToolStripMenuItem.Name = "alterarProdutivoToolStripMenuItem";
            alterarProdutivoToolStripMenuItem.Size = new Size(224, 26);
            alterarProdutivoToolStripMenuItem.Text = "Alterar";
            alterarProdutivoToolStripMenuItem.Click += alterarProdutivoToolStripMenuItem_Click;
            // 
            // alterarUsuarioToolStripMenuItem
            // 
            alterarUsuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaToolStripMenuItem });
            alterarUsuarioToolStripMenuItem.Name = "alterarUsuarioToolStripMenuItem";
            alterarUsuarioToolStripMenuItem.Size = new Size(84, 24);
            alterarUsuarioToolStripMenuItem.Text = "Registros";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(149, 26);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, alterarUsuarioToolStripMenuItem, importarColaboradoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(723, 30);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // importarColaboradoresToolStripMenuItem
            // 
            importarColaboradoresToolStripMenuItem.Name = "importarColaboradoresToolStripMenuItem";
            importarColaboradoresToolStripMenuItem.Size = new Size(81, 24);
            importarColaboradoresToolStripMenuItem.Text = "Importar";
            importarColaboradoresToolStripMenuItem.Click += importarColaboradoresToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 541);
            Controls.Add(dataGridView1);
            Controls.Add(btn_export);
            Controls.Add(btn_addAcess);
            Controls.Add(lb_username);
            Controls.Add(tb_usercode);
            Controls.Add(label1);
            Controls.Add(lb_nivel);
            Controls.Add(lb_acesso);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Acessos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lb_acesso;
        public Label lb_nivel;
        private Label label1;
        private TextBox tb_usercode;
        private Button btn_addAcess;
        private Button btn_export;
        public Label lb_username;
        private DataGridView dataGridView1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem alterarUsuarioToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarProdutivoToolStripMenuItem;
        private ToolStripMenuItem alterarProdutivoToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem importarColaboradoresToolStripMenuItem;
    }
}