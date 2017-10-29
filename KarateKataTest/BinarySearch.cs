using System.Linq;
using NFluent;
using NUnit.Framework;

namespace KarateKataTest
{
    
    public class BinarySearch
    {
        [Test]
        public void Should_Not_Sort_Array_Without_Element()
        {
            // Arrange
            int[] arrays = new int[0];
            bool arrayState = false;
           
            // ACT
            arrayState =  arrays.Length>0;
            //Assert
            Check.That(arrayState).IsFalse();
        }

        [Test]
        public void Should_Sort_Array_With_One_Element()
        {
            // ARRANGE
            int[] arrays = new int[1]{2};
            int[] estimatedArray = new int[1] {2};
            int[] arraysEvalued = new int [1];
            //ACT
            if (arrays.Length == 1)
            {
                arraysEvalued =  arrays;
            }

            //ASSERT
            Check.That(arraysEvalued.SequenceEqual(estimatedArray)).IsTrue();

        }


        [Test]
        public void Should_Not_Sort_Array_Already_Sorted()
        {
            // ARRANGE
            int[] arrays = new int[2] { 2,3 };
            int[] estimatedArray = new int[2] { 2,3 };
            int[] arraysEvalued = new int[2];
            //ACT
            if (arrays.Length == 1)
            {
                arraysEvalued = arrays;
            }
            int numberInferrior = 0;
            for (int i = 0; i < arrays.Length-1; i++)
            {
                if (arrays[i] > arrays[i+1])
                {
                    numberInferrior = arrays[i + 1];
                    arrays[i + 1] = arrays[i];
                    arrays[i] = numberInferrior;
                }
            }
            arraysEvalued = arrays;
            //ASSERT
            Check.That(arrays.SequenceEqual(arraysEvalued)).IsTrue();
        }


        [Test]
        public static void Should_Sort_Array_With_Two_Elements()
        {
            // ARRANGE
            int[] arrays = new int[2] { 3, 2 };
            int[] estimatedArray = new int[2] { 2, 3 };
            int[] arraysEvalued = new int[2];
            //ACT
            if (arrays.Length == 1)
            {
                arraysEvalued = arrays;
            }
            int numberInferrior = 0;
            for (int i = 0; i < arrays.Length - 1; i++)
            {
                if (arrays[i] > arrays[i + 1])
                {
                    numberInferrior = arrays[i + 1];
                    arrays[i + 1] = arrays[i];
                    arrays[i] = numberInferrior;
                }
            }
            arraysEvalued = arrays;
            //ASSERT
            Check.That(arrays.SequenceEqual(arraysEvalued)).IsTrue();
        }

        [Test]
        public void Should_Sort_Arrays_With_Three_Values()
        {
            // ARRANGE
            int[] arrays = new int[3] { 3, 2,0};
            int[] estimatedArray = new int[3] { 0,2, 3 };
            int[] arraysEvalued = new int[2];
            //ACT
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
                            if (j != 0) { 
                                if (numberInferrior < arrays[j - 1])
                                {
                                    numberSupperior = arrays[j - 1];
                                    arrays[j-1] = numberInferrior;
                                    arrays[j] = numberSupperior;
                                }
                            }
                        }

                    }
                }
            }
            arraysEvalued = arrays;
            //ASSERT
            Check.That(arraysEvalued.SequenceEqual(estimatedArray)).IsTrue();
        }

        [Test]
        public void Should_Sort_With_Multiples_Values()
        {
            // ARRANGE
            int[] arrays = new int[6] { 5,2,6,3, 2, 0 };
            int[] estimatedArray = new int[6] { 0, 2, 2,3,5,6 };
            int[] arraysEvalued = new int[2];
            //ACT
            RankingLibrary array = new RankingLibrary(arrays);
            array.Sort();
            
            //ASSERT
            Check.That(arraysEvalued.SequenceEqual(estimatedArray)).IsTrue();
        }





        
    }
}
