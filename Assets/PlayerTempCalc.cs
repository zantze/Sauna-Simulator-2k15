using UnityEngine;
using System.Collections;

public class PlayerTempCalc : MonoBehaviour {

	float curTemp;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		curTemp = Manager.Instance.currentTemp;

		if (curTemp > Manager.Instance.bodyTemp)
			Manager.Instance.bodyTemp += (273 + curTemp) / 1000 * Time.deltaTime;

		else
			Manager.Instance.bodyTemp -= (273 + curTemp) / 1000 * Time.deltaTime;

	}
}
