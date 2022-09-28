using TowOfBabylon.Models;

namespace TowOfBabylon.Tests
{
    public class BoxStackCalculatorTests
    {

        [Test]
        public void TestSet1()
        {
            //ARRANGE
            var boxArray = new Box[2];
            boxArray[0] = new Box() { Depth = 6, Height = 8, Width = 10 };
            boxArray[1] = new Box() { Depth = 5, Height = 5, Width = 5 };

            //ACT
            var result = BoxStackCalculator.CalculateMaxStackHeight(boxArray);

            //ASSERT
            Assert.That(result, Is.EqualTo(21));
        }

        [Test]
        public void TestSet2()
        {
            //ARRANGE
            var boxArray = new Box[1];
            boxArray[0] = new Box() { Depth = 10, Height = 20, Width = 30 };

            //ACT
            var result = BoxStackCalculator.CalculateMaxStackHeight(boxArray);

            //ASSERT
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void TestSet3()
        {
            //ARRANGE
            var boxArray = new Box[7];
            boxArray[0] = new Box() { Depth = 1, Height = 1, Width = 1 };
            boxArray[1] = new Box() { Depth = 2, Height = 2, Width = 2 };
            boxArray[2] = new Box() { Depth = 3, Height = 3, Width = 3 };
            boxArray[3] = new Box() { Depth = 4, Height = 4, Width = 4 };
            boxArray[4] = new Box() { Depth = 5, Height = 5, Width = 5 };
            boxArray[5] = new Box() { Depth = 6, Height = 6, Width = 6 };
            boxArray[6] = new Box() { Depth = 7, Height = 7, Width = 7 };


            //ACT
            var result = BoxStackCalculator.CalculateMaxStackHeight(boxArray);

            //ASSERT
            Assert.That(result, Is.EqualTo(28));
        }

        [Test]
        public void TestSet4()
        {
            //ARRANGE
            var boxArray = new Box[5];
            boxArray[0] = new Box() { Depth = 31, Height = 41, Width = 59 };
            boxArray[1] = new Box() { Depth = 26, Height = 53, Width = 58 };
            boxArray[2] = new Box() { Depth = 97, Height = 93, Width = 23 };
            boxArray[3] = new Box() { Depth = 84, Height = 62, Width = 64 };
            boxArray[4] = new Box() { Depth = 33, Height = 83, Width = 27 };

            //ACT
            var result = BoxStackCalculator.CalculateMaxStackHeight(boxArray);

            //ASSERT
            Assert.That(result, Is.EqualTo(342));
        }
    }
}