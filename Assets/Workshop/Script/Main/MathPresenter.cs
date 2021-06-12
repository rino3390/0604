using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Utilities.Contract;

namespace Main
{
	public class MathPresenter : MonoBehaviour
	{
		private StarMath starMath;
		[SerializeField]
		private Button buttonCaculate;
		[SerializeField]
		private InputField inputNumber1;
		[SerializeField]
		private InputField inputNumber2;
		[SerializeField]
		private Text textResult;
		[SerializeField]
		private ErrorMessagePanel panelErrorMessage;

		private void Start() {
			starMath = new StarMath();

			buttonCaculate.onClick.AddListener(() => {
				var number1 = int.Parse(inputNumber1.text);
				var number2 = int.Parse(inputNumber2.text);

				try {
					var result = starMath.Add(number1, number2);
					textResult.text = result.ToString();
				}
				catch (PreconditionViolationException e) {
					panelErrorMessage.setText(e.Message);
					panelErrorMessage.Open();
				}
			});
		}
	}
}