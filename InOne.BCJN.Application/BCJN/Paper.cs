using Microsoft.Win32;

namespace InOne.BCJN.Application.BCJN
{
    public abstract class Paper : IReadable
    {
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
