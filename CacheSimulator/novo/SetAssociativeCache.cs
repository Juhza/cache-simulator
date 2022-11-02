namespace CacheSimulator.novo
{
    public class SetAssociativeCache : Cache
    {
        public SetAssociativeCache(CacheConfiguration cacheConfiguration) : base(cacheConfiguration) { }

        override
        public void InsertWord(Word word, Address address)
        {
            string tag = address.Binary.Substring(0, 8 - (SetSize + WordSize));
            string set_id = address.Binary.Substring(8 - (SetSize + WordSize), SetSize);
            string word_id = address.Binary.Substring(8 - WordSize);

            int set_int = Convert.ToInt32(set_id, 2);
            int word_int = Convert.ToInt32(word_id, 2);
            int blocks_per_set = BlockSizeDecimal / SetSizeDecimal;

            Console.WriteLine("[" + address.Binary + "] " + tag + " | " + set_id + " | " + word_id + " (" + set_int + ", " + word_int + ")");

            int tag_encontrada = -1;
            int nulo_encontrado = -1;

            for (int i = 0; i < set_int; i++)
            {
                if (Tags[(set_int * blocks_per_set) + i] == null)
                {
                    if (nulo_encontrado == -1)
                    {
                        nulo_encontrado = (set_int * blocks_per_set) + i;
                    }
                }
                else
                {
                    if (Tags[(set_int * blocks_per_set) + i] == tag)
                    {
                        tag_encontrada = (set_int * blocks_per_set) + i;
                    }
                }
            }

            if (tag_encontrada != -1)
            {
                if (Blocks[tag_encontrada, word_int] == null)
                {

                    DirtyBits[tag_encontrada] = true;
                    misses++;

                    Tags[tag_encontrada] = tag;
                    Blocks[tag_encontrada, word_int] = word;
                }
                else
                {
                    hits++;
                }
            }
            else
            {
                if (nulo_encontrado != -1)
                {
                    Tags[nulo_encontrado] = tag;
                    Blocks[nulo_encontrado, word_int] = word;
                }
                else
                {
                    Random rnd = new Random();
                    rnd.Next(0, blocks_per_set);

                    nulo_encontrado = (set_int * blocks_per_set) + rnd.Next(0, blocks_per_set);

                    DirtyBits[nulo_encontrado] = true;
                    misses++;

                    Tags[nulo_encontrado] = tag;
                    Blocks[nulo_encontrado, word_int] = word;
                }
            }
        }

        override
        public Word RetrieveWord(Address address)
        {
            throw new NotImplementedException();
        }
    }
}

