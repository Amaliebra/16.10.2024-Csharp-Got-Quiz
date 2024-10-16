namespace GotQuiz;
class Program
{
    static void Main(string[] args)
    {
        Quiz quiz = new Quiz();
        QuizManager quizManager = new QuizManager(quiz);
    }
}
