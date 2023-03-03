using MoodAnalizer;

namespace MoodAnalizerTestCase
{
    public class Tests
    {
        

        [Test]
        public void GivenSadMood_WhenAnalized_ShouldReturnSad()
        {
            MoodAnalizerClass mood = new MoodAnalizerClass("I am in Sad Mood");
            string result = mood.AnalizeMood();
            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenHappyMood_WhenAnalized_ShouldReturnHappy()
        {
            MoodAnalizerClass mood = new MoodAnalizerClass("I am in Happy Mood");
            string result = mood.AnalizeMood();
            Assert.AreEqual("Sad", result);
        }

    }
}