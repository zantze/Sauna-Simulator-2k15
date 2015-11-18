using UnityEngine;
using System.Collections;

public class kauhaMechanics : MonoBehaviour {

	bool haveWater = true;

	public Transform kauhapos;
	public GameObject waterBlock;

	public int tippaCount;

	GameObject playa;
	Quaternion defaultRot;

	bool throwWater = false;
	bool released = false;

	public float maxCharge,curCharge,loadSpeed,rotReduce;

	// LOLLOTdasddddasdsas
	void Start () {
		playa = GameObject.FindWithTag("Player");
		defaultRot = transform.rotation;
	}
	
	void Update () {

		if (Input.GetButton ("Fire1") && released == false){
				if (curCharge < maxCharge){
					curCharge += loadSpeed * Time.deltaTime;
				transform.Rotate(loadSpeed / rotReduce, 0, 0);
				throwWater = true;


			}
		}

		if (Input.GetButtonDown ("Fire2")){
			throwWater = false; 
			released = true;

		}

		if (Input.GetButtonUp ("Fire2")){
			released = false;
		}

		if (Input.GetButtonUp ("Fire1")){
			transform.eulerAngles = defaultRot.eulerAngles;

				if(haveWater && throwWater == true){
					for (int i = 0;i < 5;i++)
					{
						if (tippaCount > 0){
						GameObject tIPPPZ = Instantiate (waterBlock,kauhapos.position,Quaternion.identity) as GameObject;
						tIPPPZ.GetComponent<Rigidbody>().AddForce((playa.transform.up + playa.transform.forward) * (Random.Range(curCharge,curCharge + 1.5f )* 100));
						tippaCount -= 1;
						}
					}
			}
			curCharge = 0;
			throwWater = false;
		}
			
		transform.position = GameObject.FindWithTag("Player").transform.position + playa.transform.right + playa.transform.up;
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x,playa.transform.eulerAngles.y + 5,playa.transform.eulerAngles.z);
	}


}
