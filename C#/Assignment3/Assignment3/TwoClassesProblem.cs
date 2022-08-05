namespace Assignment3;

public class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
    public int Alpha { get; set; }
    public Color(int red, int green, int blue, int alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }
    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;
    }

    public int GetGrayscale()
    {
        return (Red + Green + Blue) / 3;
    }
}

public class Ball
{
    private int numThrows;

    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
        numThrows = 0;
        }
    public int Size { get; set; }
    public Color Color { get; set; }

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