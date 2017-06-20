using System;

namespace DelegateToEventExample
{
    public class MovingEventArgs : EventArgs
    {
        public MovingEventArgs(string str, int number)
        {
            Str = str;
            Number = number;
        }


        public string Str { get; private set; }
        public int Number { get; private set; }
    }
}