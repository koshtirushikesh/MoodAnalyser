using System;

namespace MoodAnalizer
{
    public class MoodAnalizerClass
    {
        string message;
        public MoodAnalizerClass(string message)
        {
            this.message = message;
        }
        public string AnalizeMood()
        {
            try
            {
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch(NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}
