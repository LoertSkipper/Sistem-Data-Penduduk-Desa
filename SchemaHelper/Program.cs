using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        try
        {
            string settingPath = @"c:\Users\USER\source\repos\Sistem-Data-Penduduk-Desa\Sistem-Data-Penduduk-Desa\bin\Debug\net10.0-windows\setting.txt";
            if (!File.Exists(settingPath))
            {
                Console.WriteLine("setting.txt not found at: " + settingPath);
                return;
            }

            string[] lines = File.ReadAllLines(settingPath);
            if (lines.Length < 5)
            {
                Console.WriteLine("setting.txt has invalid format.");
                return;
            }

            string server = lines[0];
            string database = lines[1];
            string username = lines[2];
            string password = lines[3];
            string port = lines[4];

            string connStr = $"{server};{database};{username};{password};{port}";
            Console.WriteLine("Connection string: " + connStr);

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                Console.WriteLine("Connected to database successfully.");

                // Get all tables
                var tables = new System.Collections.Generic.List<string>();
                using (var cmd = new MySqlCommand("SHOW TABLES", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tables.Add(reader.GetString(0));
                    }
                }

                foreach (var table in tables)
                {
                    Console.WriteLine($"\n=== Table: {table} ===");
                    using (var cmd = new MySqlCommand($"DESCRIBE `{table}`", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string field = reader.GetValue(0).ToString() ?? "";
                            string type = reader.GetValue(1).ToString() ?? "";
                            string isNull = reader.GetValue(2).ToString() ?? "";
                            string key = reader.GetValue(3).ToString() ?? "";
                            string def = reader.GetValue(4).ToString() ?? "NULL";
                            string extra = reader.GetValue(5).ToString() ?? "";
                            Console.WriteLine($"- {field} | {type} | Null: {isNull} | Key: {key} | Default: {def} | Extra: {extra}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.ToString());
        }
    }
}
