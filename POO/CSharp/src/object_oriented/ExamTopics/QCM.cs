using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTopics
{
    class QCM
    {
        private Dictionary<Question, int> _questions;

        public QCM()
        {
            this._questions = new Dictionary<Question, int>();
        }

        public Dictionary<Question, int> Questions
        {
            get { return _questions; }
            // set { _questions = value; }
        }

        public void AddQuestion(Question question, int numberOfPointsPerQuestion)
        {
            this.Questions.Add(question, numberOfPointsPerQuestion);
        }

        public void RemoveQuestion(Question question)
        {
            this._questions.Remove(question);

            /*try
            {
            }
            catch (Exception)
            {
                Console.WriteLine("The question is not in the QCM.");
            }*/
        }

        public int CalculationTheAverageOfTheDifficulty()
        {
            if (this.Questions.Count == 0) throw new ApplicationException("You don't have a question.");
            int result = 0;
            foreach(Question question in this.Questions.Keys)
            {
                result += question.Difficulty;
            }
            return result / this._questions.Count;
        }

        public void Display()
        {

        }
    }
}
