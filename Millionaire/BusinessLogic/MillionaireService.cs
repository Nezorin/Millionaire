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
        public MillionaireService(IDbRepository db)
        {
            _db = db;
        }
        /// <summary>
        /// Take random N questions from epository
        /// </summary>
        /// <param name="count"> Count of qusetions to take</param>
        public Queue<Question> GetQuestions(int count)
        {
            return new(_db.Get().OrderBy(order => Guid.NewGuid()).Take(count));
        }
    }
}
