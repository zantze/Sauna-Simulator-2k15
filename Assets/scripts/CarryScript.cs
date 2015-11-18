using UnityEngine;
using System.Collections;

public class CarryScript : MonoBehaviour {
	public GameObject currentlyCarrying;

	private Vector3 positionRef;
	
	void LateUpdate () {
		if (currentlyCarrying)
			currentlyCarrying.transform.position =
				Vector3.SmoothDamp(transform.position, currentlyCarrying.transform.position,ref positionRef, 1f * Time.deltaTime);
	}

	public void Pickup(GameObject obj) {
		Rigidbody body = obj.GetComponent<Rigidbody> ();
		Collider coll = obj.GetComponent<Collider> ();
	
		Debug.Log (obj);

		if (body)
			body.isKinematic = true;

		if (coll)
			coll.enabled = false;

		currentlyCarrying = obj;
	}

	public void Drop() {
		if (!currentlyCarrying)
			return;

		Rigidbody body = currentlyCarrying.GetComponent<Rigidbody> ();
		Collider coll = currentlyCarrying.GetComponent<Collider> ();
		
		if (body)
			body.isKinematic = false;
		
		if (coll)
			coll.enabled = true;

		currentlyCarrying = null;
	}
}
