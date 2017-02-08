using UnityEngine;
using System.Collections;

public class GameController2 : MonoBehaviour
{
	public float startWait;
	public int hazardCount;
	public GameObject hazard;
	public GameObject hazardtwo;
	public Vector3 spawnValues;
	public float spawnWaitMin, spawnWaitMax;

	public GameObject EndOfLevel;

	void Start ()
	{
		StartCoroutine (Hazard1());
		StartCoroutine (Hazard2());
	}

//Meteoros1
	IEnumerator Hazard1 ()
	{
		Quaternion spawnRotation = new Quaternion ();
		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < Random.Range(hazardCount-2,hazardCount+2); i++)
		{
			Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x , spawnValues.x) , spawnValues.y, spawnValues.z);
			Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (Random.Range(spawnWaitMin,spawnWaitMax));
		}
		Vector3 spawnPos = new Vector3 (Random.Range(0, 0) , spawnValues.y, spawnValues.z);
		Instantiate (EndOfLevel, spawnPos, spawnRotation);
	}
//Meteoros2
	IEnumerator Hazard2 ()
	{
		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < hazardCount-11; i++)
		{
			Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x , spawnValues.x) , spawnValues.y, spawnValues.z);
			Quaternion spawnRotation = new Quaternion ();
			Instantiate (hazardtwo, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (Random.Range(spawnWaitMin+0.3f,spawnWaitMax+0.4f));
		}
	}
}
