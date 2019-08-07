using InOne.BCJN.Application.BCJN;
using System;

namespace InOne.BCJN.AppWPF
{
    class CopyBook : NoteBook, IWritable
    {
        public static void Save(string a)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = a;
            dlg.DefaultExt = ".txt";
            dlg.Filter = "TXT files|*.text";

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = dlg.FileName;
            }
        }
    }
}
