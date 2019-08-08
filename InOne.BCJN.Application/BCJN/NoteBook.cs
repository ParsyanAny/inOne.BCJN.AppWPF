using InOne.BCJN.Application.BCJN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.BCJN.AppWPF
{
    public class NoteBook : CopyBook, IReadable, IWritable
    {
        public override int PageCount()
        {
            return WordCount / 250;
        }
    }
}
