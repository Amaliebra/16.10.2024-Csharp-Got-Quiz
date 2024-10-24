
using System.Formats.Asn1;

namespace GotQuiz;
public class Quiz
{
    public Dictionary<int, QuizQuestion> Questions { get; } = new();
    // public Dictionary<int, string> quizQuestion = new Dictionary<int, string>();
    // public Dictionary<int, List<string>> quizAnswers = new Dictionary<int, List<string>>();
    // public Dictionary<int, string> correctAnswers = new Dictionary<int, string>();

    public Quiz()
    {
        AddQuestion(new QuizQuestion
        {
            Id = 1,
            Text = "What is the last thing Hodor says?",
            Answers = 
            {
                new Answer (1, "Hodor"),
                new Answer (2, "Hold the door"),
                new Answer (3, "I'm holding the door"),
                new Answer (4, "Save me")

            },
            CorrectAnswerId = 1
        });
        AddQuestion(new QuizQuestion
        {
            Id = 2,
            Text = "Who is the Lord Commander of the Night's Watch before Jon Snow?",
            Answers = 
            {
                new Answer (1, "Jorah Mormont"),
                new Answer (2, "Aemon"),
                new Answer (3, "Jeor Mormont"),
                new Answer (4, "Alliser Thorne")

            },
            CorrectAnswerId = 3
        });
        AddQuestion(new QuizQuestion
        {
            Id = 3,
            Text = "What is the name of Daenerys green dragon?",
            Answers = 
            {
                new Answer (1, "Drogon"),
                new Answer (2, "Viserys"),
                new Answer (3, "Viserion"),
                new Answer (4, "Rhaegal")

            },
            CorrectAnswerId = 4
        });
    }

    public void AddQuestion(QuizQuestion question)
    {
        Questions.Add(question.Id, question);
    }

    public void AddAnswer(int questionId, string answer)
    {
        if(!Questions.ContainsKey(questionId))
            throw new ArgumentException("Question id not found");
        Questions[questionId].Answers.Add(answer);
        
    }

    public class QuizQuestion
    {
        public int Id {get; set;}
        public string Text {get; set;}
        public List<Answer> Answers {get;} = new();
        public int CorrectAnswerId {get; set;}
    }

    public class Answer 
    {
        public int Id {get; set;}
        public string Text {get; set;}

        public Answer(int id, string text)
    {
        Id = id;
        Text = text;
    }
    }

}