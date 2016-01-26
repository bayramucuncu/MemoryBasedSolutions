using System.Web;

namespace MemoryStorageContainer
{
    public static class ContainerFactory<T>
    {
        private static IContainer<T> _container;

        public static IContainer<T> GetContainer()
        {
            if (_container != null)
                return _container;
            
            if (HttpContext.Current != null)
                _container = new HttpContainer<T>();
            else
                _container = new ThreadContainer<T>();
            
            return _container;
        }

    }
}