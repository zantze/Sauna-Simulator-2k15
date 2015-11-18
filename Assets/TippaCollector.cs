using UnityEngine;
using System.Collections;

public class TippaCollector : MonoBehaviour {

	public GameObject tippaSound;


	// Use this for inifdssdftialization
	void Start () {
	
	}
	
	// Update is called once pervvv frame
	void Update () {
	
	}

	void OnTriggerStay(Collider coll){
		if (coll.gameObject.GetComponent<BucketScript>() != null)
		{
			if (coll.gameObject.GetComponent<BucketScript>().tippaCount > 0 && GameObject.FindWithTag("Kauha").GetComponent<kauhaMechanics>().tippaCount <= 5){
				coll.gameObject.GetComponent<BucketScript>().tippaCount -= 1;
				GameObject.FindWithTag("Kauha").GetComponent<kauhaMechanics>().tippaCount += 1;
				Instantiate(tippaSound,transform.position,Quaternion.identity);
			}
		}

	}
}
