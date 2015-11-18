using UnityEngine;
using System.Collections;

public class TippaCollector : MonoBehaviour {
	public GameObject tippaSound;

	void OnTriggerStay(Collider coll){
		BucketScript bucket = coll.gameObject.GetComponent<BucketScript> ();

		if (bucket != null)
		{
			if (bucket.tippaCount > 0 && Player.current.kauha.tippaCount <= 5){
				bucket.tippaCount--;
				Player.current.kauha.tippaCount++;
				Instantiate(tippaSound, transform.position, Quaternion.identity);
			}
		}

	}
}
