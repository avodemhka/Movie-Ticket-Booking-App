using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BnA
{
    public partial class Register : Form
    {
        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection("Data Source=BnA.db;Version=3;");
        }


        public Register()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void showPassReg_CheckedChanged(object sender, EventArgs e)
        {
            passReg.PasswordChar = showPassReg.Checked ? '\0' : '*';
            confirmPassReg.PasswordChar = showPassReg.Checked ? '\0' : '*';
        }

        private void loginReg_Click(object sender, EventArgs e)
        {
            Form1 logForm = new Form1();
            logForm.Show();

            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            string username = userReg.Text.Trim(); // Поле для нового имени пользователя
            string password = passReg.Text.Trim(); // Поле для нового пароля
            string confirmPassword = confirmPassReg.Text.Trim();

            // Проверка на заполненность полей
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка совпадения паролей
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passReg.Text = "";
                confirmPassReg.Text = "";
                passReg.Focus();
                return;
            }

            using (SQLiteConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    // Проверка, существует ли уже пользователь с таким именем
                    string checkQuery = "SELECT COUNT(*) FROM user WHERE user = @username";
                    SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        userReg.Text = "";
                        userReg.Focus();
                        return;
                    }

                    // Добавление нового пользователя в базу данных
                    string query = "INSERT INTO user (user, pass) VALUES (@username, @password)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Закрытие текущей формы и возврат на начальную форму
                    this.Hide();
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
