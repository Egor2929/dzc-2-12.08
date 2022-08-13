// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6





Console.WriteLine("Введите число: ");
string number3 = Console.ReadLine();
 int i = 2;
if (number3.Length > 0)
{
    if (number3[0] == '-')
    {
        i++;
    }

}
if (number3.Length <= i)
{
    Console.WriteLine($"Количество символово не равно трем  {number3} ");
}
else
{
    Console.WriteLine($"Третья цифра {number3[i]} ");
}