using System.Collections;
using UnityEngine;

public class people : MonoBehaviour {

	private AudioSource sound01;
	private AudioSource sound02;

	void Start () {
		//AudioSourceコンポーネントを取得し、変数に格納
		AudioSource[] audioSources = GetComponents<AudioSource>();
		sound01 = audioSources[0];
		sound02 = audioSources[1];
	}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.CompareTag ("Player")) {

			this.transform.parent = hit.gameObject.transform;
			sound01.PlayOneShot(sound01.clip);
			sound02.PlayOneShot(sound02.clip);
			//SoundManager.Play=PlayId.Item;
		}
	}
}
