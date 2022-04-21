using System;

class Player
{
    public string name;
    public int gamesWon;
    public int gamesPlayed;

    public Player(string name, int gamesWon = 0, int gamesPlayed = 0)
    {
        this.name = name;
        this.gamesWon = gamesWon;
        this.gamesPlayed = gamesPlayed;
    }

    public string GetPlayerAnswer()
    {
        Console.Write($"{this.name}: ");
        return Console.ReadLine();
    }

    public void ShowVictoryMessage()
    {
        Console.WriteLine($"Congratulations {this.name}!");
        this.gamesWon++;
        ShowScore();
    }

    public void ShowDefeatMessage()
    {
        Console.WriteLine($"Better luck next time, {this.name} :(");
        ShowScore();
    }

    public void ShowTieMessage(Player opponent)
    {
        Console.WriteLine($"Well Played {opponent.name}");
        ShowScore();
    }

    public void ShowScore()
    {
        this.gamesPlayed++;
        Console.WriteLine($"{this.name}'s Win Percentage: {(this.gamesWon / (float) this.gamesPlayed) * 100}%");
    }
}