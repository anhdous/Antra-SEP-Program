namespace Assignment3;

public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;
    
    public int Red
    {
        get
        {
            return red;
        }
        set
        {
            red = value;
        }
    }
    public int Green 
    {
        get
        {
            return green;
        }
        set
        {
            green = value;
        } 
    }
    public int Blue 
    {
        get
        {
            return blue;
        }
        set
        {
            blue = value;
        } 
    }
    public int Alpha 
    {
        get
        {
            return alpha;
        }
        set
        {
            alpha = value;
        } 
    }
    public Color(int red, int green, int blue, int alpha = 255)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public int Grayscale()
    {
        return (Red + Green + Blue) / 3;
    }
}

public class Ball
{
    private int size;
    private Color color;
    private int numThrows;

    public Ball(int size, Color color)
    {
        Size = size;
        Col = color;
        numThrows = 0;
        }
    public int Size { get; set; }
    public Color Col { get; set; }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size != 0)
        {
            numThrows++;
        }
    }

    public int getNumThrows()
    {
        return numThrows;
    }
}