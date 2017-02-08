using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class Moving : MonoBehaviour
{
    public float speed;
    public Rigidbody rigebo;
    public Boundary boundry;

    void Start()
    {
		rigebo = GetComponent<Rigidbody> ();
	}

    void FixedUpdate ()
    {
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		Vector3 movimento = new Vector3 (moveH, moveV, 0);
		rigebo.velocity = movimento * speed;

		transform.Translate (Input.acceleration.x, 0, 0);

		rigebo.position = new Vector2 (
			Mathf.Clamp (rigebo.position.x, boundry.xMin, boundry.xMax),
			Mathf.Clamp (rigebo.position.y, boundry.yMin, boundry.yMax)
		);

//	    Debug.Log (ignition);
//		Ignit ();
	}
}
