using UnityEngine;
using System.Collections;

public class Kiuas : MonoBehaviour {
	public TempTrigger sauna;
    public float tippaPower;
    public AudioClip[] hisses;

    private AudioSource effects;

    void Awake() {
        effects = GetComponent<AudioSource>();
    }

    public void throwWater() {
        sauna.temp += tippaPower;
        effects.PlayOneShot(hisses[Random.Range(0, hisses.Length)]);
    }
}
