using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTopics
{
    class Answer
    {
        /*private string _answerToQuestion;
        private bool _goodAnswer;*/
        private Dictionary<string, bool> _answersToQuestion;
        private Question _questionAsk;

        public Answer(Question questionAsk)
        {
            this.QuestionAsk = questionAsk;
            this.AnswersToQuestion = new();
        }

        public Dictionary<string, bool> AnswersToQuestion
        {
            get { return _answersToQuestion; }
            set { _answersToQuestion = value; }
        }

        /*public bool GoodAnswer
        {
            get { return _goodAnswer; }
            set { _goodAnswer = value; }
        }

        public string AnswerToQuestion
        {
            get { return _answerToQuestion; }
            set { _answerToQuestion = value; }
        }*/

        public Question QuestionAsk
        {
            get { return _questionAsk; }
            init { _questionAsk = value; }
        }

        public void AddAnswer(string answerToQuestion, bool goodAnswer)
        {
            for (int i = 0; i < QuestionAsk.MultipleChoice; i++)
            {
                AnswersToQuestion.Add(answerToQuestion, goodAnswer);
            }
        }
    }
}
