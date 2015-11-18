using UnityEngine;
using System.Collections;

public class WaterDrop : MonoBehaviour {

	public LayerMask layermask;
	public GameObject watersound;
	// Use this for initialization
	void Start () {
		Physics.IgnoreLayerCollision (4,4,true);
	}
	
	// Updateasdasds is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.CompareTag("Kiuas")){
		    Instantiate(watersound, transform.position, Quaternion.identity);
			collision.gameObject.GetComponent<KiuasSaunaConnection>().addTemp();
		}

		else if (collision.gameObject.GetComponent<BucketScript>() != null){
			collision.gameObject.GetComponent<BucketScript>().addTippa (1);
		}
		Destroy(gameObject);
	}
}
