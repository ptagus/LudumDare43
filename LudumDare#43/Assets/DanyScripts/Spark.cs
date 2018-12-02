using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour {
	public GameObject spark;
	public GameObject light;
	GameObject lamp;
	public AudioSource sourceBreath;
	public AudioClip breath;
	// Use this for initialization
	void Start () {
		 lamp = GameObject.FindGameObjectWithTag ("Lamp");
		StartCoroutine (SparkCreation ());
		StartCoroutine (Breath ());
		sourceBreath = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SparkCreation ()
	{
		yield return new WaitForSeconds(Random.Range(10,18));
		Instantiate (spark, lamp.transform.position, Quaternion.identity);
		light.gameObject.SetActive (false);
		StartCoroutine (LampOff ());

		StartCoroutine (SparkCreation ());
	}

	IEnumerator LampOff ()
	{
		yield return new WaitForSeconds (0.5f);
		light.gameObject.SetActive (true);
	}

	IEnumerator Breath ()
	{
		yield return new  WaitForSeconds(Random.Range(20,30));
		sourceBreath.PlayOneShot(breath);
		StartCoroutine (Breath ());

 	}
}

