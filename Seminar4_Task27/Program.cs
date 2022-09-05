// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В данном числе сумма цифр = " + GetSumNum(num));

int GetSumNum (int num)
{
    int sum = 0;
    int count = Convert.ToString(num).Length;
    int num1 = 0;
    for (int i=0; i<count; i++)
    {
        num1=num-(num%10);
        sum=sum+(num-num1);
        num=num/10;
    }
    return sum;
}