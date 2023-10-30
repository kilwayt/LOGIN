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

namespace LOGIN
{
    public partial class Form2 : Form
    {
        string con = "Data Source=.;Initial Catalog=gestion_ecole;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable datatable;
    

    
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataAdapter =
                new SqlDataAdapter("SELECT * FROM student", con);
            datatable = new DataTable();
            dataAdapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }
    }
}
