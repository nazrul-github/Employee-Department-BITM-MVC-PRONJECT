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
    public class DepartmentGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public List<Department> GetAllDepartments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAllDepartment", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Department> allDepartments = new List<Department>();
                while (reader.Read())
                {
                    allDepartments.Add(new Department()
                    {
                       DepartmentId = (int) reader["DepartmentId"],
                       DepartmentCode = reader["DepartmentCode"].ToString(),
                       DepartmentName = reader["DepartmentName"].ToString()
                    });
                }
                reader.Close();
                connection.Close();
                return allDepartments;
            }
        }

        public bool SaveDepartment(Department department)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_SaveDepartment", connection);
                cmd.Parameters.AddWithValue("@DepartmentCode", department.DepartmentCode);
                cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
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
        public bool UpdateDepartment(Department department)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateDepartment", connection);
                cmd.Parameters.AddWithValue("@DepartmentId", department.DepartmentId);
                cmd.Parameters.AddWithValue("@DepartmentCode", department.DepartmentCode);
                cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
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
        public bool DeleteEmployee(Department department)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_DeleteDepartment", connection);
                cmd.Parameters.AddWithValue("@DepartmentId", department.DepartmentId);
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