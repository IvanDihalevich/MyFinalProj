using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hltv.WinUI
{
    public partial class LoginForm : Form
    {
        private const string ConnectionString = "Server=DESKTOP-9KSTUSR\\SQLEXPRESS;Database=UserDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public LoginForm()
        {
            InitializeComponent();


        }



        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string wrUsr = txtUsername.Text;
            string wrPassword = txtPassword.Text;

            if (ValidateUser(wrUsr, wrPassword))
            {
                MessageBox.Show("Вхід успішний!");


               // this.Close();
                HltvForm hltv_form = new HltvForm();
                hltv_form.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Невірне ім'я користувача або пароль.");
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
