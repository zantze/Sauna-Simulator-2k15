using UnityEngine;
using System.Collections;

public class playSounds : MonoBehaviour {

	public AudioClip[] sounds;
	
	AudioClip selectedAudio;

	// Use this for initialization
	void Awake () {

		if (sounds.Length >= 2) {
			selectedAudio = sounds[Random.Range (0,sounds.Length - 1)];
			gameObject.GetComponent<AudioSource>().clip = selectedAudio;
		}
	}

	void Start(){
		gameObject.GetComponent<AudioSource>().Play();
		Destroy (gameObject,selectedAudio.length);

	}

}
