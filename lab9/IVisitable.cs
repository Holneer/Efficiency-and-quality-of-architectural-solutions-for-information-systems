using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}