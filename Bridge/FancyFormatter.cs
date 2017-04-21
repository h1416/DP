using System;

namespace Bridge
{
    class FancyFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: ----++**++----{value}";
        }
    }
}
