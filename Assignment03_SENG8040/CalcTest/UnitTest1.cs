using NUnit.Framework;
using AwesomeCalculator;

namespace CalcTest
{
    [TestFixture]
    public class Tests
    {

        Calc calc = new Calc();

        [Test]
        public void Addition_of_two_integers()
        {
            double a = 5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 9); //assert
        }
        [Test]
        public void Addition_of_two_integers_1()
        {
            double a = 500, b = 400;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 900); //assert fail
        }
        [Test]
        public void Addition_of_two_integers_2()
        {
            double a = 15, b = 14;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 29); //assert
        }


        [Test]
        public void Subtraction_of_two_integers()
        {
            double a = 10, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 9); //assert
        }
        [Test]
        public void Subtraction_of_two_integers_1()
        {
            double a = 500, b = 400;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 100); //assert fail
        }
        [Test]
        public void Subtraction_of_two_integers_2()
        {
            double a = 15, b = 14;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 1); //assert
        }

        [Test]
        public void Multiplication_of_two_integers()
        {
            double a = 10, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 10); //assert
        }
        [Test]
        public void Multiplication_of_two_integers_1()
        {
            double a = 50, b = 40;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 2000); //assert fail
        }
        [Test]
        public void Multiplication_of_two_integers_2()
        {
            double a = 4, b = 14;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 56); //assert
        }
        [Test]
        public void Division_of_two_integers()
        {
            double a = 10, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 10); //assert
        }
        [Test]
        public void Division_of_two_integers_1()
        {
            double a = 50, b = 10;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 5); //assert fail
        }
        [Test]
        public void Division_of_two_integers_2()
        {
            double a = 40, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 10); //assert
        }
        [Test]
        public void Mutation_Test()
        {
            double a = 1, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 0); //assert
        }

        [Test]
        public void Mutation_Test_1()
        {
            double a = 2, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 2); //assert
        }
        [Test]
        public void Mutation_Test_2()
        {
            double a = 9, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 3); //assert
        }


    }
}