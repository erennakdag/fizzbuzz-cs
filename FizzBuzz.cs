class FizzBuzz 
{
    private Player player1;
    private Player player2;

    public FizzBuzz(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    public void Play(int rounds)
    {
        Player[] players = new Player[] {this.player1, this.player2};

        // Get the true answers
        string[] answers = Generate(rounds);

        for (int i = 0; i < rounds; i++)
        {
            Player currPlayer = players[i % 2];
            string playerAnswer = currPlayer.GetPlayerAnswer();
            
            if (playerAnswer != answers[i])
            {
                currPlayer.ShowDefeatMessage();

                Player otherPlayer = players[i % 2 == 0 ? 1 : 0];
                otherPlayer.ShowVictoryMessage();

                return;
            }

        }
        
        // Game was not abruptly finished, we have a tie!
        players[0].ShowTieMessage(players[1]);
        players[1].ShowTieMessage(players[0]);

    }

    public static string[] Generate(int number)
    {

        // The classic FizzBuzz alghorithm

        if (number < 1)
        {
            throw new System.Exception("Enter a positive number");
        }
        string[] result = new string[number];
        for (int i = 1; i <= number; i++)
        {
            string curr = "";
            if (i % 3 == 0)
            {
                curr += "Fizz";
            }
            if (i % 5 == 0)
            {
                curr += "Buzz";
            }
            if (i % 3 != 0 && i % 5 != 0) {
                curr += i;
            }
            result[i - 1] = curr;
        }
        return result;
    }   
}