using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5ex2
{
    class MatrixMultiply
    {
     
        static void Output(int[,] result)
        {
            for (int r = 0; r < result.GetLength(0); r++)
            {

                for (int c = 0; c < result.GetLength(0); c++)
                {

                    Console.Write("{0} ", result[r, c]);

                }

                Console.WriteLine();

            }
        }
        static int[,] Multiply(int[,] a, int [,] b) 

        {
            int[,] result = new int[2, 2];
            for (int r = 0;r<2;r=r+1) 
            {
                for (int c =0;c<2;c=c+1) 
                {
                    result[r, c] =result[r, c]+ a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }
        //int[,] result = new int[2,2]; 

        //result[0,0]=a[0,0]*b[0,0] + a[0,1]*b[1,0]; 

        //result[0,1]=a[0,0]*b[0,1] + a[0,1]*b[1,1]; 

        //result[1,0]=a[1,0]*b[0,0] + a[1,1]*b[1,0]; 

        //result[1,1]=a[1,0]*b[0,1] + a[1,1]*b[1,1]; 

        return result; 

        } 
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Input( a);

            int[,] b = new int[2,2];
            Input(b);
    
            //int[,] result = new int[2, 2];
            //result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            //result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            //result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            //result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            //Console.Write(result[0, 0] + " ");
            //Console.WriteLine(result[0, 1] + " ");
            //Console.Write(result[1, 0] + " ");
            //Console.WriteLine(result[1, 1] + " ");
            Output(Multiply(a,b));
            Console.ReadKey();
        }
        static void Input(int[,] dst) 
        {
            //Console.WriteLine("vvedi massiv a[0,0]");

            //string s = Console.ReadLine();
            //dst[0, 0] = int.Parse(s);
            //Console.WriteLine("vvedi massiv a[0,1]");
            //string k = Console.ReadLine();
            //dst[0, 1] = int.Parse(k);
            //Console.WriteLine("vvedi massiv a[1,0]");
            //string g = Console.ReadLine();
            //dst[1, 0] = int.Parse(g);
            //Console.WriteLine("vvedi massiv a[1,1]");
            //string v = Console.ReadLine();
            //dst[1, 1] = int.Parse(v);
            for (int i =0; i<2;i=i+1) 
            {
                for (int k=0;k<2;k=k+1) 
                {
                    Console.Write("Enter value for [{0},{1}] : ", i, k);
                    string s = Console.ReadLine();
                    dst[i, k] = int.Parse(s);
                }
                Console.WriteLine();
            }
            
        }
    }
}
