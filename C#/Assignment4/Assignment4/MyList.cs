namespace Assignment4;

public class MyList<T>
{
    private List<T> list = new List<T>();

    public void Add(T element)
    {
        list.Add(element);
    }

    public T Remove(int index)
    {
        while (index < 0 || index >= list.Count)
        {
            Console.WriteLine("Index out of range. Enter another index to remove: ");
            index = Convert.ToInt32(Console.ReadLine());

        }
        T item = list[index];
        list.RemoveAt(index); 
        return item;
    }

    public bool Contains(T element)
    {
        return list.Contains(element);
    }

    public void Clear()
    {
        list.Clear();
    }

    void InsertAt(T element, int index)
    {
        while (index < 0 || index >= list.Count)
        {
            Console.WriteLine("Index out of range. Enter another index to insert: ");
            index = Convert.ToInt32(Console.ReadLine());

        } 
        list.Insert(index, element);
        
    }

    public void DeleteAt(int index)
    {
        while (index < 0 || index >= list.Count)
        {
            Console.WriteLine("Index out of range. Enter another index to delete: ");
            index = Convert.ToInt32(Console.ReadLine());

        }
        list.RemoveAt(index);  
        
        
    }

    public T Find(int index)
    {
        while (index < 0 || index >= list.Count)
        {
            Console.WriteLine("Index out of range. Enter another index to find: ");
            index = Convert.ToInt32(Console.ReadLine());

        }
        return list[index];

    }

}