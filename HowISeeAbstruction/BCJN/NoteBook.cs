using System;

namespace HowISeeAbstruction.BCJN
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
            throw new NotImplementedException();// You can see how I Implementated it in WPF in next (general) project
        }
    }
}
