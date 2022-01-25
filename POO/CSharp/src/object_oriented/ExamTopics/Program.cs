using System;

namespace ExamTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            QCM exam1 = new QCM();
            Question q1 = new("1. De quel couleur est le cheval blanc d'Henry V ?", 0);
            q1.AddAnswer("Bleu", false);
            q1.AddAnswer("Marron", false);
            q1.AddAnswer("Marron et blanc", false);
            q1.AddAnswer("Blanc", true);
            exam1.RemoveQuestion(q1);
            exam1.AddQuestion(q1, 1);
        }
    }
}
