using AnimalsTest;

namespace TestAnimals
{
    public class UnitTest1
    {
        [Fact]
        public void VoiceLion()
        {
            var lion = new Lion();
            var actual = lion.Voice();
            string expectedVoice = "I am a lion - king of jungle";
            Assert.Equal(expectedVoice, actual);

        }

        [Fact]
        public void VoiceJaguar()
        {
            var jaguar = new Jaguar();
            var actual = jaguar.Voice();
            string expectedVoice = "I am jaguar.Dangerous kitty";
            Assert.Equal(expectedVoice, actual);
        }

        [Fact]
        public void DistanceLion()
        {
            var lion = new Lion();           
            var actual = lion.Distance(1);
            var expectedValue = 80;
            Assert.Equal(expectedValue, actual);
            
        }
        [Fact]
        public void NameLion()
        {
            var lion = new Lion();
            var actualName = "Tor";
            bool valid = lion.IsValidName(actualName);
            Assert.True(valid);

        }
    }
}