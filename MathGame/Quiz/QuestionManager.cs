namespace MathGame;

public static class QuestionManager {

  public static Question[] CreateQuestion(char op)
  {
    Question[] questions = new Question[5];
    int minRand = op is '-' or '+' ? 50 : 5;
    int maxRand = op is '-' or '+' ? 100 : 10;

    for(int i = 0; i < 5; i++) {
      int num1 = Random.Shared.Next(minRand, maxRand);
      int num2 = Random.Shared.Next(minRand, maxRand);

      if(op == '/')
      {
        questions[i] = new Question($"{num1 * num2} {op} {num1}", num2);
      }

      int answer = op switch {
        '+' => num1 + num2,
        '-' => num1 - num2,
        '*' => num1 * num2,
        _ => 0
      };

      questions[i] = new Question($"{num1} {op} {num2}", answer);
    }

    return questions;
  }
}


