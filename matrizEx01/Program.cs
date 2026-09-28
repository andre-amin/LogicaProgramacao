
int L, C, N;

int[,] A;


string[] S = Console.ReadLine().Split(' ');

L = int.Parse(S[0]);
C = int.Parse(S[1]);

A = new int[L,C];

for(int i = 0; i < L; i++)
{
    S = Console.ReadLine().Split(' ');
    
    for(int j = 0; j < C; j++)
    {
        A[i, j] = int.Parse(S[j]);
    }
}
Console.WriteLine("VALORES NEGATIVOS:");

for(int i = 0; i < L; i++)
{
    for(int j = 0; j < C; j++)
    {
        if (A[i,j] < 0)
        {
            Console.WriteLine(A[i, j]);
        }
    }
}
