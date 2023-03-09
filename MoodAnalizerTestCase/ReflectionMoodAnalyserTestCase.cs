using MoodAnalizer;

namespace MoodAnalizerTestCase
{
    public class ReflectionMoodAnalyserTestCase
    {
        [Test]
        public void GivenClassName_Should_Return_Object()
        {
            try
            {
                object expected = new MoodAnalizerClass(null);
                object actual = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalizer.MoodAnalizerClass", "MoodAnalizerClass"); ;
                expected.Equals(actual);
            }
            catch (MoodAnlyseException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [Test]
        public void GivenImproperClassName_Should_ThrowMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalizerClass(null);
                object actual = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalizer.MoodAnalizerClass", "MoodAnalizerClass1"); ;
            }
            catch (MoodAnlyseException ex)
            {
                Assert.AreEqual("Class not Found", ex.Message);
            }
        }

        [Test]
        public void GivenImproperConstructorName_Should_ThrowMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalizerClass(null);
                object actual = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalizer.MoodAnalizerClass1", "MoodAnalizerClass1"); ;
            }
            catch (MoodAnlyseException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }
        [Test]
        public void GivenProperConstructorNameWithParameter_Should_ReturnObject()
        {
            object expected = new MoodAnalizerClass("Happy");
            object actual = MoodAnalyserFactory.CreateMoodAnalyserWithParameterConstructor("MoodAnalizer.MoodAnalizerClass", "MoodAnalizerClass"); ;
            expected.Equals(actual);
        }

        [Test]
        public void GivenImproperClassNameWithParameterConstructor_Should_ThrowMoodAnalysisExceptionOfNoSuchClass()
        {
            try
            {
                object expected = new MoodAnalizerClass(null);
                object actual = MoodAnalyserFactory.CreateMoodAnalyserWithParameterConstructor("MoodAnalizer.MoodAnalizerClass1", "MoodAnalizerClass"); ;
            }
            catch (MoodAnlyseException ex)
            {
                Assert.AreEqual("Class not Found", ex.Message);
            }
        }
    }
}
