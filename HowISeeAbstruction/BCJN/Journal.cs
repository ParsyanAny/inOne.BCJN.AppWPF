using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowISeeAbstruction.BCJN
{
    class Journal : PaperCollection
    {
        public override void ForStyle()
        {
            FontSize = "25";
            FontStyle = "Standart";
        }
        public override int PageCount()
        {
            return WordCount / 350; // It's just an example
        }
    }
}
