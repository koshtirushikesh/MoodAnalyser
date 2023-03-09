using System;
using System.CodeDom;
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
                    throw new MoodAnlyseException(MoodAnlyseException.MoodAnlyseExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new MoodAnlyseException(MoodAnlyseException.MoodAnlyseExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }

        public static object CreateMoodAnalyserWithParameterConstructor(string NameSapceAndclassName, string constructorName)
        {
            Type type = typeof(MoodAnalizerClass);

            if (type.Name.Equals(NameSapceAndclassName) || type.FullName.Equals(NameSapceAndclassName))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] {typeof(string)} );
                    object instance = ctor.Invoke(new object[] {"happy"});
                    return instance;
                }
                else 
                {
                    throw new MoodAnlyseException(MoodAnlyseException.MoodAnlyseExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new MoodAnlyseException(MoodAnlyseException.MoodAnlyseExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }
    }
}
