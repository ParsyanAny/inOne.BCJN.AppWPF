using InOne.BCJN.Application.BCJN;

namespace InOne.BCJN.AppWPF
{
    public class Book : Paper, IReadable
    {
        public override int PageCount()
        {
            return WordCount / 500;
        }
    }
}
