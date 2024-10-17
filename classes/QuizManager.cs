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
        int userScore = 0;

        foreach (var question in quiz.quizQuestion)
        {
            int questionId = question.Key;
            string questionText = question.Value;

            Console.WriteLine($"\n Question: {questionId}");
        }
    }
}