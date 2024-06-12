using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MSSQLForCSharpProgrammer
{
    public partial class Form1 : Form

    {
        private SqlConnection sqlConnection = null;
        private List<string[]> rows = null;
        private List<string[]> filteredList = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {

                MessageBox.Show("Connection established !");
            }

            /*SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Products", sqlConnection);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            dataGridView2.DataSource = db.Tables[0];*/

            SqlDataReader dataReader = null;
            rows = new List<string[]>();
            string[] row = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT ProductName, QuantityPerUnit, UnitPrice FROM Products", sqlConnection);

                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[] {
                        Convert.ToString(dataReader["ProductName"]),
                        Convert.ToString(dataReader["QuantityPerUnit"]),
                        Convert.ToString(dataReader["UnitPrice"])
                    };
                    rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataReader.Close();
            }
            RefreshList(rows);
        }

        private void RefreshList(List<string[]> list)
        {

            listView2.Items.Clear();

            foreach (string[] row in list)
            {
                listView2.Items.Add(new ListViewItem(row));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Students] (Name, Surname, Birthday, Phone, Email) VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}')", sqlConnection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void SELECT_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(textBox6.Text, sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            MessageBox.Show("Button clicked");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlDataReader dataReader = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT ProductName, QuantityPerUnit, UnitPrice FROM Products", sqlConnection);

                dataReader = sqlCommand.ExecuteReader();

                ListViewItem item = null;

                while (dataReader.Read())
                {
                    item = new ListViewItem(new string[] { Convert.ToString(dataReader["ProductName"]), Convert.ToString(dataReader["QuantityPerUnit"]), Convert.ToString(dataReader["UnitPrice"]) });

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"ProductName LIKE '%{textBox8.Text}%'";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"UnitsInStock <= 10";
                    break;
                case 1:
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"UnitsInStock > 10 AND UnitsInStock <=50";
                    break;
                case 2:
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"UnitsInStock > 50";
                    break;
                case 3:
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            filteredList = rows.Where((item) => item[0].ToLower().Contains(textBox9.Text.ToLower())).ToList();
            RefreshList(filteredList);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    filteredList = rows.Where((item) => Double.Parse(item[2]) <= 10).ToList();
                    RefreshList(filteredList);
                    break;
                case 1:
                    filteredList = rows.Where((item) => Double.Parse(item[2]) > 10 && Double.Parse(item[2]) <= 100).ToList();
                    RefreshList(filteredList);
                    break;
                case 2:
                    filteredList = rows.Where((item) => Double.Parse(item[2]) > 100).ToList();
                    RefreshList(filteredList);
                    break;
                case 3:
                    RefreshList(rows);
                    break;
            }
        }
    }
}

