using System.ComponentModel;
using System.Data;

namespace RegistroDeAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }
        private void UpdateDataGridView()
        {
            DataTable AccessRegister = DataBase.ObterTodosAcessos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AccessRegister;

            if (!dataGridView1.Columns.Contains("btnRemove"))
            {
                DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
                btnRemove.Name = "btnRemove";
                btnRemove.HeaderText = "Excluir";
                btnRemove.Text = "-";
                btnRemove.UseColumnTextForButtonValue = true;
                btnRemove.DefaultCellStyle.BackColor = Color.Red;
                btnRemove.DefaultCellStyle.ForeColor = Color.White;
                btnRemove.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                btnRemove.FlatStyle = FlatStyle.Flat;
                btnRemove.DefaultCellStyle.SelectionBackColor = Color.Blue;
                btnRemove.DefaultCellStyle.SelectionForeColor = Color.White;
                btnRemove.DefaultCellStyle.Padding = new Padding(2);
                btnRemove.Width = 70;
                dataGridView1.Columns.Add(btnRemove);
                // Define a posição da coluna do botão como a última
                btnRemove.DisplayIndex = dataGridView1.Columns.Count - 1;

            }
            else
            {
                // Se a coluna já existir, define sua posição como a última
                dataGridView1.Columns["btnRemove"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }

            dataGridView1.Sort(dataGridView1.Columns["INDEX"], ListSortDirection.Descending);
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Globais.logado)
            {
                Application.Exit();
            }
            else
            {
                UpdateDataGridView();
                this.AcceptButton = btn_addAcess;
                dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
            }
        }

        private void btn_addAcess_Click(object sender, EventArgs e)
        {
            string userCode = tb_usercode.Text;
            bool isValidCode = int.TryParse(userCode, out _);

            if (!isValidCode)
            {
                MessageBox.Show("O código de usuário não é válido. Por favor, digite apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_usercode.Focus();
                return;
            }

            DataTable databaseConsult = DataBase.Filter("tb_colaboradores", "T_PRODUTIVO", userCode);
            if (databaseConsult.Rows.Count == 1)
            {
                DataTable registeredToday = DataBase.VerificarDuplicidade(userCode);
                if (registeredToday.Rows.Count >= 1)
                {
                    DialogResult result = MessageBox.Show("Usuario já inserido na presenta data, deseja adicionar novamente?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        registrarAcesso(databaseConsult, userCode);
                    }
                    else
                    {
                        MessageBox.Show("Registro Cancelado");
                    }
                }
                else
                {
                    registrarAcesso(databaseConsult, userCode);
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Usuário não cadastrado. Deseja cadastrar agora?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    CadastrarColaborador();
                }
            }
            tb_usercode.Text = "";
            tb_usercode.Focus();
        }

        private void registrarAcesso(DataTable dataConsult, string userCode)
        {
            string nomeColaborador = dataConsult.Rows[0].Field<string>("T_NAME");
            var today = DateTime.Now;
            string dataDoRegistro = today.ToString("dd/MM/yyyy");
            string horaDoRegistro = today.ToString("HH:mm:ss");
            DataBase.RegisterAccess(userCode, nomeColaborador, dataDoRegistro, horaDoRegistro);
            lb_username.Text = $"Último registro: {nomeColaborador} -- Dia: {dataDoRegistro} Horário: {horaDoRegistro}";
            lb_username.Visible = true;
            UpdateDataGridView();
        }


        private void cadastrarProdutivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CadUser f_CadUser = new F_CadUser();
            f_CadUser.ShowDialog();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DataTable dt = DataBase.ObterTodosAcessos();
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Registro de acesso.csv";
            using (StreamWriter streamWriter = new StreamWriter(caminho))
            {
                // Escrita dos cabeçalhos das colunas
                foreach (DataColumn column in dt.Columns)
                {
                    streamWriter.Write(column.ColumnName);
                    streamWriter.Write(";");
                }
                streamWriter.WriteLine();

                // Escrita dos dados
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        streamWriter.Write(row[i].ToString());
                        streamWriter.Write(",");
                    }
                    streamWriter.WriteLine();
                }
            }
            MessageBox.Show("Arquivo gerado na area de trabalho!");
        }

        private void alterarProdutivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_AltUser f_AltUser = new F_AltUser();
            f_AltUser.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Globais.nivel > 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnRemove" && e.RowIndex >= 0)
                {
                    int index = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["INDEX"].Value);
                    DataBase.RemoverAcesso(index);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
            else
            {
                MessageBox.Show("Seu nivel de acesso não permite a exclusão de linha");
            }
        }
        private void CadastrarColaborador()
        {
            F_CadColaborador f_cadColaborador = new F_CadColaborador();
            f_cadColaborador.ShowDialog();
        }

        private void importarColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja importar uma lista de colaboradores?\n" +
                "Header: T_PRODUTIVO; T_NAME; T_SECTOR", "Importação de Colaboradores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Arquivo CSV (*.csv)|*.csv";
                openFileDialog1.Title = "Selecione o arquivo CSV para importação";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Localize o arquivo selecionado e execute a importação dos dados para o banco de dados.
                    string caminhoArquivo = openFileDialog1.FileName;
                    DataBase.ImportarUsuarios(caminhoArquivo);
                    MessageBox.Show("Arquivo importado com sucesso!", "Importação de Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}