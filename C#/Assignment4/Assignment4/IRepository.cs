using System.Data;

namespace Assignment4;

public interface IRepository<T> where T: class
{
    void Add(T item);
    void Remove(T item);
    List<T> GetAll();
    T GetById(int id);
}