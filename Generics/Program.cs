﻿using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.FindMaxInteger(1, 2, 3);
            operation.FindMaxFloat(1f, 2f, 3f);
            operation.FindMaxString("hello","Hello","HELLO");

            GenericOperation<int> operation2 = new GenericOperation<int>();

            operation2.FindMax(1,2,3);
        }
    }
}