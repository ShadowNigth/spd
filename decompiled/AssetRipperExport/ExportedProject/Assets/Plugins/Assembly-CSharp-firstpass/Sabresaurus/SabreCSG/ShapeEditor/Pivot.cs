using System;
using UnityEngine;

namespace Sabresaurus.SabreCSG.ShapeEditor
{
	[Serializable]
	public class Pivot : ISelectable
	{
		[SerializeField]
		private Vector2Int _position;

		public Vector2Int position
		{
			get
			{
				return _position;
			}
			set
			{
				_position = value;
			}
		}
	}
}
