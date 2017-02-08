using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public Rigidbody rigebo;
	public float tumble;

	void Start ()
	{
		rigebo = GetComponent<Rigidbody> ();
		rigebo.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
