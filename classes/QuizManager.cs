namespace GotQuiz;
public class QuizManager
{
    public Quiz quiz;

    public QuizManager(Quiz quiz)
    {
        this.quiz = quiz;
    }

    public void StartQuiz()
    {
        foreach (var question in quiz.quizQuestion)
        {
            Console.WriteLine(question.Value);
        }
    }
}