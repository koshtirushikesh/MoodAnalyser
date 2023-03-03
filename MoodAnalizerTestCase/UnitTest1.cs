using MoodAnalizer;

namespace MoodAnalizerTestCase
{
    public class Tests
    {
        MoodAnalizerClass mood = new MoodAnalizerClass();

        [Test]
        public void GivenSadMood_WhenAnalized_ShouldReturnSad()
        {
            string result = mood.AnalizeMood("I am in Sad Mood");
            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenHappyMood_WhenAnalized_ShouldReturnHappy()
        {
            string result = mood.AnalizeMood("I am in Happy Mood");
            Assert.AreEqual("Happy", result);
        }

    }
}