// Задача 2: Задайте массив заполненный случайными
//трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в
//массиве.

// [344 452 341 125] => 2

int [] myArray = new int [new Random().Next(1,10)];
myArray = fillArray(myArray);
printArray(myArray);
int numOfEven = howManyEven(myArray);
Console.WriteLine(" => " + numOfEven);

int [] fillArray (int [] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100,1000);
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

int howManyEven (int [] myArray)
{
    int count = 0;
    foreach (int item in myArray)
    {
        if(item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
