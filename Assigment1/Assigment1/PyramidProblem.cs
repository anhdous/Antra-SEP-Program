namespace Assigment1;

public class PyramidProblem
{
    public void PrintAPyramid()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 4-i; j>0;j--)
            {
                Console.Write(" ");
            }

            for (int k=2*i+1; k >0;k--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
            
    }
}