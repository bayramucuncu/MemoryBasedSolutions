using System.Threading;

namespace MemoryStorageContainer
{
    public class ThreadContainer<T> : ThreadContainerBase, IContainer<T>
    {
        public T GetContext()
        {
            var context = default(T);

            if (Containers.Contains(ThreadName))
            {
                context = (T)Containers[ThreadName];
            }

            return context;
        }

        public void StoreContext(T context)
        {
            if (Containers.Contains(ThreadName))
            {
                Containers[ThreadName] = context;
            }
            else
            {
                Containers.Add(ThreadName, context);
            }
        }

        private static string ThreadName
        {
            get
            {
                return Thread.CurrentThread.Name;
            }
        }
    }
}