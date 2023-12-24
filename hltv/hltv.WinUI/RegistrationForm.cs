using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace hltv.WinUI
{
    public partial class RegistrationForm : Form
    {
        private const string ConnectionString = "Server=DESKTOP-9KSTUSR\\SQLEXPRESS;Database=UserDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string wrName = txtNewUsername.Text;
            string wrPassword = txtNewPassword.Text;

            if (CheckIfUserExists(wrName))
            {
                MessageBox.Show("Користувач з таким ім'ям вже існує.");
            }
            else
            {
                this.Close();
                SaveUser(wrName, wrPassword);
                MessageBox.Show("Реєстрація успішна!");
            }

        }

        private bool CheckIfUserExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void SaveUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
