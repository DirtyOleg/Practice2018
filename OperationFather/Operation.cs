using System;
using System.Collections.Generic;
using System.Text;

namespace OperationFather
{
    public abstract class Operation
    {
        public abstract char OperationSign { get; }

        public abstract int GetResult(int num1, int num2);
    }
    
}
