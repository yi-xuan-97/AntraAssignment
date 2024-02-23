namespace Assignment4;

public class MyStack <T> 
{
    private List<T> stack; // Internal list to hold stack elements

    public MyStack()
    {
        stack = new List<T>(); // Initialize the internal list
    }

    // Method to get the count of elements in the stack
    public int Count()
    {
        return stack.Count;
    }

    // Method to remove and return the top element of the stack
    public T Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        int lastIndex = stack.Count - 1;
        T poppedItem = stack[lastIndex];
        stack.RemoveAt(lastIndex);
        return poppedItem;
    }

    // Method to add an element to the top of the stack
    public void Push(T item)
    {
        stack.Add(item);
    }
}