using Microsoft.Win32;

namespace InOne.BCJN.AppWPF
{
    public abstract class Book
    {
        public int PageCount { get; set; }
        public static string Read()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "TXT files|*.text";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == true)
            {
                return $"{dlg.FileName}";
            }
            return null;
        }
    }
}
