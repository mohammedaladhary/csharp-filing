using System.Net.Http.Headers;

namespace filing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "someTextFile.txt";
            writeFileWithUsing("With Using");
        }

        private static void writeFileWithoutUsing(string fileName)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine("Hello World");
                Console.WriteLine("File Writing complete");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally 
            {
                writer.Flush();
                writer.Close(); 
            }
        }
        private static void writeFileWithUsing(string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Heelo World With Using");
                }
                Console.WriteLine("File Using complete");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}