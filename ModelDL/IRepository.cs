

namespace ModelDL
{
    public interface IRepository<T>
    {
        void Add(T m_resource);

        List<T> GetAll();

        void Update(T m_resource);
    }
}