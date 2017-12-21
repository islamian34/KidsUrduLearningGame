using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changelevel : MonoBehaviour {

	public void changescene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
