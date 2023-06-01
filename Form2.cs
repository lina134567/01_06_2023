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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form

    {
        private string conn_string = @"Data Source=LAB206_2\SQLEXPRESS;Initial Catalog=Столовые приборы;Integrated Security = True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "столовые_приборыDataSet2._Лист1_". При необходимости она может быть перемещена или удалена.
            this.лист1_TableAdapter.Fill(this.столовые_приборыDataSet2._Лист1_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "столовые_приборыDataSet1.Table_1". При необходимости она может быть перемещена или удалена.
            this.table_1TableAdapter.Fill(this.столовые_приборыDataSet1.Table_1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn_string);

                string select = "SELECT * FROM [Столовые приборы].[dbo].[Лист1$] ORDER BY Стоимость";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 15)
                    {
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Chartreuse;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label7.Text = $"{b} из {a} записей";
            }
            catch
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn_string);

                string select = "SELECT * FROM [Столовые приборы].[dbo].[Лист1$] ORDER BY Стоимость DESC";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 15)
                    {
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Chartreuse;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label7.Text = $"{b} из {a} записей";
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                SqlConnection sqlConnection = new SqlConnection(conn_string);

                string select = "select * from [Столовые приборы].[dbo].[Лист1$]";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 15)
                    {
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Chartreuse;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label3.Text = $"{b} из {a} записей";
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn_string);

                string select = "Select * from [Столовые приборы].[dbo].[Лист1$] where Артикул Like '" + textBox3.Text + "%'";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 15)
                    {
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label7.Text = $"{b} из {a} записей";
            }
            catch
            {
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn_string);

                string select = "Select * from [Столовые приборы].[dbo].[Лист1$] where Стоимость Like '" + textBox2.Text + "%'";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 15)
                    {
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label7.Text = $"{b} из {a} записей";
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn_string);

                string select = "Select * from [Столовые приборы].[dbo].[Лист1$] where Наименование Like '" + textBox1.Text + "%'";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 15)
                    {
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label7.Text = $"{b} из {a} записей";
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
