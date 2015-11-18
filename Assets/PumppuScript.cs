using UnityEngine;
using System.Collections;

public class PumppuScript : MonoBehaviour {

		public GameObject tippa;
		public Transform spawnPos;

	public float curPumpPower,pumpMultiplier;
	public float maxPower, minPower;
	public float powerPerPump,multiplierPerPump,maxPowerMultiplierPump;
	public float pumpDiminish,pumpMultiplierDiminish;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frameasdsadads
	void Update () {

		if (curPumpPower > maxPower){
			Instantiate(tippa,spawnPos.position,Quaternion.identity);
			curPumpPower = 1;
		}
		if (curPumpPower >= 0){
			curPumpPower -= pumpDiminish;
		}

		else{
			curPumpPower = 0;
		}

		if (multiplierPerPump >= 1){
			multiplierPerPump -= pumpMultiplierDiminish;
		}

		else{
			multiplierPerPump = 1;
		}

		if (multiplierPerPump >= maxPowerMultiplierPump)
			multiplierPerPump = maxPowerMultiplierPump;
	
	}

	public void onPumps() {
		curPumpPower = curPumpPower + powerPerPump;
		multiplierPerPump += pumpMultiplier;

		curPumpPower = curPumpPower * multiplierPerPump;


	}
}
