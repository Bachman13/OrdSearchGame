using System.Text;

public class Grid
{
    public List<string> ReadCharacterFromFile()
    {
        string path = @"CharactersToSelectFrom.txt";
        string readText = File.ReadAllText(path, Encoding.UTF8);
        List<string> characterList = readText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();

        return characterList;
    }

    public char[,] GenerateRandomCharacter(List<string> characterList)
    {
        Random random = new Random();
        char[,] selectedCharacterList = new char[10, 10];

        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                var characterIndex = random.Next(characterList.Count);
                var character = characterList[characterIndex][0];

                selectedCharacterList[i, j] = character;
            }
        }
        return selectedCharacterList;
    }


    public List<(string, int, int)> ChoosingWordPosition(List<string> selectedWordList)
    {
        List<(string, int, int)> wordPositions = new List<(string, int, int)>();
        Random random = new Random();

        foreach(var word in selectedWordList)
        {
            bool wordPlacedCorrectly = false;
            int startRow = 0; 
            int startCol = 0;

            while(!wordPlacedCorrectly)
            {
                startRow = random.Next(0, 10);
                startCol = random.Next(0, 10);

                if(startCol + word.Length <= 10)
                {
                    wordPlacedCorrectly = true;
                }
            }
            wordPositions.Add((word, startCol, startRow));
        }
        return wordPositions;
    }
    
    // Funktionen ska välja ut en startposition för ordet i rutnätet.
    // Positionen måste vara inom 10, 10 och ordet får inte gå utanför på sidan.
    // Alltså kan inte ett ord på 5 bokstäver börja på col 6 då det blir 11 och är utanför. 


    public void PrintGridNet(char[,] selectedCharacterList)
    {
        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                System.Console.Write(selectedCharacterList[i, j] + "  ");
                index++;
            }
            System.Console.WriteLine();
        }
    }

}