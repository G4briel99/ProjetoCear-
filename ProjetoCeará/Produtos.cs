using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCeará
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }
        MySqlConnection objCon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=bancodedados; password=usbw; Convert Zero Datetime = True");
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                objCon.Open();

                txtpreco.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", txtpreco.Text);
                int qtd = Convert.ToInt32(txtquantidade.Text);
                string datevenc = datevalidade.Value.ToString("yyyy-MM-dd");

                if (rbtnhinserir.Checked)
                {
                MySqlCommand objCmd = new MySqlCommand("INSERT INTO `bancodedados`.`estoque` (`Nome`, `Descricao`, `Validade`, `Preco`, `Quantidade`) VALUES ('" + txtname.Text + "', '" + txtdesc.Text + "', '" + datevenc + "', '" + txtpreco.Text + "', '" + qtd + "');", objCon);
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
                txtdesc.Clear();
                datevalidade.Text = "01/01/2020";
                txtpreco.Clear();
                txtquantidade.Clear();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                objCon.Close();


                txtid.Clear();
                txtname.Clear();
                txtdesc.Clear();
                datevalidade.Text = "01/01/2020";
                txtpreco.Clear();
                txtquantidade.Clear();
            }
        }

        private void btneditarprod_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtid.Text == String.Empty))
                {
                    objCon.Open();
                    string datevenc = datevalidade.Value.ToString("yyyy-MM-dd"); 
                    if (rbtnheditar.Checked)
                    {
                    MySqlCommand objCmd = new MySqlCommand("UPDATE `bancodedados`.`estoque` SET `Nome` = '" + txtname.Text + "', `Descricao` = '" + txtdesc.Text + "', `Validade` = '" + datevenc + "', `Preco` = '" + txtpreco.Text + "', `Quantidade` = '" + txtquantidade.Text + "' WHERE (`id` = '" + txtid.Text + "');", objCon);
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Atualizado Com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Confirme o botão de Editar");
                    }
                    objCon.Close();
                    txtid.Clear();
                    txtname.Clear();
                    txtdesc.Clear();
                    datevalidade.Text = "01/01/2020";
                    txtpreco.Clear();
                    txtquantidade.Clear();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                objCon.Close();


                txtid.Clear();
                txtname.Clear();
                txtdesc.Clear();
                datevalidade.Text = "01/01/2020";
                txtpreco.Clear();
                txtquantidade.Clear();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtpesquisa.Text = "";
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            objCon.Open();

            MySqlCommand objCmd = new MySqlCommand("SELECT * FROM estoque", objCon);


            MySqlDataAdapter Adapter = new MySqlDataAdapter(objCmd);
            DataTable table = new DataTable();

            Adapter.Fill(table);
            dgvlista.DataSource = table;

            objCon.Close();

            dgvlista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvlista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                DataGridViewRow row = this.dgvlista.Rows[e.RowIndex];

                txtid.Text = row.Cells[0].Value.ToString();
                txtname.Text = row.Cells[1].Value.ToString();
                txtdesc.Text = row.Cells[2].Value.ToString();
                datevalidade.Text = row.Cells[3].Value.ToString();
                txtpreco.Text = row.Cells[4].Value.ToString();
                txtquantidade.Text = row.Cells[5].Value.ToString();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                objCon.Close();


                txtid.Clear();
                txtname.Clear();
                txtdesc.Clear();
                datevalidade.Text = "01/01/2020";
                txtpreco.Clear();
                txtquantidade.Clear();
            }
        }

        private void btnexcluirprod_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtid.Text == String.Empty))
                {
                    objCon.Open();

                    if (rbtnhexcluir.Checked)
                    {
                        if (rbtnconfirmar.Checked)
                        {
                            MySqlCommand objCmd = new MySqlCommand("DELETE FROM `bancodedados`.`estoque` WHERE (`id` = '" + txtid.Text + "');", objCon);
                            objCmd.ExecuteNonQuery();
                    MessageBox.Show("Deletado Com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rbtnconfirmar.Checked = false;

                        }
                        else
                        {
                            MessageBox.Show("Você não confirmou que quer deletar este item");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Confirme o botão de Excluir");
                    }

                    rbtnconfirmar.Checked = false;



                    objCon.Close();

                    txtid.Clear();
                    txtname.Clear();
                    txtdesc.Clear();
                    datevalidade.Text = "01/01/2020";
                    txtpreco.Clear();
                    txtquantidade.Clear();


                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
                objCon.Close();


                txtid.Clear();
                txtname.Clear();
                txtdesc.Clear();
                datevalidade.Text = "01/01/2020";
                txtpreco.Clear();
                txtquantidade.Clear();

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtdesc.Clear();
            datevalidade.Text = "01/01/2020";
            txtpreco.Clear();
            txtquantidade.Clear();
        }

        private void rbtnconfirmar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnhinserir_CheckedChanged(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtdesc.Clear();
            datevalidade.Text = "01/01/2020";
            txtpreco.Clear();
            txtquantidade.Clear();
            txtname.Enabled = true;
            txtdesc.Enabled = true;
            datevalidade.Enabled = true;
            txtpreco.Enabled = true;
            txtquantidade.Enabled = true;
            btneditarprod.Enabled = false;
            btnexcluirprod.Enabled = false;
            this.btninserirprod.Enabled = true;
            rbtnconfirmar.Checked = false;
        }

        private void rbtnheditar_CheckedChanged(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtdesc.Clear();
            datevalidade.Text = "01/01/2020";
            txtpreco.Clear();
            txtquantidade.Clear();
            txtname.Enabled = true;
            txtdesc.Enabled = true;
            datevalidade.Enabled = true;
            txtpreco.Enabled = true;
            txtquantidade.Enabled = true;
            btninserirprod.Enabled = false;
            btnexcluirprod.Enabled = false;
            this.btneditarprod.Enabled = true;
            rbtnconfirmar.Checked = false;
        }

        private void rbtnhexcluir_CheckedChanged(object sender, EventArgs e)
        {
            txtname.Enabled = false;
            txtdesc.Enabled = false;
            datevalidade.Enabled = false;
            txtpreco.Enabled = false;
            txtquantidade.Enabled = false;
            btneditarprod.Enabled = false;
            btninserirprod.Enabled = false;
            this.btnexcluirprod.Enabled = true;
            rbtnconfirmar.Checked = false;
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            objCon.Open();

            MySqlCommand objCmd = new MySqlCommand("SELECT * FROM estoque WHERE CONCAT(`Nome`, `Descricao`, `Validade`, `Preco`, `Quantidade`) LIKE '" + txtpesquisa.Text + "%';", objCon);

            objCmd.ExecuteNonQuery();
            MySqlDataAdapter Adapter = new MySqlDataAdapter(objCmd);
            DataTable table = new DataTable();

            Adapter.Fill(table);
            dgvlista.DataSource = table;

            dgvlista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvlista.ClearSelection();
            objCon.Close();
        }
    }
}