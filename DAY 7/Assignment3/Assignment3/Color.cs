namespace Assignment3;

public class Color
{
    // Instance variables
    private int red { get; set; }
    private int green { get; set; }
    private int blue { get; set; }
    private int alpha { get; set; }

    // Constructor with red, green, blue, and alpha values
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

    // Constructor with red, green, and blue values (default alpha to 255)
    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }
    

    // Method to get the grayscale value for the color
    public double GetGrayscale()
    {
        return (red + green + blue) / 3.0;
    }
}