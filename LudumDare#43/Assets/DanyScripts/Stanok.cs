using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stanok : MonoBehaviour
{
    public GameController gc;
    public HowMuchDone hmd;
    public InputController ic;
	public static bool screamCount = false;
    int i = 0;
    public PlayerController Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Detail" && other.GetComponent<IsAxtiveNow>().isActive)
        {
            i++;
            screamCount = true;
            gc.timeBoost++;
            hmd.CloseActive();
            ic.Fingers();
            Player.LoseFinger(i);
        }
        if (other.tag == "DetailDone")
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
