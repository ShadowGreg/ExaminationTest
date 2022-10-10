var lenght = int.Parse(Prompt("Введите длину массива > "));
var stringArray = new string[lenght];
var outputArrayCount = 0;

//Заполнение с выводом передаваемого сообщения
string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? "0";
}

// Вывод массива
void PrintArray(string[] inputArray)
{
    Console.WriteLine("Итоговый массив:");
    foreach (var item in inputArray)
    {
        Console.Write($"'{item}' ");
    }
}

//Заполнение массива
void inputItemsArray(string[] inputArray)
{
    for (var i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] = Prompt($"Введите {i + 1} строку > ");
    }
}

// Подсчет количества элементов меньше либо равных 3 символам
int CountItems(string[] inArray)
{
    return inArray.Count(items => items.Length <= 3);
}


//само тело программы
inputItemsArray(stringArray);
// Создание ответного массива 
var outputArray = new string[CountItems(stringArray)];
// Заполняем ответный массив
foreach (var t in stringArray)
{
    if (t.Length <= 3)
    {
        outputArray[outputArrayCount] = t;
        outputArrayCount++;
    }
}

//Печатаем итоговый массив
PrintArray(outputArray);