using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class SqlReader
{
    List<String> dataAs2016procString = new List<String>();
    public List<string> getDataAS2016procString()
    {
        return dataAs2016procString;
    }

 
    public SqlReader()
    {

        string sql = "SELECT [1] from As2016proc";
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
                    dataAs2016procString.Add(reader[0].ToString());


                }
            }
        }
    }


}
