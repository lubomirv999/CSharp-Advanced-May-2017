namespace _05.Slicing_File
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Startup
    {
        static void Main()
        {
            var name = "music.mp3";
            var destination = "../..";

            var files = new List<string>()
            {
                "part1.mp3",
                "part2.mp3",
                "part3.mp3"
            };

            var resultDestination = "../../result files";
            var parts = int.Parse(Console.ReadLine());

            Slice(name, destination, parts);
            Assemble(files, resultDestination);
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            var fileSize = 0;
            var extension = sourceFile.Split('.')[1];

            using (var file = new FileStream(destinationDirectory + "//" + sourceFile, FileMode.Open))
            {
                var buffer = new byte[1024];
                var bytes = file.Read(buffer, 0, buffer.Length);

                while (bytes != 0)
                {
                    fileSize += bytes;
                    bytes = file.Read(buffer, 0, buffer.Length);
                }

                file.Seek(0, SeekOrigin.Begin);
                var partSize = fileSize / parts;

                for (int i = 0; i < parts; i++)
                {
                    using (var newFile =
                        new FileStream(destinationDirectory + "//generated files//part" + (i + 1) + "." + extension,
                            FileMode.Create))
                    {
                        var nestedBuffer = new byte[partSize];
                        file.Read(nestedBuffer, 0, nestedBuffer.Length);
                        newFile.Write(nestedBuffer, 0, nestedBuffer.Length);
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            var extension = files[0].Split('.')[1];

            using (var result = new FileStream(destinationDirectory + "//result." + extension, FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (var currentFile = new FileStream(destinationDirectory + "//" + file, FileMode.Open))
                    {
                        var buffer = new byte[1024];
                        var bytes = currentFile.Read(buffer, 0, buffer.Length);

                        while (bytes != 0)
                        {
                            result.Write(buffer, 0, bytes);
                            bytes = currentFile.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}