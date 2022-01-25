using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTopics
{
    class Answer
    {
        private string _answerToQuestion;
        private bool _goodAnswer;

        public Answer(string answerToQuestion, bool goodAnswer)
        {
            this.AnswerToQuestion = answerToQuestion;
            this.GoodAnswer = goodAnswer;
        }

        public bool GoodAnswer
        {
            get { return _goodAnswer; }
            init { _goodAnswer = value; }
        }

        public string AnswerToQuestion
        {
            get { return _answerToQuestion; }
            init { _answerToQuestion = value; }
        }
    }
}
