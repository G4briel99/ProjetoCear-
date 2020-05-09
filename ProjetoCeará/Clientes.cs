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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        MySqlConnection objCon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=bancodedados; password=usbw; Convert Zero Datetime = True");
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                objCon.Open();


                if (rbtnhinserir.Checked)
                {
                    MySqlCommand objCmd = new MySqlCommand("INSERT INTO `bancodedados`.`clientes` (`Nome`, `Sobrenome`, `Documentos`, `Codigo`, `Telefone`, `Conta`) VALUES ('"+txtname.Text+"', '"+txtlastname.Text+"', '"+txtdoc.Text+"', '"+txttel.Text+"', '"+txtconta.Text+"', '"+txtcodigo.Text+"');", objCon);
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Inserido com Sucesso!", "OK");

                }
                else
                {
                    MessageBox.Show("Selecione a opção Inserir");
                }





                objCon.Close();


                txtid.Clear();
                txtname.Clear();
              
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                objCon.Close();


                txtid.Clear();
                txtname.Clear();
               
            }
        }

        private void dgvlista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvlista.Rows[e.RowIndex];

            txtid.Text = row.Cells[0].Value.ToString();
            txtname.Text = row.Cells[1].Value.ToString();
            txtlastname.Text = row.Cells[2].Value.ToString();
            txtdoc.Text = row.Cells[3].Value.ToString();
            txttel.Text = row.Cells[4].Value.ToString();
            txtconta.Text = row.Cells[5].Value.ToString();
            txtcodigo.Text = row.Cells[6].Value.ToString();
        }
    }
}
    

