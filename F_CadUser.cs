using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeAcesso
{
    public partial class F_CadUser : Form
    {
        public F_CadUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            if (tb_senha1.Text == tb_senha2.Text)
            {
                string produtivo = tb_produtivo.Text;
                string nome = tb_nome.Text;
                string senha = tb_senha2.Text;
                DataBase.CadastrarUsuario(produtivo, nome, senha);
                tb_produtivo.Text = "";
                tb_nome.Text = "";
                tb_senha2.Text = "";
                tb_senha1.Text = "";
            }
            else
            {
                lb_span.Text = "Senhas Não Conferem";
                lb_span.Visible = true;
            }
        }

    }
}
