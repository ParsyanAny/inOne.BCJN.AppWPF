using InOne.BCJN.Application.BCJN;

namespace InOne.BCJN.AppWPF
{
    class Journal : Paper, IReadable
    {
        public override int PageCount() => WordCount / 350;
    }
}
