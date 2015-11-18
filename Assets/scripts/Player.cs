using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public static Player current;

	public CarryScript hand;
	public kauhaMechanics kauha;

	void Awake() {
		current = this;
	}
}
