namespace OrdSearchGame.ConsoleApp;
using OrdSearchGame.Core;

public class Program
{
    public static void Main(string[] args)
    {
        Word word = new Word();

        var wordList = word.ReadWordsFromFile();
        var selectedWords = word.GenerateRandomWords(wordList);

        // foreach(var words in selectedWords)
        // {
        //     System.Console.WriteLine(words);
        // }

        Grid grid = new Grid();

        // grid.PrintGridNet();

        var characterList = grid.ReadCharacterFromFile();
        var selectedCharacters = grid.GenerateRandomCharacter(characterList);

        foreach(var c in selectedCharacters)
        {
            System.Console.WriteLine(c);
        }
    }
}