//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int SecondDigital()
{
    Console.WriteLine("Imput three-digit number");
    int number=Convert.ToInt32(Console.ReadLine());
    int dec = number/10;
    int result = dec%10;
    Console.WriteLine("Second digital " + result);
    return result;
}
SecondDigital();*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThirdDigital()
{
  Console.WriteLine("Imput number");
  int number=Convert.ToInt32(Console.ReadLine());
  int number2;
  int index=0;
while(number<100){
    Console.WriteLine("Третьего числа нет");
    break;
}
while(number>1000){
  number=number/10;
  index++;
}
number2=number%10;

Console.WriteLine(number2);
return number;
}
ThirdDigital();


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*int number;
Console.Write("Imput a number ");
number = Convert.ToInt32(Console.ReadLine());

if(number==1)
{
    Console.WriteLine("Не повезло, потерпи");
}
else if(number ==2)
{
    Console.WriteLine("Не повезло, потерпи");
}
else if(number ==3)
{
    Console.WriteLine("Не повезло, потерпи");
}
else if(number ==4)
{
    Console.WriteLine("Не повезло, потерпи");
}
else if(number ==5)
{
    Console.WriteLine("Еще чуть чуть");
}
else if(number ==6)
{
    Console.WriteLine("Ура! Суббота, выходной!");
}
else if(number ==7)
{
    Console.WriteLine("Ура! Воскресенье, выходной!");
}*/