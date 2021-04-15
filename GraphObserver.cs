using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphIterator
{
    class GraphObserver : Observer
    {
        public void Update(uint vert)
        {
            Console.WriteLine($"Vertical '{vert}' has been visited");
        }
    }
}
