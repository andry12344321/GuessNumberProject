public class GuessGame
{
    private int secretNumber;

    public GuessGame(int min = 1, int max = 100)
    {
        Random random = new Random();
        secretNumber = random.Next(min, max + 1);
    }

    public GuessGame(int fixedNumber)
    {
        secretNumber = fixedNumber;
    }

    public string CheckGuess(int guess)
    {
        if (guess < secretNumber) return "Больше";
        if (guess > secretNumber) return "Меньше";
        return "Угадал";
    }
}