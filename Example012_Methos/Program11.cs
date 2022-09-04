// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

// Вид 2_1
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg:"Текс",count: 4);

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res); 

// Вид 4_1 с циклом for
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;     
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res); 

// For in for 
for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= lenght; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}


// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими буквами "К",
// а большие "С" заменить меленькими "с".

// Ясна ли задача ?

string text = "- Я думаю, - сказал князь, улыбаясь, что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю ?";

// string s = "qwerty"
//             012345
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result  = String.Empty;

    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

     return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'k', 'K');
Console.WriteLine(newText);


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int = 1; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}  

void SelectionSort(int[] array);
{
    for(int = 0; i < array.Lenght - 1; i++ )
    {
        int minPosition = i;

        for(j = i +1; j < array.Lenght; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);   