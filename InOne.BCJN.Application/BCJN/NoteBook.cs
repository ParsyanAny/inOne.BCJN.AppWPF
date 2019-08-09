using InOne.BCJN.Application.BCJN;

namespace InOne.BCJN.AppWPF
{
    public class NoteBook : CopyBook, IReadable, IWritable
    {
        public override int PageCount() => WordCount / 250;
    }
}
