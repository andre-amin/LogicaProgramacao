using System.Globalization;

int N, pos, maiorIdade;
pos = 0;
maiorIdade = 0;

N = int.Parse(Console.ReadLine());

string[] nome = new string[N];
int[] idade = new int[N];

for(int i = 0; i < N; i++)
{
    string[] S = Console.ReadLine().Split(' ');
    nome[i] = S[0];
    idade[i] = int.Parse(S[1]);

    if (idade[i] > maiorIdade)
    {
        maiorIdade = idade[i];
        pos = i;
    }
}
Console.WriteLine("Pessoa mais velha: " + nome[pos]);