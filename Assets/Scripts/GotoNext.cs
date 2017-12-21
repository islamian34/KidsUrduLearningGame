using UnityEngine;
using System.Collections;

public class GotoNext : MonoBehaviour {

 public void goToScene(string sceneName){
		Application.LoadLevel (sceneName);
	}
}
