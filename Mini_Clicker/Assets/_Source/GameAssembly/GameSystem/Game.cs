using ScoreSystem;
using UnityEngine;

namespace GameSystem
{
    public class Game
    {
        private const int StartScore = 5;

        private Score _score;

        public void Construct(Score score) => _score = score;

        public void StartGame()
        {
            _score.AddScore(StartScore);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
