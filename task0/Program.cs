// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
// алгоритма. 

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arr1 = { "hello", "its", "final", "task", "for", "1st", "quarter", "=)" };
string[] newarray = new string[arr1.Length];

int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3)
    {
        newarray[j] = arr1[i];
        j++;
    }
}

string[] arr2 = new string[j];
for (int k = 0; k < j; k++)
{
    arr2[k] = newarray[k];
}


void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ]");
}

PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
