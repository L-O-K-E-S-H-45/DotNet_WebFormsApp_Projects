using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpMangSystem_WebFormsApp
{
    public partial class _Default : Page
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-4OR4SUH\SQLEXPRESS;Initial Catalog=EmpMangSystem_WebFormApp;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetEmployeeList();
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        protected void Insert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string Insert_Proc = "exec usp_InsertEmployee "+TextBox1.Text+", '"+TextBox2.Text+"'" +
                ", '"+TextBox3.Text+ "', '"+TextBox4.Text+ "', '"+RadioButtonList1.SelectedValue+ "', '"+DropDownList1.SelectedValue+"' ";
            SqlCommand InsertCommand = new SqlCommand(Insert_Proc, sqlConnection);
            InsertCommand.ExecuteNonQuery();
            sqlConnection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script",
                "alert('Successfully Inserted Employee data')", true);
            GetEmployeeList();
        }

        private void GetEmployeeList()
        {
            SqlCommand FetchCommand = new SqlCommand("exec usp_FetchAllEmployees", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(FetchCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string Update_Proc = "exec usp_UpdateEmployee " + TextBox1.Text + ", '" + TextBox2.Text + "' " +
                ", '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + RadioButtonList1.SelectedValue + "', '" + DropDownList1.SelectedValue + "' ";
                sqlConnection.Open();
                SqlCommand UpdateCommand = new SqlCommand(Update_Proc, sqlConnection);
                int nora = UpdateCommand.ExecuteNonQuery();
                if (nora > 0)
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script",
                        "alert('Successfully Updated Employee data')", true);
                else
                    throw new Exception("Employee not found for requested id: " + TextBox1.Text);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script",
                        "alert('Failed to Update Employee data b/z "+ex.Message+" ')", true);
            }
            finally
            {
                sqlConnection.Close();
                GetEmployeeList();
            }
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            // --- Not working
            //SqlCommand FetchCommand = new SqlCommand("usp_FetchEmployees", sqlConnection);
            //FetchCommand.CommandType = CommandType.StoredProcedure;
            //FetchCommand.Parameters.AddWithValue("@EmployeeId", string.IsNullOrEmpty(TextBox1.Text) ? null : (object)TextBox1.Text);
            //FetchCommand.Parameters.AddWithValue("@EmployeeName", value: string.IsNullOrEmpty(TextBox2.Text) ? null : (object)TextBox2.Text);
            //FetchCommand.Parameters.AddWithValue("@Email", value: string.IsNullOrEmpty(TextBox3.Text) ? null : (object)TextBox3.Text);
            //FetchCommand.Parameters.AddWithValue("@Salary", value: string.IsNullOrEmpty(TextBox4.Text) ? null : (object)TextBox4.Text);
            //FetchCommand.Parameters.AddWithValue("@Gender", value: RadioButtonList1.SelectedValue == null ? null : (object)RadioButtonList1.SelectedValue);
            //FetchCommand.Parameters.AddWithValue("@Role", value: DropDownList1.SelectedValue == null ? null : (object)DropDownList1.SelectedValue);

            string Fetch_Proc = "exec usp_FetchEmployees "+TextBox1.Text+" ";

            sqlConnection.Open();
            SqlCommand FetchCommand = new SqlCommand(Fetch_Proc, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(FetchCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
            sqlConnection.Close();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string Delete_Proc = "exec usp_DeleteEmployee " + int.Parse(TextBox1.Text) + " ";
                sqlConnection.Open();
                SqlCommand DeleteCommand = new SqlCommand(Delete_Proc, sqlConnection);
                int nora = DeleteCommand.ExecuteNonQuery();
                if (nora > 0)
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script",
                    "alert('Successfully Deleted Employee data')", true);
                else
                    throw new Exception("Employee not found for requested id: " + TextBox1.Text);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script",
                    "alert('Failed to Delete Employee data b/z " +  ex.Message+ "')", true);
            }
            finally
            {
                sqlConnection.Close();
                GetEmployeeList();
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
            //DropDownList1.Text = "";
            RadioButtonList1.ClearSelection();
            DropDownList1.ClearSelection();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void FetchByName_Click(object sender, EventArgs e)
        {
            string FetchByName_Proc = "exec usp_FetchByEmployeeName '" + TextBox2.Text + "' ";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(FetchByName_Proc, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
            sqlConnection.Close();
        }
    }
}