namespace OrdSearchGame.ConsoleApp;
using OrdSearchGame.Core;

public class Program
{
    public static void Main(string[] args)
    {
        Word word = new Word();

        var wordList = word.ReadWordsFromFile();
        var selectedWords = word.GenerateRandomWords(wordList);

        foreach(var words in selectedWords)
        {
            System.Console.WriteLine(words);
        }
    }
}