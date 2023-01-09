// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNums(int num)
 {
    Console.Write(num + ", ");
    if(num > 1) ShowNums(num - 1);
    
 }

Console.Write("Enter natural numbers: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int a, int b)
{
    if(a > b) return Sum(a - 1, b) + b;
    else if(a < b) return Sum(a + 1, b) + a;
    else return b;
}

Console.Write(" Ведите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write(" Ведите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.Write(Sum(numM, numN));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int A(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m != 0 && n == 0) return A(m - 1, 1);
    else if(m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return 0;
}

Console.Write(" Ведите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Ведите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(A(m,n));
*/