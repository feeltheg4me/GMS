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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Home home;
        private void loginButton_Click(object sender, EventArgs e)
        {
            OnLogin();
        }

        private void OnLogin()
        {
            try
            {
                String login = loginTB.Text;
                String psswrd = passwordTB.Text;
               
                if ((login == "") || (psswrd == ""))
                {
                    MessageBox.Show("Données manquantes !");
                }
                else
                {
                    this.Close();
                    home = new Home();
                    home.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        SignUp signUp;
        private void signUpLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            signUp = new SignUp();
            signUp.Show();
        }
    }
}
