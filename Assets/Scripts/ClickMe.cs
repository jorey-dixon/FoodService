using UnityEngine;
using System.Collections;

public class ClickMe : MonoBehaviour {

	private float one;
	private float two;
	private float three;

	void Start()
	{
		
	}

	void OnMouseUp()
	{
		one = Random.Range (0.0f, 1.0f);
		two = Random.Range (0.0f, 1.0f);
		three = Random.Range (0.0f, 1.0f);

		this.GetComponent<SpriteRenderer> ().color = new Color (one, two, three);
	}
}
