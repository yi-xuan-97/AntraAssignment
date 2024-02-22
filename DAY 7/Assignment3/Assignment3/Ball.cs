namespace Assignment3;

public class Ball
{
    // Instance variables
    private int size;
    private Color color;
    private int throwCount;

    // Constructor
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        throwCount = 0;
    }

    // Pop method
    public void Pop()
    {
        size = 0;
    }

    // Throw method
    public void Throw()
    {
        if (size != 0)
        {
            throwCount++;
        }
    }

    // Method to get the throw count
    public int GetThrowCount()
    {
        return throwCount;
    }
}