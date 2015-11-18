using UnityEngine;
using System.Collections;

public class sensitivity : MonoBehaviour {


	public float mouseSens;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Manager.Instance.mySens = mouseSens;
	}
}
