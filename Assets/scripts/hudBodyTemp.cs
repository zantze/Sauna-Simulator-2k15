using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class hudBodyTemp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		gameObject.GetComponent<Text>().text = "body tempature: " + Manager.Instance.bodyTemp + "c";

	}
}
