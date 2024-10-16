using GameSystem;
using UnityEngine;

namespace InputSystem
{
	public class InputListener : MonoBehaviour
	{
		[SerializeField] private KeyCode exitAppKey;

		private Game _game;

		public void Construct(Game game) => _game = game;

		private void Update()
		{
			ExitAppInputHandler();
		}

		private void ExitAppInputHandler()
		{
			if (Input.GetKeyDown(exitAppKey))
				_game.ExitGame();
		}
	}
}