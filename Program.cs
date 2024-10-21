using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace GotQuiz;
public class Program
{
    static void Main(string[] args)
    {
        Quiz quiz = new Quiz();
        QuizManager quizManager = new QuizManager(quiz);
        quizManager.StartQuiz();
    }

}
