using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public GameObject msg1, msg2, msg3, msg4, msg5, msg6, msg7, msg8, msg9, msg10;

	public GameObject restart;

	Vector3 vtr = new Vector3 (0, 0, 0);
	Quaternion qtr = new Quaternion();

	void OnTriggerEnter (Collider other)
	{
//		Instantiate (explosion, transform.position, transform.rotation);
		if(other.tag == "Player")
		{
			//Explode asteroid
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy (gameObject);

			//Explode Player
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);

			//Show Msg // Usar "SwitchCase"
			PickMsg (Random.Range(1, 10));
			//Instantiate (msg, vtr, other.transform.rotation);

			// Call Main Screen
			Instantiate (restart, vtr, transform.rotation);

		}
	}

	void PickMsg ( int i )
	{
		if (i == 1) {
			Instantiate (msg1, vtr, qtr);
		} else if (i == 2) {
			Instantiate (msg2, vtr, qtr);
		} else if (i == 3) {
			Instantiate (msg3, vtr, qtr);
		} else if (i == 4) {
			Instantiate (msg4, vtr, qtr);
		} else if (i == 5) {
			Instantiate (msg5, vtr, qtr);
		} else if (i == 6) {
			Instantiate (msg6, vtr, qtr);
		} else if (i == 7) {
			Instantiate (msg7, vtr, qtr);
		} else if (i == 8) {
			Instantiate (msg8, vtr, qtr);
		} else if (i == 9) {
			Instantiate (msg9, vtr, qtr);
		} else if (i == 10) {
			Instantiate (msg10, vtr, qtr);
		}
	}

}

