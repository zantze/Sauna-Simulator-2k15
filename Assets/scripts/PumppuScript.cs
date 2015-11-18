using UnityEngine;
using System.Collections;

public class PumppuScript : MonoBehaviour {
	public GameObject tippa;
	public Transform spawnPos;

    public float power = 0;
    public float requiredPower = 100f;

	void Update() {
        if (power >= requiredPower) {
            Instantiate(tippa, spawnPos.position, Quaternion.identity);
            power -= (requiredPower / 4f);
        }

        power -= (2f * (power / requiredPower)) * Time.deltaTime;
	}

	public void onPumps() {
        power += 1f + (power / requiredPower);
	}
}
