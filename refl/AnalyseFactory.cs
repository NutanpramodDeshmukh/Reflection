using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reflection
{
    public class AnalyseFactory
    {
        public static object CreaateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match reult = Regex.Match(className, pattern);

            if (reult.Success)
            {
                try
                {

                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type type = assembly.GetType(className);
                    return Activator.CreateInstance(type);

                }
                catch (Exception)
                {
                    throw new CustomException(CustomException.ExceptionType.Null_message, "class not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.No_Such_Method, "Method not Found");
            }
        }

    }
}
