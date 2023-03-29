using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegistroDeAcesso
{
    public partial class F_AltUser : Form
    {
        public F_AltUser()
        {
            InitializeComponent();
            this.AcceptButton = btn_consultar;
        }

        public static string ProdutivoConsultado = "";
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ProdutivoConsultado = tb_produtivo.Text;
            tb_produtivo.Text = "";
            lb_info.Visible = false;
            using DataTable dt = DataBase.EncontrarUsuario(ProdutivoConsultado);
            if (dt.Rows.Count == 1)
            {
                btn_alterar.Enabled = true;
                tb_novasenha1.Enabled = false;
                tb_novasenha2.Enabled = false;
                if (!(Globais.nivel == 0))
                {
                    tb_newNome.Enabled = true;
                    tb_newProdutivo.Enabled = true;
                    tb_newNome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                    tb_newProdutivo.Text = dt.Rows[0].Field<string>("T_PRODUTIVO");
                }
                else
                {
                    MessageBox.Show("Seu nivel de acesso permite apenas alteração da senha.");
                    if (ProdutivoConsultado == Globais.user) //se o usuario consultar o proprio produtivo, será habilitado a opção de alterar senha
                    {
                        tb_novasenha1.Enabled = true;
                        tb_novasenha2.Enabled = true;
                    }
                }

                switch (Globais.nivel)
                {
                    case 1:                        
                        rb_nivel1.Enabled = true;
                        rb_nivel0.Enabled = true;
                        break;
                    case 2:
                        rb_nivel2.Enabled = true;
                        rb_nivel1.Enabled = true;
                        rb_nivel0.Enabled = true;
                        //habilita a alteração de senha para terceiros
                        tb_novasenha1.Enabled = true;
                        tb_novasenha2.Enabled = true;
                        // habilita remoção do usuario
                        btn_remove.Enabled = true;
                        break;
                }
            }
            else
            {
                lb_info.Text = "Produtivo não encontrado";
                lb_info.Visible = true;
            }
            tb_produtivo.Text = "";
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string obs = "Dados alterados:";
            //nome do usuario
            if (tb_newNome.Enabled && !(tb_newNome.Text == ""))
            {
                DataBase.AlterarDadosDoUsuario(ProdutivoConsultado, "T_NOMEUSUARIO", tb_newNome.Text);
                obs += "- Nome";
            }
            //produtivo do usuario
            if (tb_newProdutivo.Enabled && !(tb_newProdutivo.Text == ""))
            {
                DataBase.AlterarDadosDoUsuario(ProdutivoConsultado, "T_PRODUTIVO", tb_newProdutivo.Text);
                obs += "- Produtivo";
            }
            //alteração da senha por nivel
            if (Globais.nivel == 2)
            {
                if (tb_novasenha1.Text == tb_novasenha2.Text && !(tb_novasenha1.Text == ""))
                {
                    DataBase.AlterarDadosDoUsuario(ProdutivoConsultado, "T_SENHAUSUARIO", tb_novasenha1.Text);
                    obs += "- Senha";
                }
                else
                {
                    MessageBox.Show("Favor verificar se as senhas foram inseridas corretamente");
                }
            }
            // alteração da propria senha
            else if (ProdutivoConsultado == Globais.user && tb_novasenha1 == tb_novasenha2)
            {
                if (tb_novasenha1 == tb_novasenha2 && !(tb_novasenha1.Text == ""))
                {
                    DataBase.AlterarDadosDoUsuario(ProdutivoConsultado, "T_SENHAUSUARIO", tb_novasenha1.Text);
                    obs += "- Senha";
                }
                else
                {
                    MessageBox.Show("Favor verificar se as senhas foram inseridas corretamente");
                }
            }

            //alteração de nivel de acesso:

                if (rb_nivel0.Checked)
                {
                    DataBase.AlterarDadosDoUsuario(ProdutivoConsultado, "N_NIVELUSUARIO", "0");
                    obs += "- Nivel de acesso";
                }
                else if (rb_nivel1.Checked)
                {
                    DataBase.AlterarDadosDoUsuario(ProdutivoConsultado, "N_NIVELUSUARIO", "1");
                    obs += "- Nivel de acesso";
                }
                else if (rb_nivel2.Checked)
                {
                    DataBase.AlterarDadosDoUsuario(ProdutivoConsultado, "N_NIVELUSUARIO", "2");
                    obs += "- Nivel de acesso";
                }
            BlockScreen();
            MessageBox.Show(obs);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == 2)
            {
                DialogResult result = MessageBox.Show("Deseja remover o usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataBase.RemoverUsuario(ProdutivoConsultado);
                    MessageBox.Show("Usuario Removido!");
                }
                else
                {
                    MessageBox.Show("Remoção cancelada!");
                }
            }
        }
        private void BlockScreen() 
        {
            tb_novasenha1.Enabled = false;
            tb_novasenha2.Enabled = false;
            tb_newNome.Enabled = false;
            tb_newProdutivo.Enabled = false;
            rb_nivel0.Enabled = false;
            rb_nivel1.Enabled = false;
            rb_nivel2.Enabled = false;
            btn_alterar.Enabled = false;
            btn_remove.Enabled = false;                
        }
    }
}
