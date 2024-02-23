namespace Assignment4;

public class MyList <T>
{
    private T[] items; // Internal array to hold list elements
    private int count; // Current number of elements in the list
    private const int DefaultCapacity = 4; // Default initial capacity of the list

    public MyList()
    {
        items = new T[DefaultCapacity]; // Initialize the internal array with default capacity
        count = 0; // Initially, the list is empty
    }

    // Method to add an element to the end of the list
    public void Add(T element)
    {
        EnsureCapacity();
        items[count++] = element;
    }

    // Method to remove and return an element at the specified index
    public T Remove(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        T removedItem = items[index];

        // Shift elements to fill the gap left by the removed element
        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        items[count - 1] = default(T); // Set the last element to default value
        count--; // Decrement the count

        return removedItem;
    }

    // Method to check if the list contains a specific element
    public bool Contains(T element)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Equals(element))
            {
                return true;
            }
        }
        return false;
    }
    
    // Method to count all elements from the list
    public int Count()
    {
        return count;
    }
    
    // Method to clear all elements from the list
    public void Clear()
    {
        Array.Clear(items, 0, count); // Clear the array
        count = 0; // Reset the count
    }

    // Method to insert an element at the specified index
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > count)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        EnsureCapacity();

        // Shift elements to make space for the new element
        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }

        items[index] = element;
        count++; // Increment the count
    }

    // Method to delete an element at the specified index
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        // Shift elements to fill the gap left by the deleted element
        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        items[count - 1] = default(T); // Set the last element to default value
        count--; // Decrement the count
    }

    // Method to find and return an element at the specified index
    public T Find(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        return items[index];
    }

    // Private method to ensure the capacity of the internal array
    private void EnsureCapacity()
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2); // Double the capacity
        }
    }
}