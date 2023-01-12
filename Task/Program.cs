// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string inputText = Console.ReadLine()!;
string[] stringArray = inputText.Split(' ');
Console.WriteLine();

int MaxWordLength = 3;


// Метод вывода массива в терминал.
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.Write("]");
}
// Метод сокращения массива.
string[] GetShortWordsArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MaxWordLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}
// Метод вывода решения задачи в терминал.
void PrintTask(string[] array)
{
    Console.WriteLine("Заполненный массив и новый массив выглядит следующим образом:\n");
    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    Console.Write(" -> ");
    PrintArray(shortArray);
    Console.WriteLine();
}

PrintTask(stringArray);
Console.WriteLine();

