using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTopics
{
    class QCM
    {
        private List<Question> _questions;

        public QCM(List<Question> questions)
        {
            this.Questions = questions;
        }

        public List<Question> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        public void Display()
        {

        }
    }
}
