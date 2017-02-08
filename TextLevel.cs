using UnityEngine;
using System.Collections;

public class TextLevel : MonoBehaviour {

	public GameObject textg;
	public int vanishText;

	void Start () 
	{
		StartCoroutine (TextLvl());
	}


	//TextLevel
	IEnumerator TextLvl()
	{
		GUIText Level = GameObject.Find ("Text").GetComponent<GUIText> ();
		yield return new WaitForSeconds (vanishText);
		Destroy (textg);
	}

}
