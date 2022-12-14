# Задание

Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которого
меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо зададать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

## Предлагаемое решение

1. На первом этапе для заполнения массива нам необходимо понимать его длину. Поэтому мы запрашиваем у пользователя
   желаемую длину массива.
   И за тем пошагово для каждого элемента пользователь с клавиатуры вводит значение элементов массива.

```csharp
   //Заполнение с выводом передаваемого сообщения
   string Prompt(string message)
   {
       Console.Write(message);
       return Console.ReadLine() ?? "0";
   }
   // создаём массив
      var lenght = int.Parse(Prompt("Введите длину массива > "));
   // Вывод массива
   void PrintArray(string[] inputArray)
   {
       Console.WriteLine("Итоговый массив:");
       foreach (var item in inputArray)
       {
           Console.Write($"'{item}' ");
       }
   }
```

2. Затем уже готовый массив нужно проверить на количество элементов, подходящих под условие длинны строки (менее ила
   равное трём).Мы проверяем количество элементов в цикле и сохраняем их количество во внешнюю переменную, которая,
   потом будет
   помогать нам объявить новый массив.

```csharp
   // Подсчет количества элементов меньше либо равных 3 символам
   int CountItems(string[] inArray)
   {
       return inArray.Count(items => items.Length <= 3);
   }
```

3. На следующем шаге мы как раз объявляем новый массив с тем количеством элементов, которое мы насчитали в исходном.

```csharp
   // Создание ответного массива 
   var outputArray = new string[CountItems(stringArray)];
```

5. И последние действие перед выводом готового массива, это перевести элементы, удовлетворяющие условию задачи в новый
   массив. Для этого мы используем снова конструкцию цикла, предварительно объявив счётчик, который будет нумеровать
   элементы нового заполняемого массива.
   И так перебором проверяя элементы существующего массива мы присваиваем новому элементы подходящие под условия задачи.

```csharp
// Заполняем ответный массив
   foreach (var t in stringArray)
   {
       if (t.Length <= 3)
       {
           outputArray[outputArrayCount] = t;
           outputArrayCount++;
       }
   }
```

6. Затем выводим массив и задача готова.

```csharp
   // Вывод массива
   void PrintArray(string[] inputArray)
   {
       Console.WriteLine("Итоговый массив:");
       foreach (var item in inputArray)
       {
           Console.Write($"'{item}' ");
       }
   }
   //Печатаем итоговый массив
   PrintArray(outputArray);
```
