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
    public partial class Members : Form
    {
        int id = 0;
        public Members()
        {
            InitializeComponent();
        }

        public void Showdata()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                SqlDataAdapter adpt = new SqlDataAdapter("select * from Members", conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur !");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((id != 0) && (MessageBox.Show("Ce membre va etre éffacé ! , confirmer ?", "Effacer", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from Membre where Id= " + id + "";

                    cmd.ExecuteNonQuery();
                    dataGridView1.Refresh();
                    MessageBox.Show("Membre effacé.");
                    conn.Close();
                    ClearForm();
                    Showdata();
                    id = 0;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Sélectionner un membre du staff.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String prenom = prenomTB.Text;
            String nom = nomTB.Text;
            String age = ageTB.Text;
            String telephone = phoneTB.Text;
            String email = emailTB.Text;
            String adresse = adresseTB.Text;
            String dateEntree = dateTimePicker1.Text;
            String sexe = "";
            int membership = 0;
            if ((prenom == "") || (nom == "") || (telephone == "") || (sexe == "") || (age == "") ||
                    (typeAbonnementCB.Text == "") )
            {
                MessageBox.Show("Données manquantes !");
            }
            else
            {
                membership = typeAbonnementCB.SelectedIndex;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Membre (Prenom,Nom,Age,Sexe,Telephone,Email,DateEntree,Adresse,Membership) values('" + prenom + "','" + nom + "','" + age + "','" + sexe + "','" + telephone + "','" + email + "','" + dateEntree + "','" + adresse + "','" + membership + "')";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Data saved !");
            }



        }

        private void ClearForm()
        {
            prenomTB.Clear();
            nomTB.Clear();
            ageTB.Clear();
            phoneTB.Clear();
            emailTB.Clear();
            adresseTB.Clear();
            typeAbonnementCB.ResetText();
            dateTimePicker1.ResetText();
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String prenom = prenomTB.Text;
            String nom = nomTB.Text;
            String age = ageTB.Text;
            String telephone = phoneTB.Text;
            String email = emailTB.Text;
            String adresse = adresseTB.Text;
            String dateEntree = dateTimePicker1.Text;
            String sexe = "";
            int membership = 0;
            if ((prenom == "") || (nom == "") || (telephone == "") || (sexe == "") || (age == "") ||
                    (typeAbonnementCB.Text == "") || id <= 0)
            {
                MessageBox.Show("Données manquantes !");
            }
            else
            {
                membership = typeAbonnementCB.SelectedIndex;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE Membre SET Prenom = '"+ prenom + "',Nom = '"+ nom + "',Age = '"+ age +"'," +
                    "Sexe = '"+ sexe + "',Telephone = '"+ telephone + "',Email = '"+ email + "',DateEntree = '" + dateEntree +"'," +
                    " Adresse = '" + adresse + "',Membership = '" + membership + "' WHERE Id = '" + id+"'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Data updated !");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((searchTB.Text != "") && (searchTB.Text != "Entrer prenom"))
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Membre where Prenom='" + searchTB.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Entrer le prénom du membre.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchTB_MouseClick(object sender, MouseEventArgs e)
        {
            searchTB.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            searchTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            prenomTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nomTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}