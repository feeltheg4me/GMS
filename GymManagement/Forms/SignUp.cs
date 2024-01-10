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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagement.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        Login login;
        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = loginTB.Text;
            var psswrd = passwordTB.Text;
            var fct = comboBox1.Text;

            if ((login == "") || (psswrd == "") || (fct == ""))
            {
                MessageBox.Show("Données manquantes !");
            }
            else
            {
                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = "insert into User (Login,Password,Function) values('" + login + "','" + psswrd + "','" + fct + "')";

                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //da.Fill(ds);

                MessageBox.Show("Data saved !");

                loginLabel_Click(null, null);
            }
        }
    }
}
