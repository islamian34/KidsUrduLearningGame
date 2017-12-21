using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class change : MonoBehaviour {
	public Sprite letter_a;
	public Button b1;
	// Use this for initialization
	void awake(){
		letter_a = Resources.Load<Sprite> ("images");

	}
	
	// Update is called once per frame
	public void on_click_button(){
		b1.image.sprite = letter_a;
		Debug.Log ("button clicked method called");
	}
}
