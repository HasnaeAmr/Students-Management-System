using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etud
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER = localhost; DATABASE=etudiant ; UID=root; PASSWORD=;");

            try
            {//"Server=localhost;Database=etudiant;UID=root;Password=;"
                MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO etudiant(nom,prenom,filiere) VALUES('" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "')", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
      
                MessageBox.Show("L'étudiant " + textBox2.Text + " " + textBox3.Text + " est ajouté !");
                button7.PerformClick();
            }
            catch (Exception x)
            {
                MessageBox.Show(e + "");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER = localhost; DATABASE=etudiant ; UID=root; PASSWORD=;");
            String query = "UPDATE etudiant SET nom='" + textBox2.Text + "' , prenom='" + textBox3.Text + "' , filiere='" + textBox4.Text + "'  WHERE code = " + textBox1.Text + "";
            try
            {//"Server=localhost;Database=etudiant;UID=root;Password=;"
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds);
                MessageBox.Show("L'étudiant avec le code " + textBox1.Text + " est Modifié !");
            }
            catch (Exception x)
            {
                MessageBox.Show(e + "");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER = localhost; DATABASE=etudiant ; UID=root; PASSWORD=;");
            String query = "DELETE FROM etudiant WHERE code = " + textBox1.Text + "";
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds);
                MessageBox.Show("L'étudiant avec le code " + textBox1.Text + " est Supprimé !");
            }
            catch (Exception x)
            {
                MessageBox.Show(e + "");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER = localhost; DATABASE=etudiant ; UID=root; PASSWORD=;");
            String query = "SELECT * FROM etudiant WHERE code = " + textBox1.Text + "";
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Si une ligne est trouvée, récupérer la première ligne
                    DataRow row = ds.Tables[0].Rows[0];

                    // Lire les champs de la ligne (row)
                    textBox1.Text = row["code"].ToString();
                    textBox2.Text = row["nom"].ToString();
                    textBox3.Text = row["prenom"].ToString();
                    textBox4.Text = row["filiere"].ToString();

                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé avec ce code.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(e + "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER = localhost; DATABASE=etudiant ; UID=root; PASSWORD=;");
            String query = "SELECT * FROM etudiant";
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Si une ligne est trouvée, récupérer la première ligne
                    DataRow row = ds.Tables[0].Rows[0];

                    // Lire les champs de la ligne (row)
                    textBox1.Text = row["code"].ToString();
                    textBox2.Text = row["nom"].ToString();
                    textBox3.Text = row["prenom"].ToString();
                    textBox4.Text = row["filiere"].ToString();

                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(e + "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER = localhost; DATABASE=etudiant ; UID=root; PASSWORD=;");
            String query = "SELECT * FROM etudiant ORDER BY code DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);


            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Si une ligne est trouvée, récupérer la première ligne
                    DataRow row = ds.Tables[0].Rows[0];

                    // Lire les champs de la ligne (row)
                    textBox1.Text = row["code"].ToString();
                    textBox2.Text = row["nom"].ToString();
                    textBox3.Text = row["prenom"].ToString();
                    textBox4.Text = row["filiere"].ToString();

                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(e + "");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER = localhost; DATABASE=etudiant ; UID=root; PASSWORD=;");
            String query = "SELECT * FROM etudiant WHERE code< "+textBox1.Text+" ORDER BY code DESC LIMIT 1";
            


            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Si une ligne est trouvée, récupérer la première ligne
                    DataRow row = ds.Tables[0].Rows[0];

                    // Lire les champs de la ligne (row)
                    textBox1.Text = row["code"].ToString();
                    textBox2.Text = row["nom"].ToString();
                    textBox3.Text = row["prenom"].ToString();
                    textBox4.Text = row["filiere"].ToString();

                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé !");
                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(e + "");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=etudiant;uid=root;passwrod=;");
            String query = "SELECT * FROM etudiant WHERE code > "+textBox1.Text+" ORDER BY code ASC LIMIT 1";
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Si une ligne est trouvée, récupérer la première ligne
                    DataRow row = ds.Tables[0].Rows[0];

                    // Lire les champs de la ligne (row)
                    textBox1.Text = row["code"].ToString();
                    textBox2.Text = row["nom"].ToString();
                    textBox3.Text = row["prenom"].ToString();
                    textBox4.Text = row["filiere"].ToString();

                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé !");
                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(e + "");
            }

        }
    }
}

