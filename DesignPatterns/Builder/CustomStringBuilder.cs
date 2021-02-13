using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class CustomStringBuilder : ICustomStringBuilder
    {
        private readonly List<string> _list;
        public CustomStringBuilder()
        {
            _list = new List<string>();
        }

        public CustomStringBuilder(string text)
        {
            _list = new List<string>(){text};
        }

        public ICustomStringBuilder Append(string str)
        {
            _list.Add(str);
            return this;
        }

        public ICustomStringBuilder Append(char ch)
        {
            _list.Add(ch.ToString());
            return this;
        }

        public ICustomStringBuilder AppendLine()
        {
            _list.Add("\n");
            return this;
        }

        public ICustomStringBuilder AppendLine(string str)
        {
            _list.Add(str +"\n");
            return this;
        }

        public ICustomStringBuilder AppendLine(char ch)
        {
            _list.Add(ch.ToString()+"\n");
            return this;
        }

        public string Build()
        {
            return  string.Join("",_list);
        }
    }
}
