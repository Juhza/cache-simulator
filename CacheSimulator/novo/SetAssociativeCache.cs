namespace CacheSimulator.novo
{
    public class SetAssociativeCache : Cache
    {
        public int SetSize;
        public SetAssociativeCache(int blockSize, int wordSize, int setSize) : base(blockSize, wordSize)
        {
            SetSize = setSize;
        }

        public override void InsertData(byte data, string address)
        {
            throw new NotImplementedException();
        }

        public override byte RetrieveData(string address)
        {
            throw new NotImplementedException();
        }
    }
}

