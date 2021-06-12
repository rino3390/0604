using Main;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace MainTest
{
	[TestFixture]
	public class ErrorMessageTest
	{
		[Test]
		public void Should_Text_Currect_With_Custon_Text() {
			//Arrange
			var gameObject = new GameObject();
			var errorMessagePanel = gameObject.AddComponent<ErrorMessagePanel>();
			var textComponent = gameObject.AddComponent<Text>();
			errorMessagePanel.textErrorMessage = textComponent;
			Assert.NotNull(errorMessagePanel.textErrorMessage);
			//Act
			errorMessagePanel.setText("aaa");
			//Assert
			Assert.AreEqual("aaa" , textComponent.text);
		}
		[Test]
		public void Should_Open_Pannel() {
			//Arrange
			var gameObject = new GameObject();
			var errorMessagePanel = gameObject.AddComponent<ErrorMessagePanel>();
			gameObject.SetActive(false);
			Assert.AreEqual(false , gameObject.activeInHierarchy);
			//Act
			errorMessagePanel.Open();
			//Assert
			Assert.AreEqual(true , gameObject.activeInHierarchy);
		}
		[Test]
		public void Should_Close_Pannel() {
			//Arrange
			var gameObject = new GameObject();
			var errorMessagePanel = gameObject.AddComponent<ErrorMessagePanel>();
			gameObject.SetActive(true);
			Assert.AreEqual(true , gameObject.activeInHierarchy);
			//Act
			errorMessagePanel.Close();
			//Assert
			Assert.AreEqual(false , gameObject.activeInHierarchy);
		}
	}
}