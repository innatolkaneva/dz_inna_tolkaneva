# Задача
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

# Решение

Функция CreateArrayStr создает массив из данных пользователя
```
string [] CreateArrayStr(int len)
{  string [] listStr = new string[len];
    for (int i = 0; i < len; i++)
{
    listStr[i] = Console.ReadLine();
}
return listStr;
}

```
Функция PrintArray печатает массив строк
```
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

```
Функция CountCharString считает количество символов в слове
```
int CountCharString(string str)
{
  int counter = 0;
  foreach (char item in str)
  {
      counter ++;
    }
return counter;
}

```
Функция CountWords считает сколько слов имеют меньше 4 символов для определения размера нового массива строк
```
int CountWords(string[] listStr)
{  int counter2 = 0;
    foreach (string item in listStr)
    {
        if (CountCharString(item) <= 3)
        {
            counter2++;
        }
    }
    return counter2;
}

```
Функция CreateNewArrayStr формирует новый массив из строк меньше 4 символов
```
string [] CreateNewArrayStr(int len, string[] listStr)
{  string [] listNewStr = new string[len];
int i = 0;
     foreach (string item in listStr)

    {
        if (CountCharString(item) <= 3)
        {
            listNewStr[i] = item;
            i++;
        }
    }
return listNewStr;
}
```
Оснойной цикл программы
```
string [] listStr = CreateArrayStr(5);
PrintArray(listStr);
string[] newArrayString = CreateNewArrayStr(CountWords(listStr), listStr);
PrintArray(newArrayString);
```