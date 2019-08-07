using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.BCJN.AppWPF
{
    public abstract class NoteBook : Book
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
