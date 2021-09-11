using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccesLayer.Entities
{
    public class Question
    {
        public Guid Id { get; set; }
        [MaxLength(200)]
        public string QuestionText { get; set; }
        [MaxLength(50)]
        public string FirstVariant { get; set; }
        [MaxLength(50)]
        public string SecondVariant { get; set; }
        [MaxLength(50)]
        public string ThirdVariant { get; set; }
        [MaxLength(50)]
        public string FourthVariant { get; set; }
        [MaxLength(50)]
        public string RightAnswer { get; set; }
    }
}
