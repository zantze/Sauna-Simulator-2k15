using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class footSteps : MonoBehaviour {

	Dictionary<string,GameObject> mystring = new Dictionary<string, GameObject>();

	public GameObject FootStep_wood;
	public GameObject FootStep_sand;
	public GameObject FootStep_template;

	public float speed;
	public float curStep,nextStep;
	Vector3 lastpos,newpos;

	// Use this for initialization
	void Start () {
	
		mystring.Add("FootStep_wood",FootStep_wood);
		mystring.Add("FootStep_sand",FootStep_sand);
		mystring.Add("FootStep_template",FootStep_template);


	}
	
	// Update is called once per frame
	void Update () {
		lastpos = transform.position;
		speed = Vector3.Distance(lastpos,newpos);
		newpos = transform.localPosition;

		curStep += speed;

		if (curStep >= nextStep)
		{
			GameObject temp;

			string material = "FootStep_" + getMaterial ();
			Debug.Log(material);
			Instantiate(mystring[material],transform.position,Quaternion.identity);
			curStep = 0;
		}

	}

	string getMaterial(){

		RaycastHit hit;
		if (Physics.Raycast(transform.position,-transform.up, out hit, 6.5f))
		{
			if (hit.collider.gameObject.GetComponent<ObjectMaterial>())
				return hit.collider.gameObject.GetComponent<ObjectMaterial>().material;
		}
		
		string template = "template";

		return template;
	}
}
