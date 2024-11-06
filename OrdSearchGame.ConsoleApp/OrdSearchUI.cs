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
        
        selectedWords = ["apple"];
        var gridPos = grid.ChoosingWordPosition(selectedWords);

        selectedCharacterList[4, 4] = 'A';

        foreach(var x in gridPos)
        {
            System.Console.WriteLine($"{x.Item1}, {x.Item2}, {x.Item3}");
        }
        // selectedCharacterList[3,1] = 'B';
        // selectedCharacterList[3,2] = 'E';
        // selectedCharacterList[3,3] = 'A';
        // selectedCharacterList[3,4] = 'R';
        

        grid.PrintGridNet(selectedCharacterList);
        
    }
}