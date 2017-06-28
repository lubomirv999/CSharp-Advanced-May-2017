namespace _02.Line_Numbers
{
    using System.IO;

    class Startup
    {
        static void Main()
        {
            var reader = new StreamReader("../../text.txt");
            var writer = new StreamWriter("../../result.txt");

            using (reader)
            {
                using (writer)
                {
                    int counter = 1;
                    string line = string.Empty;

                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        ++counter;
                    }
                }
            }
        }
    }
}
