//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
Console.WriteLine("Введите число: "); //Приглашение пользователя ко вводу числа (вывод в терминал)
//int number = int.Parse(Console.ReadLine()); так можно конвертировать из строки в число
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
System.Console.WriteLine("Квадрат введеного числа равен: " + result); //можно так выводить, это неформатированная строка
System.Console.WriteLine($"Квадрат введеного числа равен: {result} вот так вот круто");