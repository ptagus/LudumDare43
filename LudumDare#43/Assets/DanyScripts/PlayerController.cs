using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public HowMuchDone hdm;
    public SwapDetail sd;
    public GameObject[] Hands;
    public Animation Hand;
    int losingFingers;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void LoseFinger(int number)
    {
        losingFingers = number;
        Hands[number - 1].SetActive(false);
        Hands[number].SetActive(true);
        Hand = transform.GetChild(number).GetComponent<Animation>();
        Hand.Play("hands|remove");
        StartCoroutine(LoseFingerAndBreakDetail());
    }

    public void NotLoseFinger()
    {
        transform.position = new Vector3(0, 0, 0);
        sd.SwapDetails();
        hdm.CloseActive();
    }

    IEnumerator LoseFingerAndBreakDetail()
    {
        yield return new WaitForSeconds(1);
        hdm.CloseActive();
        sd.loseDetail();
        Hand.Play("hands|remove_finger");
        transform.position = new Vector3(0,0,0);
        yield return new WaitForSeconds(0.5f);
        Hands[losingFingers].GetComponent<IsAxtiveNow>().isActive = true;
    }
}
