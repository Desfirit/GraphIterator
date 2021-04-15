using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphIterator
{
    public interface Subject
    {
        void AddEventListener(Observer observer);
        void RemoveEventListener(Observer observer);
        void Notify(uint vert);
    }
}
