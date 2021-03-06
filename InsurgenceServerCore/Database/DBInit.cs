﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace InsurgenceServerCore.Database
{
    public static class DbInit
    {
        public static void Connect()
        {
            var conn = new OpenConnection();
            if (conn.IsConnected())
            {
                const string query = "SHOW TABLES;";
                var cmd = new MySqlCommand(query, conn.Connection);
                var reader = cmd.ExecuteReader();
                var rows = new List<string>();
                while (reader.Read())
                {
                    var row = "";
                    for (var i = 0; i < reader.FieldCount; i++)
                        row += reader.GetValue(i).ToString();
                    rows.Add(row);
                }
                reader.Close();
                foreach (var row in rows)
                {
                    Console.WriteLine("Optimizing table: " + row);
                    var optimizequery = $"OPTIMIZE TABLE {row};";
                    var optimizeCommand = new MySqlCommand(optimizequery, conn.Connection);
                    optimizeCommand.ExecuteNonQuery();
                }
                conn.Close();
                Console.WriteLine("Optimizing complete!");
            }
            else
            {
                throw new Exception("Database not initialized, cannot connect. State: " + conn.Connection.State);
            }
        }
    }
}
