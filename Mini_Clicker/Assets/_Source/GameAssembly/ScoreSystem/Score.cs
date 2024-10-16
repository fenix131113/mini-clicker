using System;
using UnityEngine;

namespace ScoreSystem
{
	public class Score
	{
		public int Scores { get; private set; }
		public event Action OnScoreChanged;
		
		public void AddScore(int score)
		{
			Scores += score;
			OnScoreChanged?.Invoke();
		}

		public void RemoveScore(int score)
		{
			Scores = Mathf.Clamp(Scores - score, 0, int.MaxValue);
			OnScoreChanged?.Invoke();
		}
	}
}