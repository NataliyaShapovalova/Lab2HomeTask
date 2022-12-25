// вывод третьей цифры введенного числа.Либо сообщить,что третьей цифры нет.
Console.WriteLine("Введите число");
String number= Console.ReadLine();

if (number.Length>=3)
{
   Console.Write("третья цифра"+"=");
   Console.WriteLine(number[2]); 
}
else
{
    Console.Write ("третьей цифры нет");
}