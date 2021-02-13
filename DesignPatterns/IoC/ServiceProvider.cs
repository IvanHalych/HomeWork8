using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IoC
{
    class ServiceProvider : IServiceProvider
    {
        public ServiceProvider(Dictionary<Type, object> _transients, Dictionary<Type, object> _singletons)
        {
            this._singletons = _singletons;
            this._transients = _transients;
        }

        private readonly Dictionary<Type, object> _transients = new Dictionary<Type, object>();
        private readonly Dictionary<Type, object> _singletons = new Dictionary<Type, object>();
        public T GetService<T>()
        {
            var type = typeof(T);
            if (_transients.ContainsKey(type))
            {
                if (_transients[type] != null)
                {
                    switch (_transients[type])
                    {
                        case Func<T> factory:
                            return factory.Invoke();
                        case Func<IServiceProvider, T> serviceProvider:
                            return serviceProvider.Invoke(this);
                    }
                }
                else
                {
                    return (T) GetObjectWithDefaultConstructor<T>();
                }
            }
            else if (_singletons.ContainsKey(type))
            {
                if (_singletons[type] != null)
                {
                    return (T)_singletons[type];
                }
                else
                {
                    _singletons[type] = GetObjectWithDefaultConstructor<T>(); ;
                    return (T)_singletons[type];
                }
            }
            return default;
        }
        private static object GetObjectWithDefaultConstructor<T>()
        {
            return typeof(T).GetConstructor(Type.EmptyTypes)?.Invoke(Type.EmptyTypes);
        }

    }
}
