using TMPro;
using UnityEngine;

namespace ScoreSystem.View
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text label;

        private Score _score;

        public void Construct(Score score) => _score = score;

        private void Start() => Bind();

        private void PrintLabel() => label.text = _score.Scores.ToString();
        
        private void Bind()
        {
            PrintLabel();
            _score.OnScoreChanged += PrintLabel;
        }

        private void Expose() => _score.OnScoreChanged -= PrintLabel;

        private void OnDestroy() => Expose();
    }
}