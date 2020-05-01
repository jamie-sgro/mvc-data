using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DataLibrary.DataAccess {
  public static class SqlDataAccess {
    public static string GetConnectionString(string connectionName = "mvcdb") {
      return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
    }

    public static List<T> LoadData<T>(string sql) {
      using (MySqlConnection cnn = new MySqlConnection(GetConnectionString())) {
        return cnn.Query<T>(sql).ToList();
      }
    }

    public static int SaveData<T>(string sql, T data) {
      using (MySqlConnection cnn = new MySqlConnection(GetConnectionString())) {
        return cnn.Execute(sql, data);
      }
    }
  }
}
