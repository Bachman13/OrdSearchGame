namespace OrdSearchGame.ConsoleApp;
using OrdSearchGame.Core;

public class Program
{
    public static void Main(string[] args)
    {
        Word word = new Word();
        Grid grid = new Grid();

        var wordList = word.ReadWordsFromFile();
        var selectedWords = word.GenerateRandomWords(wordList);

        var characterList = grid.ReadCharacterFromFile();
        var selectedCharacters = grid.GenerateRandomCharacter(characterList);

        List<string> characters = grid.ReadCharacterFromFile();
        char[,] selectedCharacterList = grid.GenerateRandomCharacter(characters);

        // selectedWords = ["OCEAN"];
        var gridPos = grid.ChoosingWordPosition(selectedWords);

        // startRow & startCol



        // Måste loopa ordet "apple" -> loop på 5 gånger.
        // Varje gång ska bokstaven skrivas ut och sedan ska ++ så att vi får nästa bokstav?

        // selectedCharacterList[4, 4] = 'A';
        System.Console.WriteLine("Words to find in the grid: ");
        foreach (var x in gridPos)
        {
            System.Console.WriteLine(x.Item1);
            // System.Console.WriteLine($"{x.Item1}, {x.Item2}, {x.Item3}");
            grid.PlacingWordOnStart(selectedCharacterList, x.Item1, x.Item2, x.Item3);
        }
        System.Console.WriteLine();

        grid.PrintGridNet(selectedCharacterList);
        System.Console.WriteLine();

    }
}