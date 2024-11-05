using System.Text;

public class Grid
{
    public List<string> ReadCharacterFromFile()
    {
        string path = @"CharactersToSelectFrom.txt";
        string readText = File.ReadAllText(path, Encoding.UTF8);
        List<string> characterList = readText.Split("\n").ToList();

        return characterList;
    }

    public List<string> GenerateRandomCharacter(List<string> characterList)
    {
        Random random = new Random();
        List<string> selectedCharacterList = new List<string> { };

        for (int i = 0; i < 100; i++)
        {
            var characterIndex = random.Next(characterList.Count());
            var character = characterList[characterIndex];

            selectedCharacterList.Add(character);
        }
        return selectedCharacterList;
    }


    public void PrintGridNet(List<string> selectedCharacterList)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                System.Console.Write(selectedCharacterList[i]);
            }
            System.Console.WriteLine();
        }
    }
}