using System;
using System.IO;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
public class GetPythonResults
{
    private async void getPythonResults(object sender, EventArgs e)
    {
        // Do some work
        string pythonResultsPath = "C:/Users / dell / Desktop / lesiu / pythonresults.txt";

        // Wait until condition is false
        while (File.Exists(pythonResultsPath) == false)
        {
            await Task.Delay(25);

        }

        try
        {   // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader("C:/Users / dell / Desktop / lesiu / pythonResults.txt"))
            {
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                Console.WriteLine(line);

            }
        }
        catch (Exception readTxtException)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(readTxtException.Message);

        }


    }
}
