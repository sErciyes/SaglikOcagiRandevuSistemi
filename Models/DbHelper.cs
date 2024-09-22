using System;
using System.Data;
using System.Data.SqlClient;

public class DbHelper
{
    private readonly string _connectionString;

    public DbHelper(string connectionString)
    {
        _connectionString = connectionString;
    }

    private SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }

    public DataTable ExecuteQuery(string query, CommandType commandType, SqlParameter[] parameters = null)
    {
        using (var conn = GetConnection())
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = commandType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var result = new DataTable();
                    adapter.Fill(result);
                    return result;
                }
            }
        }
    }

    public object ExecuteScalar(string query, CommandType commandType, SqlParameter[] parameters = null)
    {
        using (var conn = GetConnection())
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = commandType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }

    public int ExecuteNonQuery(string query, CommandType commandType, SqlParameter[] parameters = null)
    {
        using (var conn = GetConnection())
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = commandType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }

    public DataTable ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters = null)
    {
        return ExecuteQuery(storedProcedureName, CommandType.StoredProcedure, parameters);
    }
}
