// Задача 1: Напишите программу, которая бесконечно
//запрашивает целые числа с консоли. Программа
//завершается при вводе символа ‘q’ или при вводе
//числа, сумма цифр которого четная.

//5 12 16 q [STOP]
//3 45 342 15 [STOP]


string text = "";
int num;

while(text != "q")
{
    text = Console.ReadLine();
    bool isNum = Int32.TryParse(text, out num);

    if (isNum)
    {
        int number = Convert.ToInt32(text);
        if(IsSumIsEven(number))
        {
            break;
        }
    }
    else
    {
        break;
    }
}

bool IsSumIsEven (int num) 
{
int sum = 0;
while(num > 0)
{
    sum += num%10;
    num /= 10;
}
if(sum % 2 == 0)
{
    return true; //не работает дальше
}
else
{
    return false; //работаем дальше
}
}
