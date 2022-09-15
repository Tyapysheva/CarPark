using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.exception
{
    public class ComparisonException : Exception
    {
        public ComparisonException(string message) : base(message)
        {
            this.Message = message;
        }
        public string Message { get; }
    }
}
