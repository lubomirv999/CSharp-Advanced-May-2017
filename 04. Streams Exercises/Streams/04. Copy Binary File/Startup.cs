namespace _04.Copy_Binary_File
{
    using System.IO;

    class Startup
    {
        static void Main()
        {
            var reader = new FileStream("../../meme.png", FileMode.Open);
            var writer = new FileStream("../../result.png", FileMode.Create);

            using (reader)
            {
                using (writer)
                {
                    var buffer = new byte[4096];
                    var bytes = reader.Read(buffer, 0, buffer.Length);

                    while (bytes != 0)
                    {
                        writer.Write(buffer, 0, bytes);
                        bytes = reader.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
