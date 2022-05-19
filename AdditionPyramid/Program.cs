using System;
namespace AdditionPyramid
{
 public class Pyramid
  {
    public static void Main(String[] args)
    {
            int x = 0, y = 1;
            int c, n, j,i;
        Console.Write("Enter the rows:");
         n = int.Parse(Console.ReadLine());
        for (i=1; i<=n; i++)
        {
            x=0;
            y=1;
            Console.Write(y+ "\t");
         for (j=1; j<i; j++)
            {
                c=x+y;
                    Console.Write(c+"\t");
                    x=y;
                    y=c;

            }
            Console.Write("\n");
        }
     }

  }
}
