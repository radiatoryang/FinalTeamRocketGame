﻿using UnityEngine;
using System.Collections;

public class BombTick : MonoBehaviour {
	AudioSource tick;
	int count = 0;
	int counter =0;
	// Use this for initialization
	void Start () {
		tick = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<MoveBomb> ().isBombDroped () && counter == 0) {
			counter++;
			while(count!=3){
				tick.Play ();//ick.clip);
				count++;
			//StartCoroutine (playTick ());
			}
		}
	}
	IEnumerator playTick(){
		while (count != 3) {
			tick.PlayOneShot (tick.clip);
			yield return new WaitForSeconds (0);
			//tick.PlayOneShot (tick.clip);
			count++;
		}
	}
}
