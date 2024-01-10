using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Members members;
        private void membersButton_Click(object sender, EventArgs e)
        {
            members = new Members();
            members.Show();
        }
        Staff staff;
        private void staffButton_Click(object sender, EventArgs e)
        {
            staff = new Staff();
            staff.Show();
        }
        Payments payments;
        private void paymentsButton_Click(object sender, EventArgs e)
        {
            payments = new Payments();
            payments.Show();
        }

        Materiels materiels;
        private void materielsButton_Click(object sender, EventArgs e)
        {
            materiels = new Materiels();
            materiels.Show();
        }

        Login login;
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            login = new Login();
            login.Show();
        }
    }
}
