using System;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AccessWCF
{
    public static class Database
    {
        public static void Open(SqlConnection DbConnection)
        {
            DbConnection.Open();
        }

        public static void Close(SqlConnection DbConnection)
        {
            DbConnection.Close();
            DbConnection.Dispose();
        }

        public static void DataReaderClose(SqlDataReader SqlDataReader)
        {
            SqlDataReader.Close();
            SqlDataReader.Dispose();
        }

        public static void CommandClose(SqlCommand SqlCommand)
        {
            SqlCommand.Dispose();
        }
    }
}
