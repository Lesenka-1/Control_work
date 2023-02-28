/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами. */

string[] array = {"hello", "2", "world", "dj9hf", "404", "b7"};
PrintNewArray(array);

void PrintNewArray (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count ++;
    }

    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j ++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", newArray)}]");
}
