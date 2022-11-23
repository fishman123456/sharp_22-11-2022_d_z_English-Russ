// Создать примитивный англо-русский словарь и русско-английский словарь
// содержащий пару слов - названий стран на русском и ангийском языках
// Пользователь должен выбирать направление перевода и запрашивать перевод


using System;

var langvR = new Dictionary<string, string>();//TODO англо-русский словарь

langvR.Add("Afghanistan", "Афганистан");
langvR.Add("Albania", "Албания");
langvR.Add("Algeria", "Алжир");
langvR.Add("Andorra", "Андорра");
langvR.Add("Angola", "Ангола");
langvR.Add("Argentina", "Аргентина");
langvR.Add("Armenia", "Армения");
langvR.Add("Australia", "Австралия");
langvR.Add("Austria", "Австрия");
langvR.Add("Azerbaijan", "Азербайджан");


var langvE = new Dictionary<string, string>();//TODO русско-английский словарь

langvE.Add("Афганистан", "Afghanistan");
langvE.Add("Албания", "Albania");
langvE.Add("Алжир", "Algeria");
langvE.Add("Андорра", "Andorra");
langvE.Add("Ангола", "Angola");
langvE.Add("Аргентина", "Argentina");
langvE.Add("Армения", "Armenia");
langvE.Add("Австралия", "Australia");
langvE.Add("Австрия", "Austria");
langvE.Add("Азербайджан", "Azerbaijan");
Console.WriteLine("Выберите перевод (NumPad) \n1) Русский-Английский\n2) Английский-Русский\n0) Выход\n");
var inkey = Console.ReadKey();

switch (inkey.Key)
{
    case ConsoleKey.NumPad1:
        Console.WriteLine();
        Console.WriteLine("Перевод Русский-Английский\n");
        Console.WriteLine($"Выберите из списка: ");
        foreach (var item in langvE)
        {
            Console.WriteLine(item.Key[1]);
        }
        
        break;
    case ConsoleKey.NumPad2:
        Console.WriteLine("Перевод Английский-Русский\n");
        foreach (var item in langvR)
        {
            Console.WriteLine(item.Key);
        }

        break;
    case ConsoleKey.NumPad0:
        Console.WriteLine("Выход из программы\n");
        break;
    default:
        Console.WriteLine("default");
        break;
}