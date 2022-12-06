namespace Micro_Services_Student_App.StudentRepository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Micro_Services_Student_App.Models;
    using System.Data.SqlClient;
    using System.Data;
    using Microsoft.Extensions.Options;
    using System.Configuration;
    using Micro_Services_Student_App.DBConn;
    using Microsoft.Win32;
    using System.Drawing;
    using Microsoft.AspNetCore.Components.Web;

    public class Student:IStudent
    {
        //private readonly ConnectionStringSettings _connection;
        //public StudentRepository(IOptions<ConnectionStringSettings> connection)
        // {
        //     _connection = connection.Value;
        // }
        string connectionString = ConnectionString.CName;
        public void AddStudent(StudentRegistor registor)
        {
            var ds = new DataSet();
            var da = new SqlDataAdapter();
           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_AddStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;   
                
                cmd.Parameters.AddWithValue("@StudentId", registor.StudentId);
                cmd.Parameters.AddWithValue("@FirstName", registor.FirstName);
                cmd.Parameters.AddWithValue("@LastName", registor.LastName);
                cmd.Parameters.AddWithValue("@CasteCategory", registor.CasteCategory);
                cmd.Parameters.AddWithValue("@Email", registor.Email);
                cmd.Parameters.AddWithValue("@Country", registor.Country);
                cmd.Parameters.AddWithValue("@State", registor.State);
                cmd.Parameters.AddWithValue("@City", registor.City);
                cmd.Parameters.AddWithValue("@StdPhoto", registor.Photo);
                cmd.Parameters.AddWithValue("@StdSignature", registor.Signature);
                da.SelectCommand = cmd;
                da.Fill(ds);
               

            }
            
        }
        public List<StudentRegistor> GetStudents()
        {

            var ds = new DataSet();
            var da = new SqlDataAdapter();
            List<StudentRegistor> Student_DetailsList = new List<StudentRegistor>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("Sp_GetStudents", con);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        StudentRegistor Student_List = new StudentRegistor();
                        Student_List.StudentId = dr["StudentId"].ToString();
                        Student_List.FirstName = dr["FirstName"].ToString();
                        Student_List.LastName = dr["LastName"].ToString();
                        Student_List.CasteCategory = dr["CasteCategory"].ToString();
                        Student_List.Email = dr["Email"].ToString();
                        Student_List.Country = dr["Country"].ToString();
                        Student_List.State = dr["State"].ToString();
                        Student_List.City = dr["City"].ToString();                       
                        Student_List.Photo = dr["StdPhoto"].ToString();
                        Student_List.Signature = dr["StdSignature"].ToString();

                        Student_DetailsList.Add(Student_List);
                    }
                }

               
            }
            return Student_DetailsList;


        }

        public int DeleteStudent(int id)
        {
        
            var ds = new DataSet();
            var da = new SqlDataAdapter();
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
              
                SqlCommand cmd = new SqlCommand("Sp_DeleteStudents", con);               
                cmd.CommandType = CommandType.StoredProcedure;              
                cmd.Parameters.AddWithValue("@StudentId", id);
                da.SelectCommand = cmd;
                da.Fill(ds);
                result = 1;


            }
            return result;
        }

        public List<StudentRegistor> EditStudentDetails(int id)
        {

            var ds = new DataSet();
            var da = new SqlDataAdapter();
            List<StudentRegistor> Student_DetailsList = new List<StudentRegistor>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                StudentRegistor Std_List = new StudentRegistor();
                SqlCommand cmd = new SqlCommand("Sp_EditStudent", con);         
                cmd.CommandType = CommandType.StoredProcedure;               
                cmd.Parameters.AddWithValue("@StudentId", id);
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];

                    Std_List.StudentId = dr["StudentId"].ToString();
                    Std_List.FirstName = dr["FirstName"].ToString();
                    Std_List.LastName = dr["LastName"].ToString();
                    Std_List.CasteCategory = dr["CasteCategory"].ToString();
                    Std_List.Email = dr["Email"].ToString();
                    Std_List.Country = dr["Country"].ToString();
                    Std_List.State = dr["State"].ToString();
                    Std_List.City = dr["City"].ToString();
                    Std_List.State = dr["State"].ToString();
                    Std_List.Photo = dr["StdPhoto"].ToString();
                    Std_List.Signature = dr["StdSignature"].ToString();
                    Student_DetailsList.Add(Std_List);
                }
                return Student_DetailsList;

            }
        }

        public StudentRegistor UpdateStudentDetails(StudentRegistor registor)
        {

            var ds = new DataSet();
            var da = new SqlDataAdapter();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_UpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", registor.StudentId);
                cmd.Parameters.AddWithValue("@FirstName", registor.FirstName);
                cmd.Parameters.AddWithValue("@LastName", registor.LastName);
                cmd.Parameters.AddWithValue("@CasteCategory", registor.CasteCategory);
                cmd.Parameters.AddWithValue("@Email", registor.Email);
                cmd.Parameters.AddWithValue("@Country", registor.Country);
                cmd.Parameters.AddWithValue("@State", registor.State);
                cmd.Parameters.AddWithValue("@City", registor.City);
                cmd.Parameters.AddWithValue("@StdPhoto", registor.Photo);
                cmd.Parameters.AddWithValue("@StdSignature", registor.Signature);

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            return null;

        }
        

    }
}
