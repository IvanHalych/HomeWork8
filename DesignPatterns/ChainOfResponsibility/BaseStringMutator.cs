using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class BaseStringMutator :IStringMutator
    {
        private IStringMutator _mutator;
        public IStringMutator SetNext(IStringMutator next)
        {
            _mutator = next;
            return next;
        }

        public virtual string Mutate(string str)
        {
            if(_mutator != null)
                return _mutator.Mutate(str);
            return str;
        }
    }
}
