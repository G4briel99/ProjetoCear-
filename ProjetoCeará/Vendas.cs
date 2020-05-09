using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCeará
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
           
        }
        MySqlConnection objCon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=bancodedados; password=usbw; Convert Zero Datetime = True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            objCon.Open();

            MySqlCommand objCmd = new MySqlCommand("SELECT*FROM estoque", objCon);

            objCmd.ExecuteNonQuery();

            MySqlDataAdapter abd = new MySqlDataAdapter(objCmd);

            DataTable dtobj = new DataTable();

            abd.Fill(dtobj);

            cmbproduto.ValueMember = "Nome";

            cmbproduto.DisplayMember = "Nome";

            this.cmbproduto.DataSource = dtobj;

            cmbproduto.AutoCompleteMode = AutoCompleteMode.Suggest;

            cmbproduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            objCon.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnatualizarprod_Click(object sender, EventArgs e)
        {
            objCon.Open();

            MySqlCommand objCmd = new MySqlCommand("SELECT*FROM estoque", objCon);

            objCmd.ExecuteNonQuery();

            MySqlDataAdapter abd = new MySqlDataAdapter(objCmd);

            DataTable dtobj = new DataTable();

            abd.Fill(dtobj);

            cmbproduto.ValueMember = "Nome";

            cmbproduto.DisplayMember = "Nome";

            this.cmbproduto.DataSource = dtobj;

            cmbproduto.AutoCompleteMode = AutoCompleteMode.Suggest;

            cmbproduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            objCon.Close();
        }
    }
}
