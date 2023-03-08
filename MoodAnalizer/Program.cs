using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MoodAnalizerClass mood = new MoodAnalizerClass("");
            //Console.WriteLine(mood.AnalizeMood()); 
            MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalizer.MoodAnalizerClass", "MoodAnalizerClass");

            Console.ReadLine();
        }
    }
}
