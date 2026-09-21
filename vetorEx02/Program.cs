using System.Globalization;

int N, quantidade;
quantidade = 0;

N = int.Parse(Console.ReadLine());

int[] A = new int[N];
string[] S = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(S[i]);
}

foreach(int num in A)
{
    if(num % 2 == 0)
    {
        quantidade++;
        Console.Write(num.ToString() + " ");
        
    }
}
Console.WriteLine();
Console.Write(quantidade.ToString());