using System;
using System.Linq;

namespace Bridge
{
    class BackwardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {new string(value.Reverse().ToArray())}";
        }
    }
}
