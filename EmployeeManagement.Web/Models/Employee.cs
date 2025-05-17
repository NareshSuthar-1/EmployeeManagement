namespace EmployeeManagement.Web.Models
{
    public class Employee
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
        public int Age { get;  set; }
        public decimal Salary { get;  set; }
        public string Department { get;  set; }

        #region  CODE FOR ENCUSULATION 
        //public string Department { get; private set; }
        //public Employee(string name, int age, decimal salary, string department)
        //{
        //    Name = name;
        //    Age = age;
        //    Salary = salary;
        //    Department = department;
        //}

        //public void UpdateDetails(string name, int age, decimal salary, string department)
        //{
        //    Name = name;
        //    Age = age;
        //    Salary = salary;
        //    Department = department;
        //}
        #endregion
    }

}
