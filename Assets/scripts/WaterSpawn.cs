using UnityEngine;
using System.Collections;

public class WaterSpawn : MonoBehaviour {

	public Transform homopillu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = homopillu.position;
	}
}
