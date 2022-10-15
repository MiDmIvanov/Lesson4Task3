// Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.
string A = "";
Console.WriteLine("Введите массив до 8 символов через запятую:");
A = Console.ReadLine()!;
Array(A);
void Array(string _A)
{
    string[] arr = _A.Split(',');
    int N = arr.Length;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"[{arr[i]}], ");
    }
}