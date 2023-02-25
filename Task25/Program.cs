// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int MetodDgr(int numberA, int degreeA)
{
    int result = 1;
    for (int i = 0; i < degreeA; i++)
    {
        result *= numberA;
    }
    return result;

}
bool CheckingForNegativity(int number)
{
    if (number<0)
    {
        System.Console.WriteLine("Ошибка: Степень не должна быть меньше 0");
        return false;
    }
    return true;
}
int number = ReadNumber("Введите число для возведения в степень: ");
int degree = ReadNumber("Введите степень, в которую необходимо возвести предыдущее число: ");
if (CheckingForNegativity(degree))
{
    Console.WriteLine($"{number} в {degree} степени = {MetodDgr(number, degree)}");
}