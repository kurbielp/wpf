using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;
using System.Xml;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;

public class JsonToDB
{

     public static string GetXMLFromJson(string jsonString)
    {
        string parentNote = "Pogoda";
        XDocument doc = (XDocument)JsonConvert.DeserializeXNode("{\"" + parentNote + "\":" + jsonString + "}", "DocumentElement");
        return doc.ToString();
    } 
	public JsonToDB(String url)
	{
        var json = new WebClient().DownloadString(url);

        //Console.WriteLine(json);


        XmlDocument xml = JsonConvert.DeserializeXmlNode("{\"pogoda4\":" + json + "}", "root");//.ToXmlString();

        DataSet ds = new DataSet("Json Data");
        XmlReader xr = new XmlNodeReader(xml);
        ds.ReadXml(xr);

        //Console.WriteLine(ds.GetXml());

        string connectionString = "Server=localhost;Database=BILesData;Trusted_Connection=True;";
         
            /*
            "Data Source=DELL-KOMPUTER;" +
            "Initial Catalog=BILesData;" +
            "User id=dell;" +
            "Password=;";*/
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        foreach (DataTable dt in ds.Tables)
        {
            Console.WriteLine("Bulk Insert Started table:" + dt.TableName);
            SqlBulkCopy bulk = new SqlBulkCopy(conn);
            bulk.DestinationTableName = "[" + dt.TableName.Replace('{', ' ').Replace('}', ' ') + "]";
            bulk.WriteToServer(dt);
            Console.WriteLine("Bulk Insert completed table:" + dt.TableName);
        }
        
    }

}
