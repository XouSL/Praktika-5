//Задание 1
void sum(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
sum(12, 12);

//Задание 2

void radiys(int x) => Console.WriteLine($"{3.14} * {x} * {x} = {3.14 * x * x}");
radiys(2);

//Задание 3

void stroka(string str) => Console.WriteLine($"{"Длина строки: "}= {str.Length}");
stroka("Здравствуйте!");

//Задание 4

int[] nums = new int[5];
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"Введите {i + 1} Элемент массива:");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
int search(int[] nums)
{
    int big = nums[0];
    for (int i = 0; i < nums.Length; i++)
    {
        if (big < nums[i])
        {
            big = nums[i];
        }
    }
    Console.Write("Cамое большое число в массиве: ");
    return big;
}
int message = search(nums);
Console.Write(message);

//Задание 5

void factorial(int num)
{
    int f = 0;
    for (int i = 1; i <= num; i++)
    {
        f = f + i;
    }
    Console.Write($"Факториал числа {num} = {f} ");
}
Console.Write("\nВведите число: ");
int num = Convert.ToInt32(Console.ReadLine());
factorial(num);

//Задание 6

string palindrome(string str)
{
    int i = 0;
    int j = str.Length - 1;
    bool pal = true;
    for (i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            str.Remove(i);
        }
    }
    while ((i < str.Length - 1) && (j > 0))
    {
        i++;
        j--;
        if (str[i] != str[j])
        {
            pal = false;
            break;
        }
    }
    if (pal == true)
    {
        return "строка является палиндромом ";
    }
    else
    {
        return "строка не является палиндромом ";
    }
}
Console.Write("\nВведите строку: ");
string str = Console.ReadLine();
string message2 = palindrome(str); 
Console.Write(message2);

//Задиние 7

int[] nums1 = new int[3] { 1, 2, 3 };
int[] nums2 = new int[3] { 4, 5, 6 };
void mass2(int[] nums1, int[] nums2)
{
    int a = nums1.Length + nums2.Length;
    int[] newnums = new int[a];
    for (int i = 0; i < a; i++)
    {
        if (i < nums1.Length)
        {
            newnums[i] = nums1[i];
        }
        else
        {
            newnums[i] = nums2[i - nums1.Length];
        }
    }
    Console.Write("\nНовый массив: ");
    for (int i = 0; i < a; i++)
    {
        {
            Console.Write($"{newnums[i]} ");
        }
    }
}
mass2(nums1, nums2);

//Задание 8

bool Prost(int num3)
{
    bool pr = true;
    for (int i = 1; i < num3 + 1; i++)
    {
        if ((num3 != i) && (i != 1))
        {
            if (num3 % i == 0)
            {
                pr = false;

            }
        }
    }
    Console.Write("Число простое: ");
    return pr;
}
Console.Write("\nВведите число:");
int num3= Convert.ToInt32(Console.ReadLine());

bool message3 = Prost(num3);  
Console.Write(message3);

//Задание 9

String Reverse(string str1)
{
    char[] nstr = str1.ToCharArray();
    Array.Reverse(nstr);
    return new string(nstr);
}
Console.Write("\nВведите строку: ");
string str1 = Console.ReadLine();
string message1 = Reverse(str1);  
Console.Write(message1);

//Задание 10

void ArraysSum()
{
    {
        int[,] arr = { { 6, 8, 4 }, { 7, 6, 7 }, { 1, 5, 4 } };
        int sum = SumArray(arr);
        Console.WriteLine($"\nСумма всех чисел матрицы: {sum} ");
    }

    int SumArray(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }
}
ArraysSum();