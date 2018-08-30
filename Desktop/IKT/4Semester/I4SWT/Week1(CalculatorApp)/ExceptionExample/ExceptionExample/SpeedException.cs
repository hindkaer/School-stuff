using System;

namespace ExceptionExample
{
    public class SpeedException : Exception
    {
        public uint Speed { get; private set; }
        public SpeedException(uint spd)
        {
            Speed = spd;
        }
    }
}