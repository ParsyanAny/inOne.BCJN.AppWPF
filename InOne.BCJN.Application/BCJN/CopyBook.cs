using InOne.BCJN.Application.BCJN;
using Microsoft.Win32;
using System.IO;

namespace InOne.BCJN.AppWPF
{
    public class CopyBook : Paper, IWritable, IReadable
    {
        public override int PageCount() => WordCount / 150;
        
        public void Saveas(string content)
        {
            SaveFileDialog SaveFD = new SaveFileDialog();
            SaveFD.RestoreDirectory = true;
            SaveFD.DefaultExt = ".txt";
            bool? result = SaveFD.ShowDialog();
            if (result == true)
            {
                File.WriteAllText(SaveFD.FileName, content);
            }
        }
    }
}
