using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalizer
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string NameSapceAndclassName, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            bool result = Regex.IsMatch(NameSapceAndclassName, pattern);

            if (result)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(NameSapceAndclassName);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnlyseException(MoodAnlyseException.MoodAnlyseExceptionType.NO_SUCH_CLASS, "Class not Found");
                }
            }
            else
            {
                throw new MoodAnlyseException(MoodAnlyseException.MoodAnlyseExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }
        }
    }
}
