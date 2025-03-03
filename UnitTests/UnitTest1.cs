namespace io2;

public class UnitTest1
{
        [Fact]
        public void CheckString_Returns0_WhenStringIsEmpty()
        {
            var stringUtils = new StringUtils();

            var result = stringUtils.CheckString("");

            Assert.Equal(0, result);
        }
}