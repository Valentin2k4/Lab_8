/*  // N1.6

  char[] vowel = new[] { 'а', 'о', 'у', 'э', 'ы', 'я', 'ё', 'ю', 'е', 'и' };
string words = "компьютер мама человек студент слабый";
string[] word = words.Split(new char[] { ' ' }); 
  
  Console.WriteLine("Количество слогов в словах:");
foreach (string w in word)
{
    int countOfSyllables = 0;
    for (int i = 0; i < w.Length; i++)
        if (vowel.Contains(w[i]))
        {
            countOfSyllables++;
        }
    
    Console.WriteLine($"В слове {w}: {countOfSyllables};");
}
Console.WriteLine("");
Console.ReadKey();
*/


/*  //N 1.11

string surnames = "Иванов,Петров,Сидоров,Козлов,Абрамов";
string[] ListOfSurname = surnames.Split(new char[] {','}).ToArray();
Array.Sort(ListOfSurname);
foreach (string surname in ListOfSurname) {
    Console.Write($"{surname} ");
}
Console.ReadKey();
*/


  //N 1.11
using System;
class Program
{
    static void Main()
    {
        string surnames = "Иванов Яковлев Рудницкий Адигамов Беляев Адигамова Песков Рудницкая Беляева";
        Console.WriteLine(surnames);
        Console.WriteLine();

        string[] surname = surnames.Split(' ');
        Console.WriteLine("Студенты до сортировки:");

        for (int i = 0; i < surname.Length; i++) Console.WriteLine("{0}. {1}", i + 1, surname[i]);
        
        for (int i = 0; i < surname.Length; i++)
        {
            for (int j = i + 1; j < surname.Length; j++)
            {
                if (needToReOrder(surname[i], surname[j]))
                {
                    (surname[i], surname[j]) = (surname[j], surname[i]);
                }
            }
        }

        Console.WriteLine();
            Console.WriteLine("Студенты после сортировки:");
            for (int i = 0; i < surname.Length; i++) Console.WriteLine("{0}. {1}", i + 1, surname[i]);
            Console.ReadKey();

    }

    static bool needToReOrder(string first_word, string second_word)
        {
            for (int i = 0; i < (first_word.Length > second_word.Length ? second_word.Length : first_word.Length); i++)
            {
                if (first_word.ToCharArray()[i] < second_word.ToCharArray()[i]) return false;
                if (first_word.ToCharArray()[i] > second_word.ToCharArray()[i]) return true;
            }
            return false;
        }
}



