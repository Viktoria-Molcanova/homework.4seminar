 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
public static class Lesson456
{
    static void Main()
    {
        /// Пользователь вводит число А
        Console.Write("Введите  число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        ///цикл подсчёта суммы цифр в числе А
        while (A!= 0)
        {
            result += A % 10;
            A /= 10;
        }
        ///Вывод результатов вычислений
        Console.WriteLine($"{result}");

    }
 
}
