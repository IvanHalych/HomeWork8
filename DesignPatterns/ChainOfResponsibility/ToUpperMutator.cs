namespace DesignPatterns.ChainOfResponsibility
{
    public class ToUpperMutator : BaseStringMutator
    {
        public override string Mutate(string str)
        {
            var str1 = str.ToUpper();
            return base.Mutate(str1);
        }
    }
}
