using System;
using System.Collections.Generic;
using System.Text;
using OperationFather;

namespace MultipleOperation
{
    public class Multiple : Operation
    {
        public override char OperationSign => '*';

        public override int GetResult(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
