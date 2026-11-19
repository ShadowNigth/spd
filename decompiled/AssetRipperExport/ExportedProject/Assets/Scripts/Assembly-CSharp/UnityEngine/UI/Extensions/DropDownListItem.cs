using System;

namespace UnityEngine.UI.Extensions
{
	[Serializable]
	public class DropDownListItem
	{
		[SerializeField]
		private string _caption;

		[SerializeField]
		private Sprite _image;

		[SerializeField]
		private bool _isDisabled;

		[SerializeField]
		private string _id;

		public Action OnSelect;

		internal Action OnUpdate;

		public string Caption
		{
			get
			{
				return _caption;
			}
			set
			{
				_caption = value;
				if (OnUpdate != null)
				{
					OnUpdate();
				}
			}
		}

		public Sprite Image
		{
			get
			{
				return _image;
			}
			set
			{
				_image = value;
				if (OnUpdate != null)
				{
					OnUpdate();
				}
			}
		}

		public bool IsDisabled
		{
			get
			{
				return _isDisabled;
			}
			set
			{
				_isDisabled = value;
				if (OnUpdate != null)
				{
					OnUpdate();
				}
			}
		}

		public string ID
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public DropDownListItem(string GFPFPGDHIDM = "", string JOKGOMFJMKK = "", Sprite GBCLDBHACGH = null, bool OEFJAKHGGPM = false, Action IIAGKCFHPBB = null)
		{
			_caption = GFPFPGDHIDM;
			_image = GBCLDBHACGH;
			_id = JOKGOMFJMKK;
			_isDisabled = OEFJAKHGGPM;
			OnSelect = IIAGKCFHPBB;
		}
	}
}
