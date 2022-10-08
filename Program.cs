  //  Задача 10: Напишите программу, которая принимает на вход 
  //  трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем


// Console.WriteLine("Ввудите трехзначное число!");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ((a%100)/10);



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введи число: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 100)
{
  Console.WriteLine("-> третьей цифры нет");
  return;
}
int thirdNumber = 0;
if (a > 99 && a < 1000){
 thirdNumber = (a % 100) % 10;
}
if (a > 999 && a < 10000){
 thirdNumber = (a % 100) / 10;
}
if (a > 9999 && a < 100000){
 thirdNumber = (a % 1000) / 100;
}
Console.WriteLine($"Третья цифра числа {a}->{thirdNumber}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7


// Console.Write("Введи цифру, обозначающую день недели: ");
// int numberDay = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek (int numberDay) {
//   if (numberDay == 6 || numberDay == 7) {
//   Console.WriteLine($"{numberDay} -> да");
//   }
//   else if (numberDay < 1 || numberDay > 7) {
//     Console.WriteLine($"{numberDay} -> это вообще не день недели " );
//   }
//   else Console.WriteLine($"{numberDay}  -> нет");
// }

// CheckingTheDayOfTheWeek(numberDay);


