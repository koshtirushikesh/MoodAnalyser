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
        

    }
}