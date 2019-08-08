using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowISeeAbstruction.BCJN
{
    class CopyBook : PaperCollection, IWriteable
    {
        public override int PageCount()
        {
            return WordCount / 150;  // It's just an example
        }
        public override void ForStyle()
        {
            FontSize = "18";
            FontStyle = "Italian";
        }
        public bool Write()
        {
            throw new NotImplementedException(); // You can see how I Implemented it in WPF in next (general) project
        }
    }
}
