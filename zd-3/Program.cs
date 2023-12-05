// Задача 1: Напишите программу, которая бесконечно
//запрашивает целые числа с консоли. Программа
//завершается при вводе символа ‘q’ или при вводе
//числа, сумма цифр которого четная.

//5 12 16 q [STOP]
//3 45 342 15 [STOP]
string text = Console.ReadLine();

int num;
bool isNum = Int32.TryParse(text, out num);

if (isNum)
{
    int number = Convert.ToInt32(text);
    if(IsSumIsOdd(number))
    {
        Console.WriteLine("go");
    }
}



bool IsSumIsOdd (int num)
{
int sum = 0;
while(num > 0)
{
    sum += num%10;
    num /= 10;
}
if(sum % 2 == 0)
{
    return false; //не работает дальше
}
else
{
    return true; //работаем дальше
}
}


