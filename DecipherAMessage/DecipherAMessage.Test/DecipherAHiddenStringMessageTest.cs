using DecipherAMessage.App;
using System;
using Xunit;

namespace DecipherAMessage.Test
{
    public class DecipherAHiddenStringMessageTest
    {
        [Fact]
        public void UsingROT13ToDeciperAStringTest1_Successful()
        {
            //Arrange
            IDecipherAHiddenStringMessageMethod decipherAHiddenStringMessage = new DecipherAHiddenStringMessageMethod();
            var input = "EBG13 rknzcyr.";
            var expected = "ROT13 example.";

            //Act
            var actual = decipherAHiddenStringMessage.UsingROT13ToDeciperAString(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingROT13ToDeciperAStringTest2_Successful()
        {
            //Arrange
            IDecipherAHiddenStringMessageMethod decipherAHiddenStringMessage = new DecipherAHiddenStringMessageMethod();
            var input = "This is my first ROT13 excercise!";
            var expected = "Guvf vf zl svefg EBG13 rkprepvfr!";

            //Act
            var actual = decipherAHiddenStringMessage.UsingROT13ToDeciperAString(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingROT13ToDeciperAStringTest3_Successful()
        {
            //Arrange
            IDecipherAHiddenStringMessageMethod decipherAHiddenStringMessage = new DecipherAHiddenStringMessageMethod();
            var input = "NBNniizVYvgurxAZBmZboAweK*qczcqiBadIuIUMYNTBSt2CDt";
            var expected = "AOAavvmILithekNMOzMobNjrX*dpmpdvOnqVhVHZLAGOFg2PQg";

            //Act
            var actual = decipherAHiddenStringMessage.UsingROT13ToDeciperAString(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
