using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowISeeAbstruction.BCJN
{
    class NoteBook : PaperCollection, IWriteable
    {
        public override void ForStyle()
        {
            FontSize = "16";
            FontStyle = "Italian";
        }
        public override int PageCount()
        {
            return WordCount / 400;
        }

        public bool Write()
        {
            throw new NotImplementedException();// You can see how I Implementated it in WPF in next (general) project
        }
    }
}
