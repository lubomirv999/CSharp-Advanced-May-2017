namespace _07.Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            string[] paths = Directory.GetFiles("../../");
            List<FileInfo> files = paths.Select(path => new FileInfo(path)).ToList();

            var sortedFiles = files.OrderBy(file => file.Length)
                .GroupBy(file => file.Extension)
                .OrderByDescending(group => group.Count())
                .ThenBy(group => group.Key);

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            StreamWriter writer = new StreamWriter(desktop + "report.txt");

            foreach (var group in sortedFiles)
            {
                writer.WriteLine(group.Key);

                foreach (var item in group)
                {
                    writer.WriteLine("--{0} - {1:F3}kb", item.Name, item.Length / 1024.0);
                }
            }

            writer.Close();

            System.Diagnostics.Process.Start(desktop + "report.txt");
        }
    }
}
