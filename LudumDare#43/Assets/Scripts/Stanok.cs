using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stanok : MonoBehaviour
{
    int i = 0;
    public PlayerController Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Detail" && other.GetComponent<IsAxtiveNow>().isActive)
        {
            i++;
            Player.LoseFinger(i);
        }
        //Always
        //Detail done
        //May Be
        //Lose Finger
        Debug.Log(other.name +"Enter");
    }

    private void OnTriggerExit(Collider other)
    {
        //Always
        //Lose Finger
        //Detail break
        Debug.Log(other.name + "Exit");
    }
}
