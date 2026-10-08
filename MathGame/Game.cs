namespace MathGame;

public class Game(int score) {
  public int _score { get; } = score;
  public DateTime _timestamp { get; } = DateTime.Now;
}
