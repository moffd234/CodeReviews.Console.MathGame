using CSharpCasino.Utils;

namespace MathGame;

public class HistoryManager {
  private List<Game> Games { get; } = [];
  private readonly IoConsole _console = new();

  public void AppendGame(Game game) {
    Games.Add(game);
  }

  public void PrintHistory() {
    foreach (Game game in Games) {
      _console.PrintColored(AnsiColor.Auto, "//////////////////////////////\n" +
                                            $"{game._timestamp}\nScore: {game._score}\n" +
                                            "//////////////////////////////\n");
    }
  }

}
