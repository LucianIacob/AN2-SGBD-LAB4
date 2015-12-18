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

namespace LAB4_SGBD
{
    public partial class Form1 : Form
    {
        SqlTransaction sqlTransaction;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new System.Data.SqlClient.SqlConnection("Data Source=localhost;Initial Catalog=stoc;Integrated Security=True");
//            sqlConnection1 = new System.Data.SqlClient.SqlConnection("Data Source=localhost;Initial Catalog=stoc;Integrated Security=True");
        }

        private void loadProduse()
        {
            lstProduse.View = View.Details;
            lstProduse.GridLines = true;
            lstProduse.FullRowSelect = true;
            string[] arr = new string[4];
            lstProduse.Items.Clear();
            ListViewItem item;

            sqlCommand = new SqlCommand("select * from Produse", sqlConnection, sqlTransaction);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                arr[0] = reader.GetValue(0).ToString();
                arr[1] = reader.GetValue(1).ToString();
                arr[2] = reader.GetValue(2).ToString();
                item = new ListViewItem(arr);
                item.BackColor = Color.LightGray;
                lstProduse.Items.Add(item);
            }
            reader.Close();
        }

        private void lstProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadStocks();
        }

        private void loadStocks()
        {
            lstStocuri.View = View.Details;
            lstStocuri.GridLines = true;
            lstStocuri.FullRowSelect = true;
            string[] arr = new string[5];
            lstStocuri.Items.Clear();
            ListViewItem item;
            string cod = null;
            if (lstProduse.SelectedItems.Count > 0)
            {
                cod = lstProduse.SelectedItems[0].SubItems[0].Text;
                sqlCommand = new SqlCommand("select * from Stocuri where codProdus = " + cod, sqlConnection, sqlTransaction);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    arr[0] = reader.GetValue(0).ToString();
                    arr[1] = reader.GetValue(1).ToString();
                    arr[2] = reader.GetValue(2).ToString();
                    arr[3] = reader.GetValue(3).ToString();
                    item = new ListViewItem(arr);
                    item.BackColor = Color.LightGray;
                    lstStocuri.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstProduse.SelectedItems.Count > 0)
            {
                string cod = lstProduse.SelectedItems[0].SubItems[0].Text;
                sqlCommand = new SqlCommand("select stoc from Stocuri where codProdus = " + cod + " and luna = '" + txtMonth.Text + "' and an = " + txtYear.Text, sqlConnection, sqlTransaction);
                if (sqlCommand.ExecuteScalar() != null)
                {
                    int stoc = (int)sqlCommand.ExecuteScalar();
                    txtStock.Text = stoc.ToString();
                    txtMonth.Clear();
                    txtYear.Clear();
                }
                else
                    MessageBox.Show("Nu exista inregistrari pentru produsul selectat \r\nin luna si anul specificat.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstProduse.SelectedItems.Count > 0)
                {
                    string cod = lstProduse.SelectedItems[0].SubItems[0].Text;
                    string luna = txtMonth.Text;
                    string anul = txtYear.Text;

                    sqlCommand = new SqlCommand("select stoc from Stocuri where codProdus = " + cod + " and luna = '" + txtMonth.Text + "' and an = " + txtYear.Text, sqlConnection, sqlTransaction);
                    if (sqlCommand.ExecuteScalar() != null)
                    {
                        int stoc = (int)sqlCommand.ExecuteScalar();
                        stoc += Int32.Parse(txtStock.Text);
                        sqlCommand = new SqlCommand("update Stocuri set stoc = " + stoc.ToString() + " where codProdus = " + cod + " and luna = '" + luna + "' and an = " + anul, sqlConnection, sqlTransaction);
                        sqlCommand.ExecuteNonQuery();
                        this.loadStocks();
                        return;
                    }
                    sqlCommand = new SqlCommand("insert into Stocuri values (" + cod + ", '" + luna + "', " + anul + ", " + txtStock.Text + ")", sqlConnection, sqlTransaction);
                    sqlCommand.ExecuteNonQuery();
                    loadStocks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstStocuri.SelectedItems.Count > 0)
            {
                string cod = lstStocuri.SelectedItems[0].SubItems[0].Text;
                string luna = lstStocuri.SelectedItems[0].SubItems[1].Text;
                string an = lstStocuri.SelectedItems[0].SubItems[2].Text;
                sqlCommand = new SqlCommand("delete from Stocuri where codProdus = " + cod + " and luna = '" + luna + "' and an = " + an, sqlConnection, sqlTransaction);
                sqlCommand.ExecuteNonQuery();
                this.loadStocks();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //sqlConnection.Open();
            this.loadProduse();
            //sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {    
                sqlConnection.Open();
                if (radioButton1.Checked)
                    sqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                if (radioButton2.Checked)
                    sqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.ReadUncommitted);
                if (radioButton3.Checked)
                    sqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.RepeatableRead);
               // if (radioButton5.Checked)
                 //   sqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Snapshot);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstStocuri_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEndTR_Click(object sender, EventArgs e)
        {
            try
            {
                sqlTransaction.Commit();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //sqlTransaction.Rollback();
        }

        private void sqlConnection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }
    }
}