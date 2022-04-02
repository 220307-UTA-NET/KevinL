using Xunit;


namespace School.Test
{
    public class StudentTests
    {
        [Fact]
        public void Student_CreateStudentObject_ValidStudent()
        {
            // Arrange
            Student expected = new Student(01, "Kevin");

            // Act
            Student actual = new Student(01, "Kevin");

            // Assert
            Assert.Equals(expected, actual);
        }

        [Fact]
        public void School_GetStudent_ValidStudent()
        {
            // the test that I'm writing shouldno involve calling the SqlRepository 
            // A unit test should DEFINITELY not involve the database, and above all,
            // it should not involve the PRODUCTION database

            //arrange
            Student expected = new Student(4, "Francis");
            Mock<IRepository> mockRepo = new();

            // lamda expression syntax: like an anonymous classlessmethod (delegate)
            // the Mock class sets up its object using these methods calls (Setup, Returns) **Reflection 
            mockRepo.Setup(x => x.GetStudentName(4)).Returns("Kevin");


            //IRepository repo = new SqlRepository(connectionString);

            var school = new School.App.School(mockRepo.Object);

            //act
            Student actual = school.GetStudent(4);
            string actual = Test.GetName();


            //assert
            string expected = "Kevin";
            Assert.Equal(expected, actual)
        }

        [Fact]
        public void School_IntroduceAllTeachers_FormattedString()
        {
            // arrange
            Mock<IRepository> mockRepo = new();
            mockRepo.Setup(x => x.GetAllTeachers()).Reaturns(System.Array.Empty<Teacher>());
            var school = new App.School(mockRepo.Object);

            // act
            string actual = school.IntroduceAllTeachers();

            // assert
            string expected = " *********** Introducing the Teachers of the school! ***********\n\r\n";
            Assert.Equal(expected, actual);
        }
    }
}