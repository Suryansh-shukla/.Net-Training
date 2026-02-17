using System;
using System.Collections.Generic;
using System.Text;
class Program
{
static void Main()
{
string s=Console.ReadLine();
RunLengthEncoding(s);
}
static void RunLengthEncoding(string s)
{
if(string.IsNullOrEmpty(s))

{
return;
}
StringBuilder result=new StringBuilder();
char[] arr=s.ToCharArray();
int count=1;
for(int i=1;i<arr.Length;i++)
{
if(arr[i]==arr[i-1])
{
count++;
}
else
{
result.Append(arr[i-1]);
result.Append(count);
count=1;
}
}
result.Append(arr[arr.Length-1]);
result.Append(count);
Console.WriteLine(result.ToString());
}

}