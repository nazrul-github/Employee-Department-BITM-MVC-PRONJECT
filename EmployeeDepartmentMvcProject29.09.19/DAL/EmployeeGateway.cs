using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using EmployeeDepartmentMvcProject29._09._19.Models;

namespace EmployeeDepartmentMvcProject29._09._19.DAL
{
    public class EmployeeGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public List<Employee> GetAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Employee> allEmployees = new List<Employee>();
                while (reader.Read())
                {
                    allEmployees.Add(new Employee
                    {
                        EmployeeId = (int)reader["Id"],
                        Name = reader["EmployeeName"].ToString(),
                        BloodGroup = reader["BloodGroup"].ToString(),
                        Designation = reader["Designation"].ToString(),
                        JoiningDate = Convert.ToDateTime(reader["JoiningDate"]).Date,
                        DepartmentId = (int) reader["DepartmentId"],
                        NID = reader["NID"].ToString(),
                    });
                }
                reader.Close();
                connection.Close();
                return allEmployees;
            }
        }

        public bool SaveEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_SaveEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeName", employee.Name);
                cmd.Parameters.AddWithValue("@Designation", employee.Designation);
                cmd.Parameters.AddWithValue("@Nid", employee.NID);
                cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
                cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
                cmd.Parameters.AddWithValue("@BloodGroup", employee.BloodGroup);
                connection.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                connection.Close();
                if (rowAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public bool UpdateEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.Name);
                cmd.Parameters.AddWithValue("@Designation", employee.Designation);
                cmd.Parameters.AddWithValue("@Nid", employee.NID);
                cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
                cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
                cmd.Parameters.AddWithValue("@BloodGroup", employee.BloodGroup);
                connection.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                connection.Close();
                if (rowAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public bool DeleteEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_DeleteEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                connection.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                connection.Close();
                if (rowAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}