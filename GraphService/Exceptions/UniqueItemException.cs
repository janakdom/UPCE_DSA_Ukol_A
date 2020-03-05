﻿using GraphService.Properties;
using System;

namespace GraphService
{
    public class UniqueItemException : Exception
    {
        public UniqueItemException(string message) 
            : base(message)
        { }

        public UniqueItemException()
            : base(Resources.ValueAlreadyExists)
        { }
    }
}
