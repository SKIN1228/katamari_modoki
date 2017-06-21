using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour {

	private AudioSource sound01;

	void Start () {
		//AudioSourceコンポーネントを取得し、変数に格納
		sound01 = GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter(Collider hit)
	{
		if (hit.CompareTag ("Player")) {
			
			this.transform.parent = hit.gameObject.transform;
			sound01.PlayOneShot(sound01.clip);
			//SoundManager.Play=PlayId.Item;
		}
	}
}
