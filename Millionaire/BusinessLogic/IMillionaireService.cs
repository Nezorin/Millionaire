using DataAccesLayer.Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IMillionaireService
    {
        public Queue<Question> GetQuestions(int count);
    }
}
