namespace Assignment4.Repositories;

public class GenericRepository<T> : IRepostory<T> where T: class, IEntity
{
    private List<T> data; // Data source for the repository

    public GenericRepository()
    {
        data = new List<T>(); // Initialize the data source
    }

    public void Add(T item)
    {
        data.Add(item); // Add item to the data source
    }

    public void Remove(T item)
    {
        data.Remove(item); // Remove item from the data source
    }

    public void Save()
    {
        // Save changes to the data source (for example, in a database)
        Console.WriteLine("Changes saved successfully.");
    }

    public IEnumerable<T> GetAll()
    {
        return data; // Return all items from the data source
    }

    public T GetById(int id)
    {
        // Find and return item with the specified id from the data source
        return data.Find(x => x.Id == id);
    }
}