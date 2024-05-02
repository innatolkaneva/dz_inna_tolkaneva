

string[] CreateArrayStr(int len)
{
    string[] listStr = new string[len];
    for (int i = 0; i < len; i++)
    {
        listStr[i] = Console.ReadLine();
    }
    return listStr;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int CountCharString(string str)
{
    int counter = 0;
    foreach (char item in str)
    {
        counter++;
    }
    return counter;
}
int CountWords(string[] listStr)
{
    int counter2 = 0;
    foreach (string item in listStr)
    {
        if (CountCharString(item) <= 3)
        {
            counter2++;
        }
    }
    return counter2;
}
string[] CreateNewArrayStr(int len, string[] listStr)
{
    string[] listNewStr = new string[len];
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
string[] listStr = CreateArrayStr(5);
PrintArray(listStr);
string[] newArrayString = CreateNewArrayStr(CountWords(listStr), listStr);
PrintArray(newArrayString);