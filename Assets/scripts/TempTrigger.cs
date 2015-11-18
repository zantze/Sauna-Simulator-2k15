using UnityEngine;
using System.Collections;

public class TempTrigger : MonoBehaviour {

	public float temp;

	public bool isSauna;
	public float diminish;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isSauna)
			temp -= diminish * Time.deltaTime;
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player"))
			Manager.Instance.currentTemp = temp;
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag("Player"))
			Manager.Instance.currentTemp = Manager.Instance.outsideTemp;
	}


}
