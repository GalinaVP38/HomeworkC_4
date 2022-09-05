// Напишите цикл, который принимает на вход два числа ( А и В)
// и возводит число А в натуральную степень В.

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А в степени В: "+GetExp(numA,numB));

double GetExp (int numA, int numB)
{
    double result=Math.Pow(numA,numB);
    return result; 
}
