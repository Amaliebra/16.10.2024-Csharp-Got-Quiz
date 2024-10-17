namespace GotQuiz;
public class Quiz
{
    public Dictionary<int, string> quizQuestion = new Dictionary<int, string>();
    public Dictionary<int, List<string>> quizAnswers = new Dictionary<int, List<string>>();
    public Dictionary<int, string> correctAnswers = new Dictionary<int, string>();

    public void AddQuestion(int questionId, string question)
    {
        quizQuestion.Add(1, "What is the last thing Hodor says?");
        correctAnswers.Add(1, "Hodor");
        //---------------------
        quizQuestion.Add(2, "Who is the Lord Commander of the Night's Watch before Jon Snow?");
        correctAnswers.Add(2, "Jeor Mormont");
        //---------------------
        quizQuestion.Add(3, "What is the name of Daenerys green dragon?");
        correctAnswers.Add(3, "Rhaegal");
        //---------------------
        quizQuestion.Add(4, "");
        correctAnswers.Add(4,"");
        //---------------------
        quizQuestion.Add(5, "");
        correctAnswers.Add(5,"");
        //---------------------
        quizQuestion.Add(6, "");
        correctAnswers.Add(6,"");
        //---------------------
        quizQuestion.Add(7, "");
        correctAnswers.Add(7,"");
        //---------------------
        quizQuestion.Add(8, "");
        correctAnswers.Add(8,"");
        //---------------------
        quizQuestion.Add(9, "");
        correctAnswers.Add(9,"");
        //---------------------
        quizQuestion.Add(10, "");
        quizQuestion.Add(11, "");
        quizQuestion.Add(12, "");
    }

    public void AddAnswer(int questionId, string answer)
    {
        quizAnswers[1].Add("Hodor");
        quizAnswers[1].Add("Hold the door");
        quizAnswers[1].Add("i'm holding the door");
        quizAnswers[1].Add("Save me");
        //--------------------------
        quizAnswers[2].Add("Jorah Mormont");
        quizAnswers[2].Add("Aemon");
        quizAnswers[2].Add("Jeor Mormont");
        quizAnswers[2].Add("Alliser Thorne");
        //-------------------------
        quizAnswers[3].Add("Viserion");
        quizAnswers[3].Add("Viserys");
        quizAnswers[3].Add("Rhaegal");
        quizAnswers[3].Add("Drogon");
        //-------------------------
        quizAnswers[4].Add("");
        quizAnswers[4].Add("");
        quizAnswers[4].Add("");
        quizAnswers[4].Add("");
        //------------------------
        quizAnswers[5].Add("");
        quizAnswers[5].Add("");
        quizAnswers[5].Add("");
        quizAnswers[5].Add("");
        //-----------------------
        quizAnswers[6].Add("");
        quizAnswers[6].Add("");
        quizAnswers[6].Add("");
        quizAnswers[6].Add("");
        //------------------------
    }
}