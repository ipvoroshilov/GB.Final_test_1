// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// генерирует случайные значения типа string
string GenerateRandomString()
{
    string generatedText = string.Empty;
    int stringlen = new Random().Next(1, 10); //генерируем случайную длину переменной generatedText
    int randValue;
    char letter;
    for (int i = 0; i < stringlen; i++)
    {
        randValue = new Random().Next(0, 57);
        letter = Convert.ToChar(randValue + 65); //получаем символ Юникода(от A "U+0041" до z "U+007A") через сгенерированное случайное число
        generatedText = generatedText + letter;
    }
    return generatedText;
}

// заполняет простой массив
string[] FillSimpleStringArray(string[] array)
{
    //string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GenerateRandomString();
        //Console.Write($"{array[i]} \t");   
    }
    return array;
}

// печатает простой массив
void PrintSimpleStringArray(string[]simpleArray)
{
    for (int i = 0; i < simpleArray.Length; i++)
    {
        Console.Write($"{simpleArray[i]} \t");

    }
        Console.WriteLine();
}

// считает сколько элементов массива simpleArray имеет количество символов равное или меньшее значению howManySymbols
int CountThatIsThreeOrLessSymbols(string[] simpleArray, int howManySymbols)
{
    int count = 0;
    for (int i = 0; i < simpleArray.Length; i++)
    {
        if (simpleArray[i].Length <= howManySymbols) count++;
    }
    return count;
}

// заполняет массив
string[] FillrrayWithThreeOrLessSymbols(string[] initialArray, int howManySymbols, string[] newArray)
{

    int count = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length <= howManySymbols)
        {
            newArray[count] = initialArray[i];
            count++;
        }
        //Console.Write($"{array[i]} \t");   
    }
    return newArray;
}

try
{
    int howManySymbols = 3;
    string[] initialArray = new string[new Random().Next(5, 15)];
    Console.WriteLine("Массив, заполненный случайными символами разной длины:");
    PrintSimpleStringArray(FillSimpleStringArray(initialArray));

    string[] newArray = new string[CountThatIsThreeOrLessSymbols(initialArray,howManySymbols)];
    Console.WriteLine($"Массив, заполненный элементами длиной {howManySymbols} символов и менее");
    PrintSimpleStringArray(FillrrayWithThreeOrLessSymbols(initialArray, howManySymbols, newArray));
}
catch
{
    Console.WriteLine("error");
}
