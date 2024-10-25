namespace GotQuiz
{
    public class Quiz
    {
        public Dictionary<int, QuizQuestion> Questions { get; } = new();

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
            AddQuestion(new QuizQuestion
            {
                Id = 4,
                Text = "What the real name of Jon Snow?",
                Answers = 
                {
                    new Answer (1, "Aerys Targaryen"),
                    new Answer (2, "Aegon Targaryen"),
                    new Answer (3, "Viserys Targaryen"),
                    new Answer (4, "Rhaegar Targaryen")
                },
                CorrectAnswerId = 2
            });
            AddQuestion(new QuizQuestion
            {
                Id = 5,
                Text = "What is the real meaning of 'Valar Morghulis'?",
                Answers = 
                {
                    new Answer (1, "Power is power"),
                    new Answer (2, "The night is dark and full of terrors"),
                    new Answer (3, "Winter is coming"),
                    new Answer (4, "All men must die")
                },
                CorrectAnswerId = 4
            });
        }

        public void AddQuestion(QuizQuestion question)
        {
            Questions.Add(question.Id, question);
        }

        public void AddAnswer(int questionId, string answerText)
        {
            if(!Questions.ContainsKey(questionId))
            {
                throw new ArgumentException("Question id not found");
            }

            Questions[questionId].Answers.Add(new Quiz.Answer(questionId, answerText));
            
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
}