using MoodAnalizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
            catch(MoodAnlyseException ex)
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
                object actual = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalizer.MoodAnalizerClas", "MoodAnalizerClas"); ;
            }
            catch (MoodAnlyseException ex)
            {
                Assert.AreEqual("Class not Found", ex.Message);
            }

        }
    }
}
