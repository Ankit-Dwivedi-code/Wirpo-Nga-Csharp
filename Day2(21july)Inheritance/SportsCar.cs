using System;

namespace Demo_Inheritance
{
    internal class SportsCar
    {
        public string Brand { get; internal set; }
        public string Model { get; internal set; }
        public int Speed { get; internal set; }
        public int HorsePower { get; internal set; }

        internal void start()
        {
            throw new NotImplementedException();
        }
    }
}