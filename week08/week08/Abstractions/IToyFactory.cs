using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08.Abstractions;
using week08.Entities;

namespace week08.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}
