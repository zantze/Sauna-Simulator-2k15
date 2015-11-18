using UnityEngine;
using System.Collections;

public class PlayerUse : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.F))
		{
			if (GameObject.FindWithTag ("Hand").GetComponent<CarryScript>().currentlyCarrying != null){
				GameObject.FindWithTag ("Hand").GetComponent<CarryScript>().currentlyCarrying.GetComponent<Rigidbody>().detectCollisions = true;
				GameObject.FindWithTag ("Hand").GetComponent<CarryScript>().currentlyCarrying = null;
			}

			else if (Physics.Raycast(transform.position,transform.forward, out hit, 6.5f))
			{
				if (hit.collider.gameObject.GetComponent<PumppuScript>() != null)
				{
					hit.collider.gameObject.GetComponent<PumppuScript>().onPumps();
				}

				else if (hit.collider.gameObject.GetComponent<Rigidbody>() != null)
				{
					GameObject.FindWithTag ("Hand").GetComponent<CarryScript>().currentlyCarrying = hit.collider.gameObject;
					GameObject.FindWithTag ("Hand").GetComponent<CarryScript>().currentlyCarrying.GetComponent<Rigidbody>().detectCollisions = false;
				}
			}
		}
	}
}
