// Напишите программу, кот. задает массив из 8 эллементов и выводит их на экран
int [] array = new int[8];

void FillArray (int [] compilation)
{
    int lenght = compilation.Length;
    int index = 0;
    while (index<lenght)
    {
        compilation[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray (int [] compilation)
{
    int count = compilation.Length;
    int pos = 0;
    while (pos<count)
    {
        Console.WriteLine(compilation[pos]);
        pos++;
    }
}

FillArray(array);
PrintArray(array);