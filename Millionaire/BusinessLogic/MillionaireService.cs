using DataAccesLayer;
using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class MillionaireService : IMillionaireService
    {
        private readonly IDbRepository _db;
        private Queue<Question> questionsPerGame;

        public MillionaireService(IDbRepository db)
        {
            _db = db;
        }
        public Question GetNextQuestion()
        {
            return questionsPerGame.Peek();
        }

        public Queue<Question> GetQuestions(int count)
        {
            questionsPerGame = new(_db.Get().OrderBy(order => Guid.NewGuid()).Take(count));
            return questionsPerGame;
        }
    }
}
