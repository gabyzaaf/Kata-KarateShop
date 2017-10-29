using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace KarateKataTest
{
    public class BinarySearchTest
    {


        [Test]
        public void Should_Divised_The_Array_Size_By_Two()
        {
            // ARRANGE
            var array = new int[6] { 0, 1, 2, 3,2,4 };

            // ASSERT
            var number = array.Length / 2;
            //ACT
            Check.That(number).IsEqualTo(3);


        }

        [Test]
        public void Should_Cute_The_Array_In_Two_Part_And_Display_The_Right()
        {
            // ARANGE
            var array = new int[4]{0,1,2,3};
            int[] arrayEvalued = new int[2];
            int[] arrayResult = new int[2]{2,3};
            int indiceForTheArrayEvalues = 0;
            //ACT
            var number = array.Length / 2;
            
            for (int i = number;i<array.Length;i++)
            {
                arrayEvalued[indiceForTheArrayEvalues] = array[i];
                indiceForTheArrayEvalues++;
            }

            //ASSERT
            Check.That(arrayEvalued.SequenceEqual(arrayResult)).IsTrue();

        }

    }
}
