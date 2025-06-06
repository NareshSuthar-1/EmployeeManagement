﻿using Dapper;
using EmployeeManagement.Models;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace EmployeeManagement.Utility
{
    public class DAL
    {
        private string _connectionString = "Data Source=DESKTOP-C5G7JVM;Initial Catalog=EmployeeCore;Integrated Security=True";

        public List<Department> GetAllDepartments()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var sql = "SELECT * FROM Department";
                using IDbConnection db = new SqlConnection(_connectionString);
                List<Department> departmentList =  db.Query<Department>(sql).ToList();
                return departmentList;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var sql = "SELECT * FROM Employee";
                using IDbConnection db = new SqlConnection(_connectionString);
                List<Employee> employeetList = (List<Employee>)db.Query<Employee>(sql);
                return db.Query<Employee>(sql).ToList();
            }
        }
    }
}
