using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class SqlReader2
{
    List<String> dataPogodaString = new List<String>();

    public List<string> getPogodaString()
    {
        return dataPogodaString;
    }

    public SqlReader2()
    {

        string sql = "SELECT [predkosc_wiatru] from pogoda2";
        string variable;
        using (var connection = new SqlConnection("Server=localhost;Database=BILesData;Trusted_Connection=True;"))
        using (var command = new SqlCommand(sql, connection))
        {
            //command.Parameters.AddWithValue("@Parameter", someValue);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                //Check the reader has data:
                //if (reader.Read())
                //{
                //    variable = reader.GetString(reader.GetOrdinal("Column"));
                // }
                // If you need to use all rows returned use a loop:
                while (reader.Read())
                {
                    dataPogodaString.Add(reader[0].ToString());


                }
            }
        }
    }
}
