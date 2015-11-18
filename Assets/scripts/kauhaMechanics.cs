using UnityEngine;
using System.Collections;

public class kauhaMechanics : MonoBehaviour {

	bool haveWater = true;

	public Transform kauhapos;
	public GameObject waterBlock;

	public int tippaCount;

	Quaternion defaultRot;

	bool throwWater = false;
	bool released = false;

	public float maxCharge, curCharge, loadSpeed, rotReduce;

	// LOLLOTdasddddasdsas
	void Start () {
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

		if (Input.GetButtonDown("Fire2")) {
			throwWater = false; 
			released = true;
		}

		if (Input.GetButtonUp("Fire2")) {
			released = false;
		}

		if (Input.GetButtonUp("Fire1")) {
			transform.eulerAngles = defaultRot.eulerAngles;

		    if(haveWater && throwWater == true) {
				for (int i = 0;i < 5;i++) {
					if (tippaCount > 0){
						GameObject tIPPPZ = Instantiate(waterBlock,kauhapos.position,Quaternion.identity) as GameObject;
						tIPPPZ.GetComponent<Rigidbody>().AddForce((Player.current.transform.up + Player.current.transform.forward) * (Random.Range(curCharge,curCharge + 1.5f) * 100));
						tippaCount -= 1;
					}
				}
			}

			curCharge = 0;
			throwWater = false;
		}
			
		transform.position = Player.current.transform.position + Player.current.transform.right + Player.current.transform.up;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, Player.current.transform.eulerAngles.y + 5, Player.current.transform.eulerAngles.z);
	}
}
