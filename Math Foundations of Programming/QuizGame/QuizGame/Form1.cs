using Newtonsoft.Json;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        private List<QuestionClass> questions;
        private int currentQuestionIndex;

        public Form1()
        {
            InitializeComponent();
            questions = new List<QuestionClass>();
            currentQuestionIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuestionClass question1 = new QuestionClass
            {
                Question = "How many manned moon landings have there been?",
                Options = { "6", "1", "3", "7" },
                CorrectAnswer = "6"
            };

            QuestionClass question2 = new QuestionClass
            {
                Question = "To what political party did Abraham Lincoln belong when elected POTUS?",
                Options = { "Democrat", "Independent", "Republican", "Whig" },
                CorrectAnswer = "Republican"
            };

            QuestionClass question3 = new QuestionClass
            {
                Question = "What is the largest country in the world?",
                Options = { "China", "Russian Federation", "USA", "Canada" },
                CorrectAnswer = "Russian Federation"
            };

            QuestionClass question4 = new QuestionClass
            {
                Question = "What is Laos?",
                Options = { "Region", "Country", "River", "City" },
                CorrectAnswer = "Country"
            };

            QuestionClass question5 = new QuestionClass
            {
                Question = "What is the capital of Jamaica?",
                Options = { "San Juan", "Bridgetown", "Kingston", "Port-au-Prince" },
                CorrectAnswer = "Kingston"
            };

            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);


            option1.CheckedChanged += RadioButton_CheckedChanged;
            option2.CheckedChanged += RadioButton_CheckedChanged;
            option3.CheckedChanged += RadioButton_CheckedChanged;
            option4.CheckedChanged += RadioButton_CheckedChanged;

            DisplayQuestion(questions[currentQuestionIndex]);
        }

        private void DisplayQuestion(QuestionClass question)
        {
            textBox1.Text = question.Question;
            option1.Text = question.Options[0];
            option2.Text = question.Options[1];
            option3.Text = question.Options[2];
            option4.Text = question.Options[3];

            option1.Checked = option2.Checked = option3.Checked = option4.Checked = false;
            ResetRadioButtonColor(option1);
            ResetRadioButtonColor(option2);
            ResetRadioButtonColor(option3);
            ResetRadioButtonColor(option4);
        }

        private void ResetRadioButtonColor(RadioButton radioButton)
        {
            radioButton.BackColor = SystemColors.Control;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                CheckAnswer(radioButton, questions[currentQuestionIndex]);
            }
        }

        private void CheckAnswer(RadioButton rbtn, QuestionClass question)
        {
            string selectedOption = rbtn.Text;
            string correctAnswer = question.CorrectAnswer;

            if (selectedOption == correctAnswer)
            {
                rbtn.BackColor = System.Drawing.Color.Green; 
            }
            else
            {
                rbtn.BackColor = System.Drawing.Color.Red; 
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion(questions[currentQuestionIndex]);
            }
            else
            {
                MessageBox.Show("Finished");
            }
        }
    }
}
