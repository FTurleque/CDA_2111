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
        // Not need is the array.Length.
        private int _multipleChoice;
        private double _numberOfPointsPerQuestion;
        private Answer _answers;

        public Question(string statementOfReview, double numberOfPointsPerQuestion, int multipleChoice, int difficulty)
        {
            this.StatementOfReview = statementOfReview;
            this.NumberOfPointsPerQuestion = numberOfPointsPerQuestion;
            this.MultipleChoice = multipleChoice;
            this.Difficulty = difficulty;
            this.Answers = null;
        }

        public Answer Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

        public double NumberOfPointsPerQuestion
        {
            get { return _numberOfPointsPerQuestion; }
            init { _numberOfPointsPerQuestion = value; }
        }

        public int MultipleChoice
        {
            get { return _multipleChoice; }
            init { _multipleChoice = value; }
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
    }
}
