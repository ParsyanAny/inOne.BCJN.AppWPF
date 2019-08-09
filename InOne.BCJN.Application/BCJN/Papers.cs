using Microsoft.Win32;
using System.IO;

namespace InOne.BCJN.Application.BCJN
{
    public abstract class Paper : IReadable
    {
        public int WordCount { get; set; }
        public string Text { get; set; }

        public class Sizes
        {
            public int Heigth { get; set; }
            public int Width { get; set; }
        }

        public abstract int PageCount();

        public string Read()
        {
            OpenFileDialog opFD = new OpenFileDialog();
            string fileContent = string.Empty;
            string filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            opFD.Filter = filter;
            opFD.InitialDirectory = "c:\\";
            opFD.RestoreDirectory = true;
            if (opFD.ShowDialog() == true)
            {
                Stream fileStream = opFD.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            return fileContent;
        }
    }
}
