﻿using System;

namespace BinaryDataStorageEngine
{
    public class InitializationException : Exception
    {
        public InitializationException(string message)
            : base(message)
        { }
    }
}
