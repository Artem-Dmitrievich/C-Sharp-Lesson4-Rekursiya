// Задача
// В математике -вычисление факториала
// в программирование - рекурсия вычисления факториала

//Определяем ф-цию или метод, который принимает число, факториал которого нужно будет вычислить

double Factorial (int n)//int меняем на double для решение проблемы "переполнения"
{
    //1! = 1
    //0! = 1 
    if (n == 1) return 1;//если 1 то возвращаем единицу
    else return n * Factorial(n-1);//берем текущее значение и умножаем на факториал пред числа
    //else return - обязательно указываем, что должны возвращать значение
}
for (int i = 1; i < 40; i ++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
    //Console.WriteLine(Factorial(i));
    //отр.знач-я это ошибка-связанно с переполнением типа
}
//Console.WriteLine(Factorial(3));//1*2*3 = 6