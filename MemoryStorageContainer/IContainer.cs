namespace MemoryStorageContainer
{
    public interface IContainer<T>
    {
        T GetContext();
        void StoreContext(T context);
    }
}