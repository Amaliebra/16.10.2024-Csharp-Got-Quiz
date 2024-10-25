namespace GotQuiz
{    public class QuizManager
    {
        public Quiz quiz;

        public QuizManager(Quiz quiz)
        {
            this.quiz = quiz;
        }

        public void StartQuiz()
        {
            Quiz quiz = new Quiz();
            int userScore = 0;
            int totalQuestions = quiz.Questions.Count;

            Console.WriteLine("Welcome to the quiz about the Game of thrones universe");

            foreach (var question in quiz.Questions)
            {
                int questionId = question.Key;
                string questionText = question.Value.Text;
                List<string> answers = question.Value.Answers.Select(a => a.Text).ToList();

                Console.WriteLine($"\n Question {questionId}: {questionText}");

                for (int i = 0; i < answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {answers[i]}");
                }

                Console.Write("\nEnter the number of your answer: ");
                string userInput = Console.ReadLine()?.Trim() ?? "You need to type a number";

                int userAnswerIndex;
                bool validInput = int.TryParse(userInput, out userAnswerIndex) && userAnswerIndex > 0 && userAnswerIndex <= answers.Count;

                if (validInput)
                {
                    string selectedAnswer = answers[userAnswerIndex - 1];
                    var answer = quiz.Questions[questionId].Answers.FirstOrDefault(a => a.Id == question.Value.CorrectAnswerId);
                    if ( answer != null)
                    {
                        if (selectedAnswer == answer.Text)
                        {
                            Console.WriteLine("Correct\n");
                            userScore++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("no answer found with this 'CorrectAnswerId'");
                    }
                }
                else
                {
                    Console.WriteLine("invalid input. Gathering next question.\n");
                }
            }

            Console.WriteLine($"You finished the quiz, with a score of: {userScore}/{totalQuestions}");
        }
    }

}