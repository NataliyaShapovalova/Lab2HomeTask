//Показать вторую цивру введенного трехзначного числа
Console.Write("Введите трехзначное число:");
int number= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(number/10%10);