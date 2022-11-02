namespace CacheSimulator.novo
{
    public class DirectMappingCache : Cache
    {
        public DirectMappingCache(CacheConfiguration cacheConfiguration) : base(cacheConfiguration) { }

        public override void InsertWord(Word word, Address address)
        {
            string tag_part = address.Binary.Substring(0, 8 - (BlockSize + WordSize));
            string block_part = address.Binary.Substring(8 - (BlockSize + WordSize), BlockSize);
            string word_part = address.Binary.Substring(8 - WordSize);

            int i_block_part = Convert.ToInt32(block_part, 2);
            int i_word_part = Convert.ToInt32(word_part, 2);

            //Console.WriteLine("[" + address.Binary + "] " + tag_part + " | " + block_part + " | " + word_part + " (" + i_block_part + ", " + i_word_part + ")");

            inserts++;

            if (Tags[i_block_part] == null)
            {
                Tags[i_block_part] = tag_part;
                Blocks[i_block_part, i_word_part] = word;
            }
            else
            {
                if (Tags[i_block_part] == tag_part)
                {
                    if (Blocks[i_block_part, i_word_part] == null)
                    {

                        DirtyBits[i_block_part] = true;
                        misses++;

                        Tags[i_block_part] = tag_part;
                        Blocks[i_block_part, i_word_part] = word;
                    }
                    else
                    {
                        hits++;
                    }
                }
                else
                {
                    DirtyBits[i_block_part] = true;
                    misses++;

                    Tags[i_block_part] = tag_part;
                    Blocks[i_block_part, i_word_part] = word;
                }
            }
        }

        public override Word RetrieveWord(Address address)
        {
            throw new NotImplementedException();
        }
    }
}

