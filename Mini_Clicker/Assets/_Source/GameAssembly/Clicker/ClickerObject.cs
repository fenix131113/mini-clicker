using ScoreSystem;
using UnityEngine;

namespace Clicker
{
    public class ClickerObject : MonoBehaviour
    {
        private const int SCORE_PER_CLICK = 1;
        
        private Score _score;

        public void Construct(Score score) => _score = score;

        private void OnMouseDown()
        {
            _score.RemoveScore(SCORE_PER_CLICK);
        }
    }
}
