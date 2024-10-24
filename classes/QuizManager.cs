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

            Console.WriteLine("Welcome to the quiz about the Game of thrones universe");

            foreach (var question in Quiz.QuizQuestion)
            {
                int questionId = question.Key;
                string questionText = quiz.quizQuestion[questionId];
                List<string> answers = quiz.quizAnswers[questionId];

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
                    if (selectedAnswer == quiz.[questionId])
                    {
                        Console.WriteLine("correct!\n");
                        userScore++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect.");
                    }
                }
                else
                {
                    Console.WriteLine("invalid input. Gathering next question.\n");
                }
            }

            Console.WriteLine($"You finished the quiz, with a score of: {userScore}/{quiz.quizQuestion.Count}");
        }
    }

}