using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPAssignment2;
using NUnit.Framework;

namespace NPAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void AnalyzeMethod_GivenAllInputs_5_Results_Equilateral_Traingle()
        {
            //Arrange
            String actual = "";
            String expected = "15Equilateral triangle";

            //Act
            actual = EquilateralTriangle.Analyze(5, 5, 5);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeMethod_GivenTwoInput10_OtherIs8_ResultIs_Isosceles_Triangle()
        {
            // Arrange
            String actual = " ";
            String expected = "28Isosceles triangle";

            // Act
            actual = EquilateralTriangle.Analyze(10, 10, 8);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeMethod_GivenInputs_9_13_14_ResultIs_Scalene_Triangle()
        {
            // Arrange
            String actual = " ";
            String expected = "36Scalene triangle";

            // Act
            actual = EquilateralTriangle.Analyze(9, 13, 14);
            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void AnalyzeMethod_GivenInputs_CheckingIfNumbers_ValidToFormTraingle()
        {
            // Arrange
            String actual = " ";
            String expected = "Numbers not valid to form traingle";

            // Act
            actual = EquilateralTriangle.Analyze(1, 2, 3);

            // Assert
            Assert.AreEqual(expected, actual);
        }






    }
}
