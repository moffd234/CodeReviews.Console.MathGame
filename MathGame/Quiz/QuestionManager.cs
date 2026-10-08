namespace MathGame;

public static class QuestionManager {
  public static readonly Question[] AdditionQuestions = [
    new Question("1 + 1", 2),
    new Question("5 + 5", 10),
    new Question("10 + 5", 15),
    new Question("50 + 5", 55),
    new Question("7 + 8", 15)
  ];

  public static readonly Question[] SubtractionQuestions = [
    new Question("1 - 1", 0),
    new Question("5 - 3", 2),
    new Question("10 - 5", 5),
    new Question("50 - 5", 45),
    new Question("8 - 7", 1)
  ];

  public static readonly Question[] MultiplicationQuestions = [
    new Question("1 * 1", 1),
    new Question("5 * 3", 15),
    new Question("10 * 5", 50),
    new Question("5 * 5", 25),
    new Question("8 * 7", 56)
  ];

  public static readonly Question[] DivisionQuestions = [
    new Question("1 / 1", 1),
    new Question("6 / 3", 2),
    new Question("45 / 5", 9),
    new Question("95 / 5", 19),
    new Question("21 / 7", 3)
  ];

  public static readonly Question[] RandomQuestions = [
    new Question("1 / 1", 1),
    new Question("5 * 3", 15),
    new Question("50 + 5", 55),
    new Question("7 + 8", 15),
    new Question("5 * 5", 25),
  ];
}
