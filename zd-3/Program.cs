// Задача 3: Напишите программу, которая перевернёт
//одномерный массив (первый элемент станет
//последним, второй – предпоследним и т.д.)

//[1 3 5 6 7 8] => [8 7 6 5 3 1]

int [] myArray = new int [new Random().Next(1,10)];

myArray = fillArray(myArray);
printArray(myArray);
reverseArray(myArray);
Console.WriteLine();
printArray(myArray);


int [] reverseArray (int [] myArray)
{
    int temp = 0;
    for(int i = 0; i < myArray.Length/2; i++)
    {
        temp = myArray[i];
        myArray[i] = myArray[myArray.Length-i-1];
        myArray[myArray.Length-i-1] = temp;
    }
    return myArray;
}

int [] fillArray (int [] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(0,10);
    }
    return myArray;
} 

void printArray (int [] myArray)
{
    foreach (int item in myArray)
    {
        Console.Write(item + " ");
    }
}