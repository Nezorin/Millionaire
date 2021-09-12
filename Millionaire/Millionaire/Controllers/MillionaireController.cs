using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Millionaire.Models;

namespace Millionaire.Controllers
{
    public class MillionaireController : Controller
    {
        private readonly IMillionaireService _millionaireService;

        public MillionaireController(IMillionaireService millionaireService)
        {
            _millionaireService = millionaireService;
        }
        [HttpPost]
        public IActionResult StartGame(int questionCount)
        {
            ;
            var gameViewModel = new GameViewModel();
            GameViewModel.GameScore = new Score(questionCount);
            GameViewModel.QuestionQueue = _millionaireService.GetQuestions(questionCount);
            return View("Game", gameViewModel);
        }

        [HttpPost]
        public IActionResult Game(GameViewModel gameViewModel, bool fiftyFiftyUsed)
        {
            GameViewModel.FiftyFiftyIsUsed = fiftyFiftyUsed || GameViewModel.FiftyFiftyIsUsed;
            if (gameViewModel.UserAnswer == GameViewModel.QuestionQueue.Dequeue().RightAnswer)
            {
                GameViewModel.GameScore.Increase();
                if (GameViewModel.QuestionQueue.Count == 0)
                {
                    return View("WinnerView", GameViewModel.GameScore.Value);
                }

                return View(gameViewModel);
            }
            return View("GameOver", GameViewModel.GameScore.Value);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
