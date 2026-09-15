using System.Globalization;

int N = int.Parse(Console.ReadLine());

double X, Y, Z, media;

for(int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    
    
    X = double.Parse(vet[0], CultureInfo.InvariantCulture);
    Y = double.Parse(vet[1], CultureInfo.InvariantCulture);
    Z = double.Parse(vet[2], CultureInfo.InvariantCulture);

    media = ((X * 2) + (Y * 3) + (Z * 5)) / 10;
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}