using HomeBrewToolsWebApp.Models;

namespace HomeBrewToolsWebAppTest
{
    public class HomeBrewToolsWebAppTests
    {
        [Fact]
        public void HomeBrewLog_Type_Is_In_Correct_Regex_Format()
        {
            // Arrange
            HomeBrewLog log = new HomeBrewLog();

            // Act
            string actual = log.Type = "IPA";
            string expected = "^[A-Za-z ]+$";

            // Assert
            Assert.Matches(expected, actual);
        }

        [Fact]
        public void SpecficGravity_Is_In_Correct_Format_Range()
        {
            // Arrange
            HomeBrewLog log = new HomeBrewLog();

            // Act
            decimal actual = log.StartingGravity = 1.052m;


            // Assert
            Assert.InRange(actual, 1.000m, 2.000m);
        }

        [Fact]
        public void UpdatedGravity_Is_In_Correct_Format_Range()
        {
            // Arrange
            HomeBrewLog log = new HomeBrewLog();

            // Act
            decimal actual = (decimal)(log.UpdatedGravity = 1.052m);


            // Assert
            Assert.InRange(actual, 1.000m, 2.000m);
        }

        
    }
}