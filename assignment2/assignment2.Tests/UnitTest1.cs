using System;
using Xunit;

namespace assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Student_toString()
        {
            //Arrange
            var student1 = new student(2929, "gu", "ho", new DateTime(2020, 8, 30, 7, 0, 0), new DateTime(2023, 8, 30, 7, 0, 0));
            //Act
            string expected = "Student ID: 2929, Student name: gu ho, Status: New, StartDate: 30/08/2020 07.00.00, EndDate: 30/08/2023 07.00.00, GraduationDate: 30/08/2023 07.00.00";

            //Assert
            Assert.Equal(expected, student1.ToString());
        }
        [Fact]
        public void immutablestudent_toString() 
        {
            //Arrange
            var student1 = new immutablestudent()
            {
                Id = 2929,
                GivenName = "gu",
                Surname = "ho",
                StartDate = new DateTime(2020, 8, 30, 7, 0, 0),
                EndDate = new DateTime(2023, 8, 30, 7, 0, 0),
                GraduationDate = new DateTime(2023, 8, 30, 7, 0, 0)
            };
            //Act
            string expected = "Student ID: 2929, Student name: gu ho, Status: New, StartDate: 30/08/2020 07.00.00, EndDate: 30/08/2023 07.00.00, GraduationDate: 30/08/2023 07.00.00";

            //Assert
            Assert.Equal(expected, student1.ToString());
        }
        [Fact]
        public void immutablestudent_exact_same() 
        {
            //Arrange
            var student1 = new immutablestudent()
            {
                Id = 2929,
                GivenName = "gu",
                Surname = "ho",
                StartDate = new DateTime(2020, 8, 30, 7, 0, 0),
                EndDate = new DateTime(2023, 8, 30, 7, 0, 0),
                GraduationDate = new DateTime(2023, 8, 30, 7, 0, 0)
            };

            var student2 = new immutablestudent()
            {
                Id = 2929,
                GivenName = "gu",
                Surname = "ho",
                StartDate = new DateTime(2020, 8, 30, 7, 0, 0),
                EndDate = new DateTime(2023, 8, 30, 7, 0, 0),
                GraduationDate = new DateTime(2023, 8, 30, 7, 0, 0)
            };

            //Assert
            Assert.Equal(student1, student2);
        }
    }
}
