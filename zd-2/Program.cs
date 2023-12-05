// Задача 1: Напишите программу, которая бесконечно
//запрашивает целые числа с консоли. Программа
//завершается при вводе символа ‘q’ или при вводе
//числа, сумма цифр которого четная.

//5 12 16 q [STOP]
//3 45 342 15 [STOP]

string text = "lol";
string text2 = "4";




int ToNum (string text)
{
//if(text == "" && text == null)
//{
//    return false;
//}
int num;
bool isNum = Int32.TryParse(text, out num);
if (isNum)
{
    num = Convert.ToInt32(text);
    return num;
}
else
{
    return 0;
}
}