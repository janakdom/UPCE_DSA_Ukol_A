﻿using System;

namespace RangeTree.Exceptions
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string message) 
            : base(message)
        { }
    }
}
