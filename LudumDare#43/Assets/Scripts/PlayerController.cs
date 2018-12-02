using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject[] Hands;
    public Animation Hand;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void LoseFinger(int number)
    {
        Hands[number - 1].SetActive(false);
        Hands[number].SetActive(true);
        Hand = transform.GetChild(number).GetComponent<Animation>();
        Hand.Play("hands|remove");
        StartCoroutine(LoseFingerAndBreakDetail());
    }

    IEnumerator LoseFingerAndBreakDetail()
    {
        yield return new WaitForSeconds(2);
        Hand.Play("hands|remove_finger");
        transform.position = new Vector3(0,0,0);
    }
}
