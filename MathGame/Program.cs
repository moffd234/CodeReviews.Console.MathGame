using CSharpCasino.Utils;

namespace MathGame;

/*
 * Requirements

   - Must consist of asking the player what's the result of a math question (i.e. 9 x 9 = ?),
    collecting the input and adding a point in case of a correct answer.
   - A game needs to have at least 5 questions
   - Integer division only
   - Users should be presented with a menu to choose an operation
   - You should record previous games in a List
   - There should be an option in the menu for the user to visualize a history of previous games
   - Once the program is closed the results will be deleted
 */

class MathGame() {
  private static readonly IoConsole Console = new();
  private static readonly HistoryManager History = new();

  public static void Main() {
    Run();
  }

  private static void Run() {
    while (true) {
      string answer = Console.GetValidInput("Select an option:\nH: history\nP: play game\nE: exit",
        ["h", "p", "e"]);

      switch (answer) {
      case "h":
        History.PrintHistory();
        break;
      case "p":
        Quiz quiz = new();
        History.AppendGame(quiz.PlayGame());
        break;
      case "e":
        Environment.Exit(0);
        break;
      default:
        Console.PrintError("Invalid response");
        break;
      }
    }
  }
}
