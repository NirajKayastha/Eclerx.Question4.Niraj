using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclerx.Question4.Niraj
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {


            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["EclerxConn"].ConnectionString))
                {
                    using (cmd = new SqlCommand("usp_AddNewEmployee", con)) //
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeId", txtEmployeeNo.Text);
                        cmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text);
                        cmd.Parameters.AddWithValue("@EmployeeSalary", txtSalary.Text);

                        //string value = "";
                        //bool isChecked = radioButtonPayroll.Checked;
                        //if (isChecked)
                        //    value = radioButtonPayroll.Text;
                        //else
                        //    value = radioButtonConsultant.Text;

                        //cmd.Parameters.AddWithValue("@EmployeeType", value);



                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();

                        }
                        cmd.ExecuteNonQuery();


                        using (adapter = new SqlDataAdapter("Select * from Employee", con))
                        {
                            // data in gridview
                            ds = new DataSet();
                            adapter.Fill(ds, "Employee");
                            dataGridViewEmployee.DataSource = ds.Tables["Employee"];

                        }

                    }
                }
            }
            catch (Exception)
            {

                
            }
          
            MessageBox.Show("New Employee Created");
        }

        private void ClearTxt()
        {
            //clear text
            txtEmployeeNo.Text = "";
            txtEmployeeName.Text = "";
            txtSalary.Text = "";
        }


        private void btnReset_Click(object sender, EventArgs e)
        {

            ClearTxt();
        }
  
        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text.Length > 3 && txtEmployeeName.Text.Length > 20 )
            {
                MessageBox.Show("You need to write more than 3 characters and less than 20 ");
            }
        }
    }
}
