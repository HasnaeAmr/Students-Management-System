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
using MySql.Data.MySqlClient; 

namespace etud
{
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; DATABASE=etudiant ; UID=root; PASSWORD=;");
        

        public Form3()
        {
            InitializeComponent();
            try
            {//"Server=localhost;Database=etudiant;UID=root;Password=;"
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM etudiant", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
}
            catch(Exception e) {
                MessageBox.Show(e + "");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
