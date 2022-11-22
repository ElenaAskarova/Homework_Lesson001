Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Большее число:");
    Console.Write(num1);
    Console.WriteLine("Меньшее число:");
    Console.Write(num2);
}
else
{
    Console.Write("Большее число:");
    Console.WriteLine(num2);
    Console.Write("Меньшее число:");
    Console.WriteLine(num1);
}