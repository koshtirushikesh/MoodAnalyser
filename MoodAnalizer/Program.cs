using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MoodAnalizerClass mood = new MoodAnalizerClass(null);
            Console.WriteLine(mood.AnalizeMood()); 
            Console.ReadLine();
        }
    }
}
