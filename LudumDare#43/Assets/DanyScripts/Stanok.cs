using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stanok : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Detail")
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
