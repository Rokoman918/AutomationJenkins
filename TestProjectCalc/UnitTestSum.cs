namespace TestProjectCalc
{
    public class UnitTestSum
    {
        [Fact]
        public void TestSum()
        {
            //AAA
            //Test of Sum in calculator
            //Arrange
            ApplicationCore.Services.Calc calculator = new ApplicationCore.Services.Calc();
            //Action
            var result = calculator.Sum(5,2);
            //Assert
            Assert.Equal(7, result);


        }
    }
}