namespace MathGame;

public class Quiz {
  private int _score;
  private readonly IoConsole _console = new();

  private void HandleQuestion(Question question) {
    Console.WriteLine(question.Problem);
    int answer = _console.GetIntInput("Your answer: ");

    if (question.Answer == answer) {
      _score++;
    }
  }

  public Game PlayGame() {
    string op = _console.GetValidInput("Enter a operator: + - * /", ["+", "-", "*", "/"]);

    Question[] questions = op switch {
      "+" => QuestionManager.AdditionQuestions,
      "-" => QuestionManager.SubtractionQuestions,
      "*" => QuestionManager.MultiplicationQuestions,
      "/" => QuestionManager.DivisionQuestions,
      _ => []
    };

    foreach (Question question in questions) {
      HandleQuestion(question);
    }

    Console.WriteLine($"Congrats your score was {_score}");
    return new Game(_score);
  }
}
