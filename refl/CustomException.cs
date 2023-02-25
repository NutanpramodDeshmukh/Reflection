using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class CustomException:Exception
    {
        public enum ExceptionType
        {
            Null_message,
            Empty_message,
            No_Such_Class,
            No_Such_Method
        }

        public readonly ExceptionType Type;

        public CustomException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
    }
}
