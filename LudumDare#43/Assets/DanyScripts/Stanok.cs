using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stanok : MonoBehaviour
{
	public static bool screamCount = false;
    int i = 0;
    public PlayerController Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Detail" && other.GetComponent<IsAxtiveNow>().isActive)
        {
            i++;
            screamCount = true;
            Player.LoseFinger(i);
        }
        Debug.Log(other.name + "DetailDone");
    }

    private void OnTriggerExit(Collider other)
    {
        //Always
        //Lose Finger
        //Detail break
        Debug.Log(other.name + "Detail Break");
    }
}
