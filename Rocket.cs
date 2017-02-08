using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	GLOBALS gl = new GLOBALS();

	void Update ()
	{
		//gl.Ignit();
		Debug.Log (gl.ignition);
	}
}
