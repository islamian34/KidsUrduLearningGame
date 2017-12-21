using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changebuton : MonoBehaviour {

    public void changebutton(string buttonno)
    {
        Application.LoadLevel(buttonno);
    }
}
