using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = $@"C:\DigitalOutput_AU\WS_Working\{DateTime.Now.ToString("yyyyMM")}00\";
        string fileName = "hello_world.txt";
        string filePath = Path.Combine(folderPath, fileName);

        try
        {
            // Check if the directory exists, if not, create it.
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Write to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, World!");
            }

            Console.WriteLine("File created successfully at: " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
