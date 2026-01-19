using System;
class Program
{
    static void Main(string[] args)
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int upto=Convert.ToInt32(Console.ReadLine());
        int[] row=new int[upto];
        if(upto>0)
        {
           for(int i=1;i<=upto;i++)
            {
                row[i-1]=n*i;
            }
        }
        foreach(int num in row)
        {
            Console.WriteLine(num);
        }
    }
}