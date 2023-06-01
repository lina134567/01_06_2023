using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
        
    {
        DataBase db = new DataBase();
        private string conn_string = @"Data Source=LAB206_2\SQLEXPRESS;Initial Catalog=Столовые приборы;Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var LoginUser = textBox1.Text;
            var ParolUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select loginDEhmn2018, a|Iz|7 from Reg where LoginUser = '{LoginUser}' and ParolUser = '{ParolUser}'";

            SqlCommand command = new SqlCommand(querystring, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

