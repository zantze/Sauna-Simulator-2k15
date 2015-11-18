using UnityEngine;
using System.Collections;

public class KiuasSaunaConnection : MonoBehaviour {

	public GameObject sauna;
	public float tippaPower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addTemp () {
		sauna.GetComponent<TempTrigger>().temp += tippaPower;
	}
}
