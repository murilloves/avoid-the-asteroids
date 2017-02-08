using UnityEngine;
using System.Collections;

[System.Serializable]
public class Variables
{
	public float velx = 0, vely = 0, sizx = 0, sizy = 0;
}


public class BGScroller : MonoBehaviour
{
	public Variables vary;

	void Start ()
	{
    //		StartCoroutine(Example());
	}

    /*	
	IEnumerator Example()
	{
		print(Time.time);
		yield return new WaitForSeconds(5);
		print(Time.time);
	}
    */

	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector2 (transform.position.x + vary.velx, transform.position.y + vary.vely);
		transform.localScale = new Vector2 (transform.localScale.x + vary.sizx, transform.localScale.y + vary.sizy);
//		transform.rotation = new Vector2 (transform.rotation.x + 1, transform.localScale.y + 1);
	}
}
