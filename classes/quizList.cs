
public class quizList
{
    public Dictionary<int, string> quizQuestion = new Dictionary<int, string>();
    public Dictionary<int, List<string>> quizAnswers = new Dictionary<int, List<string>>();
    public Dictionary<int, string> correctAnswers = new Dictionary<int, string>();

    public void AddQuestion(int questionId, string question)
    {
        quizQuestion.Add(1, "What is the last thing Hodor says?");
        correctAnswers.Add("")
        quizQuestion.Add(2, "");
        quizQuestion.Add(3, "");
        quizQuestion.Add(4, "");
        quizQuestion.Add(5, "");
        quizQuestion.Add(6, "");
        quizQuestion.Add(7, "");
        quizQuestion.Add(8, "");
        quizQuestion.Add(9, "");
        quizQuestion.Add(10, "");
        quizQuestion.Add(11, "");
        quizQuestion.Add(12, "");
    }

    public void AddAnswer(int questionId, string answer)
    {
        quizAnswers[1].Add("Hodor");
        quizAnswers[1].Add("Hold the door");
        quizAnswers[1].Add("i'm holding the door");
        quizAnswers[1].Add("Hodor");
        //--------------------------
    }
}