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
    public partial class F_CadColaborador : Form
    {
        public F_CadColaborador()
        {
            InitializeComponent();
            this.AcceptButton = btn_cadastrar;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string produtivo = tb_produtivo.Text;
            string setor = cb_setor.Text;
            if (nome != "" || produtivo != "" || setor != "")
            {
                DataBase.CadastrarColaborador(produtivo, nome, setor);
                this.Close();
            }

            

        }
    }
}
