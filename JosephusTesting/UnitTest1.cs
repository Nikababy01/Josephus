using System;
using Xunit;

namespace Josephus.Tests
{
    public class TheRightPersonSurvives
    {
        [Fact]
        public void one_person_with_an_interval_of_one_then_the_only_person_should_survive()
        {
            //throw new Exception();

            //Arrange (Given, Set up the context):
            var numberOfPeople = 1;
            var killingInterval = 1;
            var expectedResult = 1;

            var solver = new JosephusSolver();

            //Act (When)
            var solution = solver.Solve(numberOfPeople, killingInterval);

            //Assert (Then)
            Assert.Equal(expectedResult, solution);
        }

        //[Fact]
        //public void when_two_people_with_an_interval_of_one_then_the_second_person_survives()
        //{
        //    //Arrange
        //    var numberOfPeople = 2;
        //    var killingInterval = 1;
        //    var expectedResult = 2;

        //    var solver = new JosephusSolver();
        //    //Act
        //    var solution = solver.Solve(numberOfPeople, killingInterval);

        //    //Assert
        //    Assert.Equal(expectedResult, solution);
        //}
    }
}
