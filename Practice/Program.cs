var dictionary = new Dictionary<string, string>
{
    { "Монитор", "Устройство вывода" },
    { "Клавиатура", "Устройство ввода" }
};

Console.Write("Введите слово: ");
var word = Console.ReadLine()!;

//Console.WriteLine(dictionary.TryGetValue(word, out var value));

Console.WriteLine(dictionary.ContainsKey(word!)
    ? $"Значение слова {word}: {dictionary[word!]}"
    : $"Слово {word} не содержится в словаре");
