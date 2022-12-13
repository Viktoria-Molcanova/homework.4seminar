// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

public static class Lesson4
{
    static void Main()
    {
        /// Пользователь вводит число А
        Console.Write("Введите число A: ");
    
        int A = Convert.ToInt32(Console.ReadLine());
        /// Пользователь вводит число Б
        Console.Write("Введите число B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        int res = A;
        ///Цикл возведения числа А в натуральную степень числа Б
        for (int i = 2; i <= B; i++)
        {
            res *= A;
        ///Вывод результата вычислений
        }
        Console.WriteLine($"{res}");

    }
 
}
