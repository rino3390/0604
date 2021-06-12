using System;
using UnityEngine;
using UnityEngine.UI;

namespace Main
{
	public class ErrorMessagePanel : MonoBehaviour
	{
		[SerializeField]
		private Button buttonClosePanel;
		public Text textErrorMessage;

		private void Start() {
			buttonClosePanel.onClick.AddListener(Close);
		}

		public void setText(string _text) {
			textErrorMessage.text = _text;
		}

		public void Open() {
			gameObject.SetActive(true);
		}

		public void Close() {
			gameObject.SetActive(false);
		}
	}
}