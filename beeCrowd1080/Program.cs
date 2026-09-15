int num, pos, N;
num = 0;
pos = 0;

for (int i = 1; i <= 100; i++)
{
    
    N = int.Parse(Console.ReadLine());

    if (N > num)
    {
        num = N;
        pos = i;
    }


}
Console.WriteLine(num.ToString());
Console.WriteLine(pos.ToString());