using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowISeeAbstruction.BCJN
{
    class Book : PaperCollection
    {
        public override void ForStyle()
        {
            FontSize = "32";
            FontStyle = "Italian";
        }

        public override int PageCount()
        {
            return WordCount / 500; // It's just an example
        }
    }
}
