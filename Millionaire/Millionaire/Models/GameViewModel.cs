using DataAccesLayer.Entities;
using System;
using System.Collections.Generic;

namespace Millionaire.Models
{
    public class GameViewModel
    {
        /// <summary>
        /// Couldn't figure out hot to make it non-static. Didn't find a way to pass a collection(queue) from view back to controller. 
        /// </summary>
        public static Queue<Question> QuestionQueue;
        public static Score GameScore { get; set; }
        public string UserAnswer { get; set; }

        public bool FiftyFiftyIsUsed = false;
    }
    public class Score
    {
        private static readonly int[] ScoreSystemFor15Questions = new int[]
         { 0, 100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000,
            32000, 64000, 125000, 250000, 500000, 1000000
         };
        private static readonly int[] ScoreSystemFor10Questions = new int[]
        { 0, 500, 1000, 5000, 10000, 25000,
            50000, 100000, 250000, 500000, 1000000
        };
        private static readonly int[] ScoreSystemFor5Questions = new int[]
        { 0, 62500, 125000, 250000, 500000, 1000000};

        private int count = 0;
        private readonly int[] arrayToItterate;
        public int Value { get => arrayToItterate[count]; }
        public void Increase() => count++;

        public Score(int questionQount)
        {
            //c# 9.0 features
            arrayToItterate = questionQount switch
            {
                15 => ScoreSystemFor15Questions,
                10 => ScoreSystemFor10Questions,
                5 => ScoreSystemFor5Questions,
                _ => throw new ArgumentException("Wrong question count passed"),
            };
        }

    }
}
