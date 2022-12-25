// Принимает на вход цифру дня недели и проверяет, является ли этот день выходным
Console.WriteLine("Введите номер дня недели (цифра от 1 до 7)");
int d= Convert.ToInt32(Console.ReadLine());
if (d==6)
{
    Console.Write("Да,это выходной");
}
else if (d==7)
{
    Console.Write("Да,это выходной");
}
else
{
   Console.Write("Нет,это не выходной"); 
}
