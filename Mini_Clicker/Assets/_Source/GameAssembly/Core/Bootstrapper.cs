using Clicker;
using GameSystem;
using InputSystem;
using ScoreSystem;
using ScoreSystem.View;
using UnityEngine;

namespace Core
{
	public class Bootstrapper : MonoBehaviour
	{
		[SerializeField] private InputListener listener;
		[SerializeField] private ClickerObject clicker;
		[SerializeField] private ScoreView scoreView;
		
		private Game _game;
		private Score _score;
		
		private void Awake()
		{
			_game = new Game();
			_score = new Score();

			scoreView.Construct(_score);
			clicker.Construct(_score);
			
			listener.Construct(_game);
			_game.Construct(_score);
			_game.StartGame();
		}
	}
}
