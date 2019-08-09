using System;

namespace HowISeeAbstraction.BCJN
{
    class CopyBook : PaperCollection, IWriteable
    {
        public override int PageCount() => WordCount / 150;  // It's just an example
        public override void ForStyle()
        {
            FontSize = "18";
            FontStyle = "Italian";
        }
        public bool Write()
        {
            throw new NotImplementedException(); // You can see how I implemented it in WPF in next (general) project
        }
    }
}
