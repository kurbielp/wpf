using System;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;

public class ExcelToSql
{
	public ExcelToSql(string path)
	{
        // if you have Excel 2007 uncomment this line of code 
        //  string excelConnectionString =string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0",path); 

        string ExcelContentType = "application/vnd.ms-excel";
        string Excel2010ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
       
                try
                {
                    //Save file path 
                    //string path = string.Concat(Server.MapPath("~/TempFiles/"), FileUpload1.FileName);
                    //Save File as Temp then you can delete it if you want 
                    //FileUpload1.SaveAs(path);
                    //string path = @"C:\Users\Johnney\Desktop\ExcelData.xls"; 
                    //For Office Excel 2010  please take a look to the followng link  http://social.msdn.microsoft.com/Forums/en-US/exceldev/thread/0f03c2de-3ee2-475f-b6a2-f4efb97de302/#ae1e6748-297d-4c6e-8f1e-8108f438e62e 
                    string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);

                    // Create Connection to Excel Workbook 
                    using (OleDbConnection connection =
                                 new OleDbConnection(excelConnectionString))
                    {
                        OleDbCommand command = new OleDbCommand
                                ("Select * FROM [2016_As(PM10)_24g$]", connection);

                        connection.Open();

                        // Create DbDataReader to Data Worksheet 
                        using (DbDataReader dr = command.ExecuteReader())
                        {

                            // SQL Server Connection String 
                            string sqlConnectionString = "Server=localhost;Database=BILesData;Trusted_Connection=True;";

                            // Bulk Copy to SQL Server 
                            using (SqlBulkCopy bulkCopy =
                                       new SqlBulkCopy(sqlConnectionString))
                            {
                                bulkCopy.DestinationTableName = "As2016";
                                bulkCopy.WriteToServer(dr);
                                Console.WriteLine( "The data has been exported succefuly from Excel to SQL");
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
        
    }



}
