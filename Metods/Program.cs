// Вид 1. Методы которые ничго не возвращают и ничего не принмают
void Method1()
{
    Console.WriteLine("Автор...");
}

// Как вызываются методы
// просто вводим его имя
Method1();



// Вид 2. Методы которые, ничего не возвращают но могут принимать 
// в себя различные значения.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
// Если методы принимают несколько аргументов 
// мы можем указать явно к какому аргумент какое значение указать
Method2(msg: "Текст сообщения");

//пример 2
void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_1("текст", 4); //Вызываем текст и указываем кол-во раз.(потому что count в примере)
//именнованные аргументы не обязательно использовать по порядку
Method2_1(count: 4, msg: "новый текст");

// Вид 3. Методы которые ничего принимают, но что-то возвращают
int Method3() //Обязательно указываем тип данных, которые ожидаем получить
{
    return DataTime.Now.Year; //обязательное использование оператора return
}

int year = Method3(); //вызываем метод и через индетификатор переменной и оператор присваивания положить нужное значение
Console.WriteLine(data); // используем эту переменную для вывода значния, которое вернул метод

// Вид 4. Методы, которые что-то принимают и что-то возвращают;
string Method4(int count, string text) //string - то, что возвращает. int, string - то, что принимает
{
    int i = 0;
    string result = String.Empty; //кладем значение в result - этим значением является пустая стркоа ""; Более правильно будет написать String.Empty

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

// Цикл for

string Method4(int count, string text) //string - то, что возвращает. int, string - то, что принимает
{

    string result = String.Empty; //кладем значение в result - этим значением является пустая стркоа ""; Более правильно будет написать String.Empty
    for (int i = 0; i < count; i++) //пишем for, потом идет инициализация счетчика.Далее  проверка условия. И далее инкримент.
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

//Цикл в цикле
string res = Method4(10, "z");

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}

// Работа с текстом 
// Дан тескт. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить на большие "К", 
// а большие "С" заменить маленькими "с". 

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали меня вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноричивы. Вы двдите мне чаю?";


// string s = "qwerty"
               012345
// s[3] //r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0;i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к','К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С','с');
Console.WriteLine(newText);
Console.WriteLine();