using UnityEngine;
using System.Collections;

public class CarryScript : MonoBehaviour {
	
	public GameObject currentlyCarrying;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (currentlyCarrying != null)
			currentlyCarrying.transform.position = transform.position;
	}
}
