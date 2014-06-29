using aspTest.Helpers;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace aspTest.Models
{
    public class DataBase
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public DataTable ExecuteQuery(string Query)
        {
            NpgsqlConnection conn = new NpgsqlConnection(Alpha.CONNECTION_STRING);
            try
            {
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(Query, conn);
                ds.Reset();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public DataTable ExecuteStatment(string CommandSQL, string code)
        {
            NpgsqlConnection conn = new NpgsqlConnection(Alpha.CONNECTION_STRING);
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(CommandSQL, conn);        
                command.Parameters.Add(new NpgsqlParameter(":countryCode", NpgsqlDbType.Char,3));
                command.Prepare();
                command.Parameters[0].Value = code;
                
                command.ExecuteNonQuery();

                DataSet ds = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(ds);
               
                return ds.Tables[0];              
            }
             catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }


    }
}