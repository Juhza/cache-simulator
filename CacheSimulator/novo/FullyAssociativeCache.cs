namespace CacheSimulator.novo
{
    public class FullyAssociativeCache : Cache
    {
        public FullyAssociativeCache(int blockSize, int wordSize) : base(blockSize, wordSize)
        {

        }

        override
        public void InsertData(byte data, string address)
        {
            bool found = false;
            int index = 0;

            while (!found && index < BlockSize)
            {
                if (Tags[index] == null)
                {
                    found = true;
                }
                else
                {
                    index++;
                }
            }

            if (found)
            {
                string tag = address.Substring(0, 32 - WordSize);
                int word = Convert.ToInt32(address.Substring(31 - WordSize, WordSize), 2);

                Tags[index] = tag;
                Blocks[index, word] = data;
            }


        }

        override
        public byte RetrieveData(string address)
        {
            return 0;
        }
    }
}
