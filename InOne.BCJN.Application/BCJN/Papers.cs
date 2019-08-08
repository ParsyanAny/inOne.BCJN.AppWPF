using Microsoft.Win32;
using System.IO;

namespace InOne.BCJN.Application.BCJN
{
    public abstract class Paper : IReadable
    {
        public int WordCount { get; set; }
        public class Sizes
        {
            public int Heigth { get; set; }
            public int Width { get; set; }
        }
        public abstract int PageCount();

        
        protected const string filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        public string Read()
        {
            string fileContent = string.Empty;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = filter;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == true)
            {
                Stream fileStream = dlg.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            return fileContent;
        }
    }
}
