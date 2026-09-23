using System.Globalization;

//Declaração dos tipos de variáveis e seus valores
int N, contadorHomens, contadorMulheres;
double maiorAltura, menorAltura, mediaAlturaMulheres, totalAlturaMulheres;


mediaAlturaMulheres = 0.0;
totalAlturaMulheres = 0.0;
contadorHomens = 0;
contadorMulheres = 0;

//Input de quantos elementos serão analisados
N = int.Parse(Console.ReadLine());

//Declaração de arrays
double[] altura = new double[N];
char[] sexo = new char[N];


//Alocação de dados nas arrays
for (int i = 0; i < N; i++)
{
    string[] S = Console.ReadLine().Split(' ');
    altura[i] = double.Parse(S[0], CultureInfo.InvariantCulture);
    sexo[i] = char.Parse(S[1]);    
}

//Atribuição de valores para checagem de altura min/max e checagem
maiorAltura = altura[0];
menorAltura = altura[0];


for (int i = 0; i < N; i++)
{
    if (altura[i] < menorAltura)
    {
        menorAltura = altura[i];
    }
    
    if (altura[i] > maiorAltura)
    {
        maiorAltura = altura[i];
    }
}

//Separação entre sexos M e F
for (int i = 0; i < N; i++)
{
    if (sexo[i] == 'F')
    {
        totalAlturaMulheres += altura[i];
        contadorMulheres++;
    }
    if (sexo[i] == 'M')
    {
        contadorHomens++;
    }
}

//Cálculo da média de altura somente entre mulheres
mediaAlturaMulheres = totalAlturaMulheres / contadorMulheres;


//Print dos resultados na tela de prompt
Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Media das alturas das mulheres = " + mediaAlturaMulheres.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Numero de homens = " + contadorHomens.ToString());
