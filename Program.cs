using System.Text;
using System.Linq;
class Program
{
    static void Main()
    {
        bool boolean = true;
        char symbol = 's';
        int integer = 10;
        float num = 3.2f;
        double num2 = 5.6;
        byte byte1 = 1;
        sbyte byte2 = 2;
        short short1 = -32000;
        long long1 = 100000;
        ulong ulong1 = 1204;
        decimal money = 99.99m;
        object obj = "ranval";
        Console.WriteLine($"bool: {boolean}, char: {symbol}, int: {integer}, float: {num}, double: {num2}, byte: {byte1}, sbyte: {byte2},short: {short1}, long: {long1}, ulong: {ulong1}" +
            $" decimal: {money}, object: {obj}");
        // приведение 
        double priv1 = integer;
        float priv2 = short1;
        int priv3 = byte1;
        short priv4 = byte1;
        long priv5 = byte2;

        int priv6 = (int)num;
        byte priv7 = (byte)num2;
        short priv8 = (short)num2;
        long priv9 = (long)num2;
        float priv10 = (float)long1;
        //распаковка упаковка
        int numb = 40;
        object box = numb;
        int numbr = (int)box;
        //неявно тип переменная
        var stroke = "nnjfsj";
        var nuum = 30;
        Console.WriteLine($"Неявно типизированная переменная: {stroke},{nuum}");
        //nullable
        int? age = null;
        if (age.HasValue)
        {
            Console.WriteLine($"{age.Value}");
        }
        else
        {
            Console.WriteLine($"Данные не записаны");
        }
        //ошибка типизации:
        //var myvar = 10;
        //myvar = "Privet";


        //строки
        //сравнение строковых литералов
        string str1 = "C:\\Program Files\\MyGame";
        string str2 = @"C:\Program Files\MyGame";
        string str3 = """C:\Program Files\MyGame""";
        bool compare12 = (str1 == str2);
        bool compare23 = (str2 == str3);
        Console.WriteLine($"Равны ли str1 и str2? {compare12}");
        Console.WriteLine($"Равны ли str2 и str3? {compare23}");
        //операции с стринг
        string strok1 = "Hello";
        string strok2 = "World";
        Console.WriteLine(String.Concat(strok1, strok2));
        string copy = strok1; //копирование
        string result = strok1.Substring(0, 3);
        Console.WriteLine($"Подстрока {result} в строке {strok1}");
        string sentence = "Я учу язык СиШарп";
        string[] words = sentence.Split(' ');
        Console.WriteLine($"1 - {words[0]}, 2 - {words[1]}, 3 - {words[2]}, 4 - {words[3]}"); //разбиение
        string ins = "Мне лет";
        Console.WriteLine("Вставка в 4 позицию: " + ins.Insert(4, "18")); //вставка
        string badText = "Привет, дорогой друг!"; //удаление подстроки
        string cleanText = badText.Remove(8, 8);
        //пустые и null строки
        string prim1 = "ABCD";
        string prim2 = null;
        var res1 = string.IsNullOrEmpty(prim1);
        var res2 = string.IsNullOrEmpty(prim2);
        Console.WriteLine($"{res1} , {res2}");
        if (string.IsNullOrEmpty(prim1))
        {
            Console.WriteLine("Строка null или пустая");
        }
        else
        {
            Console.WriteLine(string.Concat(prim1, prim2));
        }
        //StringBuilder
        StringBuilder sb = new StringBuilder("Привет");
        sb.Append("ик");
        sb.Insert(0, "А");
        Console.WriteLine(sb);
        sb.Remove(0, 1);
        sb.Remove(6, 2);
        Console.WriteLine(sb);
        //целый двумерный массив 
        int[,] matrix = {
    {1,2,3},
    {4,5,6}
    };
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.Write("\n");
        }
        //одномерный строk
        string[] sentences = { "Alfred", "Nikita", "Sergey" };
        Console.WriteLine($"Длина массива: {sentences.Length}");
        for (int i = 0; i < sentences.Length; i++)
        {
            Console.Write(sentences[i] + " ");
        }
        Console.WriteLine($"\nВведите , на какое место вставить слово(от 0 до {sentences.Length - 1}): ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите слово: ");
        string word = Console.ReadLine();
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i] == sentences[index])
            {
                sentences[index] = word; break;
            }
        }
        for (int i = 0; i < sentences.Length; i++)
        {
            Console.Write(sentences[i] + " ");
        }
        //зубчатый массив
        double[][] jaggedArray = new double[3][];
        jaggedArray[0] = new double[2];
        jaggedArray[1] = new double[3];
        jaggedArray[2] = new double[4];
        Console.WriteLine("Введите вещественные числа для массива:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Элемент [{i}][{j}]: ");
                jaggedArray[i][j] = double.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nВаш ступенчатый массив:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
        //неявная типизация для массива и строки
        var lines = new string[10];
        var line = "GAy";
        // кортежи
        var user = (17, "Nikita", "Z", "Zelenyak", 291300320);
        var user1 = (18, "Nikita", "Z", "Zelenyak", 291300320);
        Console.WriteLine(user);
        Console.Write($"1 - {user.Item1}, 3 - {user.Item3},5 - {user.Item5}"); Console.WriteLine();
        var (age1, FirstName, FirstLetter, LastName, CtBalls) = user;
        //распаковка
        Console.WriteLine($"Распаковка: {age1},{FirstName},{FirstLetter}, {LastName}, {CtBalls}");
        var (_, FirstName1, _, _, _) = user;
        Console.WriteLine($"{FirstName1}");
        //сравнение
        Console.WriteLine(user == user1);
        //функция:

        var GetCort = (int[] numbers, string stroke) =>
        {
            int max = numbers.Max();
            int min = numbers.Min();
            int summ = numbers.Sum();
            char FirstChar = string.IsNullOrEmpty(stroke) ? ' ' : stroke[0];
            return (Max: max, Min: min, Sum: summ, FirstLetter: FirstChar);
        };
        int[] myNumbers = { 5, 2, 8, 1, 9 };
        string myString = "Alfred";
        var result1 = GetCort(myNumbers, myString);
        Console.WriteLine($"Максимум: {result1.Max}");
        Console.WriteLine($"Минимум: {result1.Min}");
        Console.WriteLine($"Сумма: {result1.Sum}");
        Console.WriteLine($"Первая буква строки: {result1.FirstLetter}");
        //функции с checked и unchecked
        void CheckedBlock()
        {
            checked
            {
                int max = int.MaxValue;
                Console.WriteLine($"Внутри checked: {max}");
                int result = max + 1;
                Console.WriteLine($"После добавления 1: {result}");
            }
        }
        void UncheckedBlock()
        {
            unchecked
            {
                int max = int.MaxValue;
                Console.WriteLine($"Внутри unchecked: {max}");
                int result = max + 1;
                Console.WriteLine($"После добавления 1: {result}");
            }
        }
        CheckedBlock();
        UncheckedBlock();
    }
}