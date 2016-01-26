using System.Web;

namespace MemoryStorageContainer
{
    public class HttpContainer<T> : IContainer<T>
    {
        private const string Key = "HttpStoreContainerKey";

        public T GetContext()
        {
            var context = default(T);

            if (HttpContext.Current.Items.Contains(Key))
            {
                context = (T)HttpContext.Current.Items[Key];
            }

            return context;
        }

        public void StoreContext(T context)
        {
            if (HttpContext.Current.Items.Contains(Key))
            {
                HttpContext.Current.Items[Key] = context;
            }
            else
            {
                HttpContext.Current.Items.Add(Key, context);
            }
        }
    }
}