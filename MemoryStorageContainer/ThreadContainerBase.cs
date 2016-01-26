using System.Collections;

namespace MemoryStorageContainer
{
    public class ThreadContainerBase
    {
        protected static Hashtable Containers;

        public ThreadContainerBase()
        {
            Containers = new Hashtable();
        }
    }
}