using System.Text;

namespace OrdSearchGame.Core;

public class Word
{
    // Funktion för att läsa in orden från WordsToSelectFrom.txt
    public List<string> ReadWordsFromFile()
    {
        string path = @"WordsToSelectFrom.txt";
        string readText = File.ReadAllText(path, Encoding.UTF8);
        List<string> wordList = readText.Split("\n").ToList();

        return wordList;
    }

    // Funktion för att genera 5 random ord från wordList
    public List<string> GenerateRandomWords(List<string> wordList)
    {
        Random random = new Random();
        List<string> selectedWordList = new List<string>{};

        for(int i = 0; i < 5; i++)
        {
            var wordIndex = random.Next(wordList.Count);
            var selectedWord = wordList[wordIndex];

            selectedWordList.Add(selectedWord);
        } 
        return selectedWordList;
    }

}


