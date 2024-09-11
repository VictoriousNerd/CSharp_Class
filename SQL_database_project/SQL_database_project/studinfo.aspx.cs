using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SQL_database_project
{
    public partial class studinfo : System.Web.UI.Page
    {            
        SqlConnection conn = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Server=localhost\\SQLEXPRESS; Database=student_information; Trusted_Connection=True;";
        }

        protected void displayUser_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dbo.student_information", conn);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            stuInfo_View.DataSource = dr;
            stuInfo_View.DataBind();
            conn.Close();
        }
        protected void submitUser_Click(object sender, EventArgs e)
        {
            double stuRollNum = Convert.ToDouble(stuRollNum_Text.Text);
            string stuName = stuName_Text.Text;
            string stuCourName = stuCourseName_Text.Text;
            double stuContNum = Convert.ToDouble(stuContNum_Text.Text);
            string stuEmail = stuEmail_Text.Text;

            bool userExists = false;

            string selectQuery = "select count(*) from Users where stuRollNum = @stuRollNum";

            conn.Open();

            SqlCommand command = new SqlCommand(selectQuery, conn);

            command.Parameters.AddWithValue("@stuRollNum", stuRollNum);

            try
            {
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    userExists = true;
                    Response.Write("Student is already registered.");
                }
            }
            catch (SqlException ex) 
            { 
                
            }
            if (!userExists)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into dbo.student_information values(" + stuRollNum + ", '" + stuName + "', '" + stuCourName + "', '" + stuContNum + "', '" + stuEmail + "')";
                cmd.Connection = conn;

                int res = cmd.ExecuteNonQuery();
                Response.Write(res + "\trecord inserted");


            }

            conn.Close();

            ClearFormFields();
        }
        protected void updateUser_Click(Object sender, EventArgs e)
        {
            double stuRollNum = Convert.ToDouble(stuRollNum_Text.Text);
            string stuName = stuName_Text.Text;
            string stuCourName = stuCourseName_Text.Text;
            double stuContNum = Convert.ToDouble(stuContNum_Text.Text);
            string stuEmail = stuEmail_Text.Text;

            try
            {
                 conn.Open();
                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandText = "Update dbo.student_information set stuRollNum='" + stuName + "', '" + stuCourName + "', '" + stuContNum + "', '" + stuEmail + "'";
                 cmd.Connection = conn;

                 int res = cmd.ExecuteNonQuery();
                 Response.Write(res + "\trecord updated");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();

                ClearFormFields();
            }
        }
        protected void deleteUser_Click(object sender, EventArgs e)
        {
            double stuRollNum = Convert.ToDouble(stuRollNum_Text.Text);

            SqlCommand cmd = new SqlCommand("Delete from dbo.student_information where stuRollNum=" + stuRollNum + "", conn);
            try
            {
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                Response.Write(res + "\trecord deleted");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();

                ClearFormFields();
            }
        }
        private void ClearFormFields()
        {
            stuRollNum_Text.Text = "";
            stuName_Text.Text = "";
            stuCourseName_Text.Text = "";
            stuContNum_Text.Text = "";
            stuEmail_Text.Text = "";
        }
    }
}
