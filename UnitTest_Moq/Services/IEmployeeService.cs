using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Moq.Model;
namespace UnitTest_Moq.Services
{
  public  interface IEmployeeService
    {
        Task<string> GetEmployeebyId(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
        // Employee AddEmployee(Employee Emp);
    }
}
