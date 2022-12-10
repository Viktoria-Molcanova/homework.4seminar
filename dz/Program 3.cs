Console.Write("Введите  число: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (A ! = 0)
    {
    result += A % 10;
    A /= 10;
    }

Console.WriteLine($" {result}");
