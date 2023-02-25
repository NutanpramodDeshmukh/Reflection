using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object b = MoodAnalyseFactory.CreaateMoodAnalyse("_Reflection.MoodAnalyseFactory", "MoodAnalyseFactory");
            Console.WriteLine(b.GetType().Name);
        }
    }
}
