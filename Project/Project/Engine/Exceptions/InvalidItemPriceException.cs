
using System;

namespace Project.Engine.Exceptions
{
    public class InvalidItemPriceException : Exception
    {
        public InvalidItemPriceException()
        {

        }

        public InvalidItemPriceException(string message)
            : base(message)
        {

        }

        public InvalidItemPriceException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
