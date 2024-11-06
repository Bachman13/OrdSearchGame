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

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
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
        List<int> upptagnaRows = new List<int>();

        foreach (var word in selectedWordList)
        {
            bool wordPlacedCorrectly = false;
            int startRow = 0;
            int startCol = 0;

            while (!wordPlacedCorrectly)
            {
                startRow = random.Next(0, 10);
                startCol = random.Next(0, 10);

                if(upptagnaRows.Contains(startRow))
                {
                    continue; 
                }

                if (startCol + word.Length < 10)
                {
                    upptagnaRows.Add(startRow);
                    wordPlacedCorrectly = true;
                }

            }
            wordPositions.Add((word, startRow, startCol));
        }
        return wordPositions;
    }

    // Funktionen ska välja ut en startposition för ordet i rutnätet.
    // Positionen måste vara inom 10, 10 och ordet får inte gå utanför på sidan.
    // Alltså kan inte ett ord på 5 bokstäver börja på col 6 då det blir 11 och är utanför. 

    // gridPos ger oss -> string, int, int
    // hur får vi värdena från gridPos in i denna funktionen?
    public void PlacingWordOnStart(char[,] grid, string word, int startRow, int startCol)
    {

        for (int i = 0; i < word.Length; i++) // word ska vara apple från selectedWords som används i gridPos
        {
            // printa ut bokstav på [0] -> index = sista bokstaven.

            grid[startRow, startCol + i] = word[i];

            // Hur ska vi få in startRow och startCol?
        }
    }


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