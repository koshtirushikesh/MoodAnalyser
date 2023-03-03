using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    public class MoodAnalizerClass
    {
        public string AnalizeMood(string message)
        {
            if(message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
            
        }
    }
}
