using UnityEngine;
using System.Collections;


public class Mover : MonoBehaviour
{
    public float speed;
    public Rigidbody rigebo;

    void Start()
    {
		rigebo = GetComponent<Rigidbody> ();
	}

    void FixedUpdate ()
    {
//		Vector3 movimento = new Vector3 (0, speed, 0);
		transform.Translate (0, Random.Range(speed/2,speed*2) * Time.deltaTime, 0);
	}
}
