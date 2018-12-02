using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour {
	public AudioSource sourceScream;
	public List<AudioClip> screams;


	// Use this for initialization
	void Start () {
		sourceScream = gameObject.GetComponent<AudioSource> ();
		//scream1 = Random.Range (0, screams.Length);
	}
	
	// Update is called once per frame
	void Update () {
		if (Stanok.screamCount == true) {
			Debug.Log ("!");
			sourceScream.clip = screams [Random.Range (0, screams.Capacity)];
			sourceScream.PlayOneShot (sourceScream.clip);
			Stanok.screamCount = false;
		}
	}
}
