using UnityEngine;
using UnityEngine.UI ;
using System.Collections;

public class PressX : MonoBehaviour {

	void Start () {
		InvokeRepeating("ShowText", 0, 0.5f) ;
	}
	
	void ShowText () {
		if (Input.GetKey("x"))
		{
			Application.LoadLevel(2);
		}

	}
}
