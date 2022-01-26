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
            get { return this._answers; }
            set { this._answers = value; }
        }

        public int Difficulty
        {
            get { return this._difficulty; }
            private set 
            {
                if (value < 0) this._difficulty = 0;
                else if (value > 100) this._difficulty = 100;
                else this._difficulty = value; 
            }
        }

        public string StatementOfReview
        {
            get { return this._statementOfReview; }
            init { this._statementOfReview = value; }
        }

        public void AddAnswer(string answer, bool goodAnswer)
        {
            Answer tmp = new(answer, goodAnswer);
            this.Answers.Add(tmp);
        }
    }
}
