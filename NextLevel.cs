using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour
{
	public string callNext;

	void OnTriggerEnter (Collider other)
	{
		Application.LoadLevel (callNext);
	}
}
