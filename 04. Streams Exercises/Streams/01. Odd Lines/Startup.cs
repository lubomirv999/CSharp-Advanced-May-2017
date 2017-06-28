namespace _01.Odd_Lines
{
    using System;
    using System.IO;

    class Startup
    {
        static void Main()
        {
            var reader = new StreamReader("../../text.txt");

            using (reader)
            {
                int index = 0;
                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    if (index % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }

                    ++index;
                }
            }
        }
    }
}
