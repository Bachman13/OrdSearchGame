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


    
    // Add secretWords to Grid


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