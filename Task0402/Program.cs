int a; 
Console.WriteLine("Введите число ");
a = int.Parse(Console.ReadLine());
if (a <= 5)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Выходной день");
}