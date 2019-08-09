using System;

namespace HowISeeAbstraction.BCJN
{
    class NoteBook : PaperCollection, IWriteable
    {
        public override void ForStyle()
        {
            FontSize = "16";
            FontStyle = "Italian";
        }
        public override int PageCount() => WordCount / 400;
        public bool Write()
        {
            throw new NotImplementedException();// You can see how I implementated it in WPF in next (general) project
        }
    }
}
