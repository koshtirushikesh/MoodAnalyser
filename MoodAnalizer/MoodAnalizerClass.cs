using System;
using static MoodAnalizer.MoodAnlyseException;

namespace MoodAnalizer
{
    public class MoodAnalizerClass
    {
        string message;
        public MoodAnalizerClass()
        {
            message = null;
        }
        public MoodAnalizerClass(string message)
        {
            this.message = message;
        }
        public string AnalizeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                    throw new MoodAnlyseException(MoodAnlyseExceptionType.EmptyMood, "Please do not Enter the empty Input");
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnlyseException(MoodAnlyseExceptionType.NullMood, "Please do not Enter the Null Input");
            }
        }
    }
}
