
// Ввод чисел
Console.WriteLine("Введите числа, разделенные пробелами:");
string strNumbers = Console.ReadLine();

string[] splitedNumbers = strNumbers.Split(' ');

Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

// добавление в словарь данных, где ключ это число, а значение - частота этих чисел в массиве 
foreach (string item in splitedNumbers)
{
    int currentNumber = int.Parse(item);

    if (keyValuePairs.ContainsKey(currentNumber))
    {
        keyValuePairs[currentNumber]++;
    }
    else
    {
        keyValuePairs[currentNumber] = 1;
    }

}

// Находим максимальную частоту когда встречается число в массиве 
int maxValueInKeyValuePair = 0;

foreach (var item in keyValuePairs.Values)
{
    if (item > maxValueInKeyValuePair)
    {
        maxValueInKeyValuePair = item;
    }
}


// находим числа которые имеют максимальную частоту и добавляем в список
List<int> maxFrequentluNums = new List<int>();

foreach (var item in keyValuePairs.Keys)
{
    if (keyValuePairs[item] == maxValueInKeyValuePair)
    {
        maxFrequentluNums.Add(item);
    }
}

// Сортируем и выводим наиболее часто встречающиеся числа в консоль
maxFrequentluNums.Sort();

foreach (var item in maxFrequentluNums)
{
    Console.Write($"{item} ");
}

