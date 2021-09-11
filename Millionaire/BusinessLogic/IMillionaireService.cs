using DataAccesLayer.Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IMillionaireService
    {
        public Question GetNextQuestion();
        public Queue<Question> GetQuestions(int count);
    }
}
