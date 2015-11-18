using UnityEngine;
using System.Collections;

public class KiuasSaunaConnection : MonoBehaviour {
	public GameObject sauna;
	public float tippaPower;

	public void addTemp () {
		sauna.GetComponent<TempTrigger>().temp += tippaPower;
	}
}
