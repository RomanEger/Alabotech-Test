using Test.Console;

Console.WriteLine("Введите массив через пробел:");

var r = Console.ReadLine();

var strArr = r.Split(' ');

var list = new List<int>();

foreach (var item in strArr)
{
    if(int.TryParse(item, out int x))
        list.Add(x);
}

try
{
    int steps = Solution.GetMinSteps(list.ToArray());
    Console.WriteLine($"Потребовалось {steps} шага(ов)");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
