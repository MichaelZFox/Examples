// Рекурсия это функция, которая вызывает сама себя
// 
// Что же есть рекурсия
// 
// Факториал
// 5! = 5*4*3*2*1
//      5*4!
//        4*3!
//          3*2!
//            2*1!


double Factorial(double n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (double i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}"); 
}