using InOne.BCJN.Application.BCJN;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Documents;

namespace InOne.BCJN.AppWPF
{
    public class CopyBook :  Paper, IWritable, IReadable
    {
        public override int PageCount()
        {
            return WordCount / 150;
        }
        public void Saveas(string fName, string content)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                FileName = fName,
                DefaultExt = ".txt",
                Filter = filter
            };

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;

                File.WriteAllText(filename, content);

            }
        }
    }
}
