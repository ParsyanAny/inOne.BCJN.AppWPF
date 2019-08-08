using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.BCJN.Application.BCJN
{
    public interface IWritable
    {
        void Saveas(string oldName, string content);
    }
}
