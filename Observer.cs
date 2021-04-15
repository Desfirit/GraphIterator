using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphIterator
{
    public interface Observer
    {
        void Update(uint vert);
    }
}
