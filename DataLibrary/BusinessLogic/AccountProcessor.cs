using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic {
  public static class AccountProcessor {
    public static int CreateEmployee(int accountId, string firstName,
      string lastName, string emailAddress) {
      EmployeeModel data = new EmployeeModel {
        EmployeeId = employeeId,
        FirstName = firstName,
        LastName = lastName,
        EmailAddress = emailAddress
      };

      string sql = @"INSERT INTO dbo.AccountTable (AccountId, FirstName, LastName, EmailAddress
                     VALUES (@AccountId, @FirstName, @LastName, @EmailAddress);";

      return SqlDataAccess.SaveData(sql, data);
    }

    public static List<EmployeeModel> LoadEmployees() {
      string sql = @"SELECT Id, AccountId, FirstName, LastName, EmailAddress
                     FROM dbo.AccountTable;";
      return SqlDataAccess.LoadData<EmployeeModel>(sql);
    }
  }
}
