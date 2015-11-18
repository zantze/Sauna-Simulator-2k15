using UnityEngine;
using System.Collections;

public class PlayerUse : MonoBehaviour {
	Ray ray;
	RaycastHit hit;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.F))
		{
			if (Player.current.hand.currentlyCarrying)
				Player.current.hand.Drop();
			else if (Physics.Raycast(transform.position, transform.forward, out hit, 7.5f))
			{
				PumppuScript pumppu = hit.collider.gameObject.GetComponent<PumppuScript>();

				if (pumppu != null)
					pumppu.onPumps();
				else if (hit.collider.gameObject.GetComponent<Rigidbody>() != null)
					Player.current.hand.Pickup(hit.collider.gameObject);
			}
		}
	}
}
