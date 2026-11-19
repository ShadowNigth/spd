using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldResizer : MonoBehaviour
{
	private InputField inputField;

	private LayoutElement layoutElement;

	public ScrollRect scrollRect;

	private void Awake()
	{
		inputField = GetComponent<InputField>();
		layoutElement = GetComponent<LayoutElement>();
	}

	public void ResizeInput()
	{
		string text = inputField.text;
		Vector2 size = inputField.textComponent.rectTransform.rect.size;
		TextGenerationSettings generationSettings = inputField.textComponent.GetGenerationSettings(size);
		generationSettings.generateOutOfBounds = false;
		layoutElement.preferredHeight = new TextGenerator().GetPreferredHeight(text, generationSettings);
		if ((bool)scrollRect)
		{
			StartCoroutine(ScrollMax());
		}
	}

	private IEnumerator ScrollMax()
	{
		yield return new WaitForEndOfFrame();
		if (scrollRect != null)
		{
			scrollRect.verticalNormalizedPosition = 0f;
		}
	}
}
