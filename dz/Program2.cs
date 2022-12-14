//Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
static class Lesson456
{
    static void Main()
    {
      //Создание массива
       static int[] CreateArray(int count)
      {
      return new int [count];
      }
       static void Fill(int[] array)
      //Заполнение  массива случайными числами
      {
     for (int i = 0; i < array.Length; i++)
     {
      array [i] = new Random().Next(0,14);
     }
      }
      //Печать массива
            static string Print(int[]array);
            {
            return String.Join(array);
            }
            //Конвертация чисел из 10 в 15-ую систему исчисления
            static int ToDec(int[] value)
            {
            
              int result = 0;
              int count=value.Length;
            
              static int Pow(int a, int b)
              {
              for (int i = 0; i < value.Length; i++)
              {
              result = result + value[i]*Pow(15, count-1-i);
               }
              }
             return result;
             }
              
      Console.WriteLine(new int[]{3,88,64});
           
    }
    
     
}

