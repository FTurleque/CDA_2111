using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTopics
{
    class Question
    {
        private string _statementOfReview;
        private int _difficulty;
        private List<Answer> _answers;

        public Question(string statementOfReview, int difficulty)
        {
            this.StatementOfReview = statementOfReview;
            this.Difficulty = difficulty;
            this.Answers = new List<Answer>();
        }

        public List<Answer> Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

        public int Difficulty
        {
            get { return _difficulty; }
            private set { _difficulty = value; }
        }

        public string StatementOfReview
        {
            get { return _statementOfReview; }
            init { _statementOfReview = value; }
        }

        public void AddAnswer(string answer, bool goodAnswer)
        {
            Answer tmp = new(answer, goodAnswer);
            this.Answers.Add(tmp);
        }
    }
}
