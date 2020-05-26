using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class LoginWindow : Form
    {
        //sting para fazer conexao com a base de dados local
        string conString = @"Data Source=DESKTOP-I0BR7JC;Initial Catalog=Contas CD;Integrated Security=True";

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //criar a conexao
            SqlConnection con = new SqlConnection(conString);
            //abrir base de dados
            con.Open();
            //comando para comparar os dados escritos com as colunas utilizador e passe da base de dados 
            SqlCommand cmd = new SqlCommand("select * from tblContas where Utilizador = '" + LoginUT.Text + "' and Passe = '" + LoginPass.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                ClientChat c1 = new ClientChat();
                c1.ShowDialog();
            }
            else
            {
                //mensagem de erro caso a conta nao esteja na base de dados
                MessageBox.Show("Password ou Nome de Utilizador nao estao corretos");
            }

            Clear();


        }

        //funcao para limpar caixas de texto
        void Clear()
        {
            LoginUT.Text = LoginPass.Text = "";
        }
    
    }
}
