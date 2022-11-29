/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

double inputUserData(string userMessage)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(userMessage);
    double userData = Convert.ToDouble(Console.ReadLine());
    return userData;
} 

bool isTriangleExist(double side1, double side2, double side3)
{
    bool isSide1Smaller = side1 < side2 + side3;
    bool isSide2Smaller = side2 < side1 + side3;
    bool isSide3Smaller = side3 < side2 + side1;
    bool isExist = (isSide1Smaller && isSide2Smaller && isSide3Smaller);
    return isExist;
}

void showInfoAboutTreangle(double side1, double side2, double side3, bool TriangleExist)
{
    string existString = "не существует";
    if (TriangleExist)
    {
        existString = "существует";
    }
    Console.WriteLine($"треугольник со сторонами {side1}, {side2}, {side3} {existString}");
}
double side1 = inputUserData("Введите длину первой стороны треугольника");
double side2 = inputUserData("Введите длину второй стороны треугольника");
double side3 = inputUserData("Введите длину третьей стороны треугольника");

bool TriangleExist = isTriangleExist(side1, side2, side3);
showInfoAboutTreangle(side1, side2, side3, TriangleExist);