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

namespace EmployeeManagementSystem_WindowsForms_3._1V
{
    public partial class Employee : Form
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-4OR4SUH\SQLEXPRESS;Initial Catalog=EmployeeManagementSystemDB;Integrated Security=True;");
        public Employee()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            string InserQuery = "Insert into Employees values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(InserQuery, SqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");
            SqlConnection.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection.Open();
                string UpdateQuery = "Update Employees set EmployeeName = '" + textBox2.Text + "' " +
                    ", Address = '" + textBox3.Text + "', Salary = '" + textBox4.Text + "' where EmployeeId = '" + textBox1.Text + "' ";
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, SqlConnection);
                UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Data Updated Succesfully");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SqlConnection.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            string DeleteQuery = "Delete from Employees where EmployeeId = '" + textBox1.Text + "' ";
            SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, SqlConnection);
            DeleteCommand.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully");
            SqlConnection.Close();
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            string FetchQuery = "Select * from Employees";
            SqlCommand FetchCommand = new SqlCommand(FetchQuery, SqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(FetchCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            _ = dataGridView1.DataBindings;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = comboBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
