using UnityEngine;
using System.Collections;

public class FireFlicker : MonoBehaviour {

	Light lite;
	public float min,max;
	// Use this for initialization
	void Start () {
		lite = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		lite.intensity = Random.Range(min,max);
	}
}
