namespace KarateKataRanking
{
    public class RankingLibrary
    {
        private int[] arrays = null;

        public RankingLibrary(int[] arrays)
        {
            this.arrays = arrays;
        }

       
        

        public int[] Sort()
        {
            int[] arraysEvalued = arrays;
            if (arrays.Length == 1)
            {
                arraysEvalued = arrays;
            }
            int numberInferrior = 0;
            int numberSupperior = 0;
            for (int i = 0; i < arrays.Length - 1; i++)
            {
                if (arrays[i] > arrays[i + 1])
                {
                    numberInferrior = arrays[i + 1];
                    arrays[i + 1] = arrays[i];
                    arrays[i] = numberInferrior;
                    if (i > 0)
                    {
                        for (int j = i; j > 0; j--)
                        {
                            if (j != 0)
                            {
                                if (numberInferrior < arrays[j - 1])
                                {
                                    numberSupperior = arrays[j - 1];
                                    arrays[j - 1] = numberInferrior;
                                    arrays[j] = numberSupperior;
                                }
                            }
                        }
                    }
                }
            }
            return arraysEvalued;
        }
    }
}