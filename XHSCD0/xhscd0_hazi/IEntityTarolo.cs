using System.Net.Sockets;

namespace xhscd0_hazi;

public interface IEntityTarolo<T>: IEnumerable<T>
{
    public void Add(T entity);
    public void Remove(T entity);
}