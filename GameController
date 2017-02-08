using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public float startWait;
	public int hazardCount;
	public GameObject hazard;
	public Vector3 spawnValues;
	public float spawnWaitMin, spawnWaitMax;

	public GameObject EndOfLevel;

	void Start ()
	{
		StartCoroutine (Hazard1());
	}


//Scheme Level Method
	IEnumerator Hazard1 ()
	{
		Quaternion spawnRotation = new Quaternion ();

		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < (Random.Range(hazardCount-2,hazardCount+2)/2); i++)
		{
			Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x , spawnValues.x) , spawnValues.y, spawnValues.z);
			//Quaternion spawnRotation = new Quaternion ();
			Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (Random.Range(spawnWaitMin,spawnWaitMax));
		}
		for (int i = 0; i < (Random.Range(hazardCount-2,hazardCount+2)); i++)
		{
			Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x , spawnValues.x) , spawnValues.y, spawnValues.z);
			//Quaternion spawnRotation = new Quaternion ();
			Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (Random.Range(spawnWaitMin/2,spawnWaitMax/2));
		}

		Vector3 spawnPos = new Vector3 (Random.Range(0, 0) , spawnValues.y, spawnValues.z);
		Instantiate (EndOfLevel, spawnPos, spawnRotation);


	}
}
