// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При 
// решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.


string [] array = {"1234", "1567", "-2", "computer science", "1", " ", "111", "1111"};

void PrintArray(string[] array)
{
    Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine();
}

void NewArrayOfStrings(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<4)
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
NewArrayOfStrings(array);
