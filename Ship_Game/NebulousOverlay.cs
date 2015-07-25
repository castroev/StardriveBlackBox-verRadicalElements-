using Microsoft.Xna.Framework;
using System;

namespace Ship_Game
{
	public sealed class NebulousOverlay
	{
		public Matrix WorldMatrix;

		public Vector3 Position;

		public float Scale = 1000f;

		public string Path;

		public NebulousOverlay()
		{
		}
	}
}