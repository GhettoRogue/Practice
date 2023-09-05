var dictionary = new Dictionary<string, string>
{
    { "Монитор", "Устройство вывода" },
    { "Клавиатура", "Устройство ввода" }
};

Console.Write("Введите слово: ");
var word = Console.ReadLine()!;

Console.WriteLine(dictionary.TryGetValue(word, out var value));
if (dictionary.ContainsKey(word!))
{
    Console.WriteLine($"Значение слова {word}: {dictionary[value!]}");
}
else
{
    Console.WriteLine($"Слово {word} не содержится в словаре");
}

/*? $"Значение слова {word}: {value}"
: $"Слово {word} отсутствует в словаре");*/