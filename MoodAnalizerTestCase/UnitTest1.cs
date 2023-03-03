using MoodAnalizer;

namespace MoodAnalizerTestCase
{
    public class Tests
    {
        MoodAnalizerClass mood = new MoodAnalizerClass("I am in Sad Mood");

        [Test]
        public void GivenSadMood_WhenAnalized_ShouldReturnSad()
        {
            string result = mood.AnalizeMood();
            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenHappyMood_WhenAnalized_ShouldReturnHappy()
        {
            string result = mood.AnalizeMood();
            Assert.AreEqual("Sad", result);
        }

    }
}