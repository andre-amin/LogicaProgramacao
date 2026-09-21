using System.Globalization;

int N;

N = int.Parse(Console.ReadLine());

int [] A = new int[N];
int [] B = new int[N];
int [] C = new int[N];

string[] S1 = Console.ReadLine().Split(' ');
string[] S2 = Console.ReadLine().Split(' ');

for(int i = 0; i < N; i++)
{
    A[i] = int.Parse(S1[i]);
    B[i] = int.Parse(S2[i]);
    C[i] = A[i] + B[i];
}


foreach(int i in C)
{
    Console.Write(i.ToString() + " ");
}