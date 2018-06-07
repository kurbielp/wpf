using System;
using System.Data;
using System.Data.SqlClient;

public class DataProcessing
{
	public DataProcessing()
	{
        SqlConnection sqlConnection1 = new SqlConnection("Server=localhost;Database=BILesData;Trusted_Connection=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = "IF EXISTS(SELECT *  FROM dbo.As2016proc) DROP TABLE dbo.As2016proc ;";
        cmd.CommandText = "SELECT * INTO As2016proc FROM dbo.As2016 ;";
        cmd.CommandText = "SELECT * FROM As2016proc DELETE FROM As2016proc WHERE F1 =NULL ; ";
      //  cmd.CommandText = "ALTER TABLE As2016proc DROP COLUMN [F1];";
       // cmd.CommandText = " IF COL_LENGTH('schemaName.As2016proc', 'F1') IS NOT NULL BEGIN  DROP COLUMN [F1] END   ";
       // cmd.CommandText = "ALTER TABLE As2016proc DROP COLUMN [F1];";

        /*
        SELECT *
        FROM
        (SELECT *
        FROM As2016proc) AS SourceTable
        PIVOT
        (
            AVG(StandardCost)
            FOR DaysToManufacture IN([0], [1], [2], [3], [4])
        ) AS PivotTable;
        */

        //cmd.CommandText = "DECLARE @As2016columnnmb =( Select Count(*) From INFORMATION_SCHEMA.COLUMNS Where TABLE_NAME = 'As2016proc');";


        //cmd.CommandText = "SELECT TOP @As2016columnnmb from pogoda2";


        cmd.CommandType = CommandType.Text;
        cmd.Connection = sqlConnection1;

        sqlConnection1.Open();

        reader = cmd.ExecuteReader();

        // Data is accessible through the DataReader object here.

        sqlConnection1.Close();

    }

}
