using Shouldly;

namespace OrdSearchGame.Tests;

public class UnitTest1
{
    [Fact]
    public void ReturnFiveWords()
    {
        Word word1 = new Word();
        List<string> wordList = new List<string>{"APPLE", "NIGHT", "STONE", "KING", "QUEEN"};

        var selectedWordList = word1.GenerateRandomWords(wordList);

        selectedWordList.Count.ShouldBe(5);
    }
}