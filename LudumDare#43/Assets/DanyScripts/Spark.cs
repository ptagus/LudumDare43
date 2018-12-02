using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour {
	public GameObject spark;
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
		yield return new WaitForSeconds(Random.Range(15,30));
		Instantiate (spark, lamp.transform.position, Quaternion.identity);
		StartCoroutine (SparkCreation ());
	}
}

