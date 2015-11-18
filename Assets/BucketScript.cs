using UnityEngine;
using System.Collections;

public class BucketScript : MonoBehaviour {

	public int tippaCount;
	public int maxTippas;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addTippa(int count)
	{
		if (tippaCount < maxTippas)
			tippaCount++;
	}
}
