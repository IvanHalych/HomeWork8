using System.Linq;
using System.Xml;

namespace DesignPatterns.ChainOfResponsibility
{
    public class InvertMutator : BaseStringMutator
    {
        public override string Mutate(string str)
        {
            var str1 = new string(str.Reverse().ToArray());
            return base.Mutate(str1);
        }
    }
}
