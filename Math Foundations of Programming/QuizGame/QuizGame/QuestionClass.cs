namespace QuizGame
{
    public class QuestionClass
    {
        public QuestionClass()
        {
            Options = new List<string>();
        }

        public string Question { get; set; }
        public List<string> Options { get; set; }

        public string CorrectAnswer { get; set; }
    }
}
