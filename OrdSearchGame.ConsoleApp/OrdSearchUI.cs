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


        var characterList = grid.ReadCharacterFromFile();
        var selectedCharacters = grid.GenerateRandomCharacter(characterList);
    

        // foreach(var c in selectedCharacters)
        // {
        //     System.Console.WriteLine(c);
        // }


        // var selectedCharacterList = grid.GenerateRandomCharacter(characterList);
        // grid.PrintGridNet(selectedCharacterList);

        // foreach(var x in selectedCharacterList)
        // {
        //     System.Console.WriteLine(x);
        // }

        List<string> characters = grid.ReadCharacterFromFile();
        char[,] selectedCharacterList = grid.GenerateRandomCharacter(characters);
        



        selectedCharacterList[3,1] = 'B';
        selectedCharacterList[3,2] = 'E';
        selectedCharacterList[3,3] = 'A';
        selectedCharacterList[3,4] = 'R';

        grid.PrintGridNet(selectedCharacterList);
        
    }
}