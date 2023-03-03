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
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Sad";

        }
    }
}
