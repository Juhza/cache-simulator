using System;
namespace CacheSimulator.novo
{
    public class Address
    {
        public int Decimal;
        public string Binary;

        public Address(int address)
        {
            if(address < 255)
            {
                Decimal = address;
                Binary = Convert.ToString(address, 2).PadLeft(8, '0');
            } else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}

