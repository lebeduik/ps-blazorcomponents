﻿using Bethanys.Hrm.Shared;

namespace Bethanys.Hrm.Server.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<EmployeeModel> _employees = new List<EmployeeModel>
        {
            new EmployeeModel
            {
                EmployeeId = 1,
                FirstName = "Bethany",
                LastName = "Smith"
            }
        };

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _employees;
        }

        public EmployeeModel GetEmployeeById(int employeeId)
        {
            return _employees.First(e => e.EmployeeId == employeeId);
        }
    }
}
