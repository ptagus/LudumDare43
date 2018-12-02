using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour {
	public GameObject spark;
	public GameObject light;
	GameObject lamp;
	// Use this for initialization
	void Start () {
		 lamp = GameObject.FindGameObjectWithTag ("Lamp");
		StartCoroutine (SparkCreation ());
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
	IEnumerator LampOff (){
		yield return new WaitForSeconds (0.5f);
		light.gameObject.SetActive (true);
	}
}

