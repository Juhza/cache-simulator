namespace CacheSimulator.novo
{
    public class SetAssociativeCache : Cache
    {
        public List<int>[] Recently;

        public SetAssociativeCache(CacheConfiguration cacheConfiguration) : base(cacheConfiguration)
        {
            Recently = new List<int>[SetSizeDecimal];

            for (int i = 0; i < SetSizeDecimal; i++)
            {
                Recently[i] = new List<int>();
            }
        }

        override
        public void InsertWord(Word word, Address address)
        {
            string tag = address.Binary.Substring(0, 8 - (SetSize + WordSize));
            string set_id = address.Binary.Substring(8 - (SetSize + WordSize), SetSize);
            string word_id = address.Binary.Substring(8 - WordSize);

            int set_int = Convert.ToInt32(set_id, 2);
            int word_int = Convert.ToInt32(word_id, 2);
            int blocks_per_set = BlockSizeDecimal / SetSizeDecimal;

            //Console.WriteLine("[" + address.Binary + "] " + tag + " | " + set_id + " | " + word_id + " (" + set_int + ", " + word_int + ")");

            accesses++;

            int tag_encontrada = -1;
            int nulo_encontrado = -1;

            for (int i = 0; i < blocks_per_set; i++)
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
                if (BlockReplacementPolicy == Enums.BlockReplacementPolicy.LRU)
                {
                    if (Recently[set_int].Contains(tag_encontrada))
                    {
                        Recently[set_int].Remove(tag_encontrada);
                    }
                    Recently[set_int].Add(tag_encontrada);
                }
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
                    Console.WriteLine("entrou");
                    if (BlockReplacementPolicy == Enums.BlockReplacementPolicy.LRU)
                    {
                        Recently[set_int].Add(nulo_encontrado);
                    }
                    Console.WriteLine("passou");
                    Tags[nulo_encontrado] = tag;
                    Blocks[nulo_encontrado, word_int] = word;
                    misses++;
                }
                else
                {
                    switch (BlockReplacementPolicy)
                    {
                        case Enums.BlockReplacementPolicy.LRU:
                            nulo_encontrado = Recently[set_int].First();
                            Recently[set_int].Remove(nulo_encontrado);
                            Recently[set_int].Add(nulo_encontrado);
                            break;
                        case Enums.BlockReplacementPolicy.RND:
                            Random rnd = new Random();
                            rnd.Next(0, blocks_per_set);

                            nulo_encontrado = (set_int * blocks_per_set) + rnd.Next(0, blocks_per_set);
                            break;
                    }

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

