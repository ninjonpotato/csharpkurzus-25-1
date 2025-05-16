using System.Collections;

namespace xhscd0_hazi;

public class EntityTarolo<T>: IEntityTarolo<T>
{
    public List<T> objektek = new List<T>();
    public void Add(T entity)
    {
       objektek.Add(entity);
    }

    public void Remove(T entity)
    {
        objektek.Remove(entity);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return objektek.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}