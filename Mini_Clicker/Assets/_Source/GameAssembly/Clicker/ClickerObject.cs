using ScoreSystem;
using UnityEngine;

namespace Clicker
{
    public class ClickerObject : MonoBehaviour
    {
        private Score _score;

        public void Construct(Score score) => _score = score;

        private void OnMouseDown()
        {
            _score.RemoveScore(1);
        }
    }
}
