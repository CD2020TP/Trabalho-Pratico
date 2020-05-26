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

namespace Client
{
    public partial class RegisterWindow : Form
    {
        //string de coexao a base de dados local
        string connectionString = @"Data Source=DESKTOP-I0BR7JC;Initial Catalog=Contas CD;Integrated Security=True";

        public RegisterWindow()
        {
            InitializeComponent();
        }


        private void Register_Click(object sender, EventArgs e)
        {
            // verificar se todos os campos estao preenchidos
            if (STBox.Text == "[Select]" || Course.Text == "" || CourseUnit.Text == "" || Username.Text == "" || Password.Text == "" || ConfirmPass.Text == "")
                MessageBox.Show("Por favor preencha os campos obrigatorios");
            //verificar se a pass colocada e a de corfirmacao sao iguais
            else if (Password.Text != ConfirmPass.Text)
                MessageBox.Show("As Palavra-passe nao sao iguais");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    //abrir conexao a base de dados
                    sqlCon.Open();
                    //Funcao na base de dados para adicionar conta e guradar dados
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    //Adicionar os parametrosd que encontra escrito apos clicar no botao "criar"
                    sqlCmd.Parameters.AddWithValue("@Profissao", STBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Curso", Course.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Unidade", CourseUnit.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Utilizador", Username.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Passe", Password.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    //mensagem de sucesso
                    MessageBox.Show("Conta criada com sucesso");
                    Clear();
                }

            }
            //funcao para limpar caixas de texto
            void Clear()
            {
                STBox.Text = Course.Text = CourseUnit.Text = Username.Text = Password.Text = ConfirmPass.Text = "";
            }

        }
    }
}
