using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapDetail : MonoBehaviour {

    public GameObject Win;
    public PlayerController pc;
    public MeshFilter[] details;
    public Material[] mats;
    public int i;

    public void SwapDetails()
    {
        i++;
        if(i == 6)
        {
            Win.SetActive(true);
        }
        foreach(GameObject hand in pc.Hands)
        {
            if (hand.activeSelf)
            { 
                hand.transform.GetChild(0).GetComponent<MeshRenderer>().material = mats[i];
                hand.transform.GetChild(0).GetComponent<MeshFilter>().sharedMesh = details[i].sharedMesh;                
            }
        }
    }

    public void loseDetail()
    {
        i = 0;
    }
}
