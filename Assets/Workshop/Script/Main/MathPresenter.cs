using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Main
{
	public class MathPresenter : MonoBehaviour
	{
		private StarMath  starMath;
		[SerializeField]
		private Button buttonCaculate;
		[SerializeField]
		private InputField inputNumber1;
		[SerializeField]
		private InputField inputNumber2;
		[SerializeField]
		private Text textResult;

		private void Start() {
			starMath = new StarMath();
			buttonCaculate.onClick.AddListener(() => {
				var number1 = int.Parse(inputNumber1.text);
				var number2 = int.Parse(inputNumber2.text);
				var result = starMath.Add(number1, number2);
				textResult.text = result.ToString();
			});
		}
	}
}