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
            this.Questions = new Dictionary<Question, int>();
        }

        public Dictionary<Question, int> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        public void AddQuestion(Question question, int numberOfPointsPerQuestion)
        {
            this.Questions.Add(question, numberOfPointsPerQuestion);
        }

        public void RemoveQuestion(Question question)
        {
            try
            {
                this.Questions.Remove(question);
            }
            catch (Exception)
            {
                throw new ApplicationException("The question is not in the QCM.");
            }
        }

        public void Display()
        {

        }
    }
}
