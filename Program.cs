

using System.Collections.Specialized;

string [] CreateArrayStr(int len)
{  string [] listStr = new string[len];
    for (int i = 0; i < len; i++)
{
    listStr[i] = Console.ReadLine();
}
return listStr;
}
string [] listStr = CreateArrayStr(5);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
PrintArray(listStr);
int CountCharString(string str)
{
  int counter = 0;
  foreach (char item in str)
  {
      counter ++;
    }
return counter;
}
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
string [] CreateNewArrayStr(int len)
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
string[] newArrayString = CreateNewArrayStr(CountWords(listStr));
PrintArray(newArrayString);