// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.WriteLine("Введите число: "); 
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int index = - number;
while (index <= number)
{
    System.Console.Write(index + "; ");
    index++;   /*аналог команды "увеличить на единицу" "index = index + 1*/
}
