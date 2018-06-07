using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            //wczytywanie danych ze strony
            string url = "https://danepubliczne.imgw.pl/api/data/synop";
            JsonToDB jsonToDB = new JsonToDB(url);

            //wczytywanie danych z excela
            string excelFilepath = "C:/Users/dell/Desktop/les/2016_As(PM10)_24g.xlsx";
            ExcelToSql excelToSql = new ExcelToSql(excelFilepath);

            DataProcessing dataProcessing = new DataProcessing();

            // GetStringFromData getStringFromData = new GetStringFromData();


            List<String> dataStringList = new List<string>();
            List<String> dataStringList2 = new List<string>();
            // tu cos nie dzial
            //dataString = getStringFromData.StringFromDatabase();

            SqlReader sqlReader = new SqlReader();
            SqlReader2 sqlReader2 = new SqlReader2();
            dataStringList = sqlReader.getDataAS2016procString();
            dataStringList2 = sqlReader2.getPogodaString();

            System.Console.WriteLine("----------------AS---------");

            foreach (String data in dataStringList)
            {
                System.Console.WriteLine(data);
            }

            System.Console.WriteLine("----------------POGODA---------");
            foreach (String data in dataStringList2)
            {
                System.Console.WriteLine(data);
            }



            //ImportDataClass importDataClass = new ImportDataClass();
            //importDataClass.ImportDataFromExcel(excelFilepath);

            /*
            string[] lines = { "First line", "Second line", "Third line" };
            */
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:/Users/dell/Desktop/les/textDataForPython.txt"))
            {
                file.WriteLine("data1");

                foreach (string line in dataStringList)
                {

                    if (!line.Contains("foobar"))
                    {
                        file.WriteLine(line);
                    }

                }

                file.WriteLine("data2");

                foreach (string line in dataStringList2)
                {

                    if (!line.Contains("foobar"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("zapisano plik");

            Console.WriteLine("otwieram pythona");

            run_cmd();
            void run_cmd()
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "Python C:/Users/dell/Desktop/les/siec.py";
                start.Arguments = string.Format("{0} {1}");
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.Write(result);
                    }
                }
            }
            //string strCmdText = "Python C:/Users/dell/Desktop/les/siec.py";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            GetPythonResults getPythonResults = new GetPythonResults();



            // Console.WriteLine(File.Exists(pythonResultsPath) ? "File exists." : "File does not exist.");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        


    }
}
