using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object b = AnalyseFactory.CreaateMoodAnalyse("Reflection.AnalyseFactory", "AnalyseFactory");
            Console.WriteLine(b.GetType().Name);
        }
        public static void InvokeAMethod(string message, string MethodName)
        {
            var type = typeof(MoodAnalyse);
            MethodInfo invokingMethod = null;
            ConstructorInfo constor = type.GetConstructor(new[] { typeof(string) });

            foreach (var method in type.GetMethods())
            {
                if (method.Name == MethodName)
                    invokingMethod = method;

            }
            if (invokingMethod != null)
            {
                object obj = constor.Invoke(new object[] { message });
                var s = invokingMethod.Invoke(obj, new string[] { });
                Console.WriteLine(s);

            }
        }
    }
}
