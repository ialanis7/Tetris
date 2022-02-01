using System.Collections.Generic;

namespace Tetris
{
	public abstract class Block
	{
		//contains tile positions in the 4 rotation states
		protected abstract Position[][] Tiles { get; }
		//Where the block spawns in the grid
		protected abstract Position StartOffset { get; }
		//distinguishes blocks by id
		public abstract int Id { get; }

		private int rotationState;
		private Position offset;

		public Block()
		{
			offset = new Position(StartOffset.Row, StartOffset.Column);
		}

		public IEnumerable<Position> TilePositions() 
		{
			foreach (Position p in Tiles[rotationState]) 
			{
				yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
			}

		}

	}
}
