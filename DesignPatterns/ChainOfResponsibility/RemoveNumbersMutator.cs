using System.Linq;

namespace DesignPatterns.ChainOfResponsibility
{
    public class RemoveNumbersMutator : BaseStringMutator
    {
        public override string Mutate(string str)
        {
            var str1 = new string(str.Where(c => !int.TryParse(c.ToString(), out _)).ToArray());
            return base.Mutate(str1);
        }
    }
}
