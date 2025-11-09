using System;

namespace HotelManagement.Domain.Exceptions.Auth
{
    public class UnauthenticatedException : Exception
    {
        public UnauthenticatedException() { }

        public UnauthenticatedException(string message) : base(message) { }

        public UnauthenticatedException(string message, Exception inner) : base(message, inner) { }
    }
}
