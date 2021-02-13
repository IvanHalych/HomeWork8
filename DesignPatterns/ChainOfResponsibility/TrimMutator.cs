namespace DesignPatterns.ChainOfResponsibility
{
    public class TrimMutator : BaseStringMutator
    {
        public override string Mutate(string str)
        {
            var str1 = str.Trim();
            return base.Mutate(str1);   
        }
    }
}
