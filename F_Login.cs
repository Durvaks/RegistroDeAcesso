using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeAcesso
{
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            Globais.logado = false;
            form1 = f;
            this.AcceptButton = btn_logar;
        }
        private void btn_logar_Click(object sender, EventArgs e)
        {
            string produtivo = tb_username.Text;
            string senha = tb_senha.Text;

            if (produtivo == "" || senha == "")
            {
                MessageBox.Show("usuario e ou senha invalidos");
                tb_username.Focus();
                return;
            }
            else
            {
                dt = DataBase.EncontrarUsuario(produtivo);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0].Field<string>("T_SENHAUSUARIO") == senha) 
                    {
                        form1.lb_acesso.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                        Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                        form1.lb_nivel.Text = Globais.nivel.ToString();
                        Globais.logado = true;
                        Globais.user = produtivo;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario e senha não conferem");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado");
                }
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
