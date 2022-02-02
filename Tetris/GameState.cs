namespace Tetris
{
	public class GameState
	{
		private Block currentBlock;

		public Block CurrentBlock
		{
			get => currentBlock;
			private set
			{
				currentBlock = value;
				currentBlock.Reset();
			}
		}

		public GameGrid GameGrid { get; }
		public BlockQueue BlockQueue{get;}
		public bool GameOver { get; private set; }
	}
}
