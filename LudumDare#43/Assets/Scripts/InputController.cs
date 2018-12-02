using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    bool isMove;
    public Transform cube;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {        
        cube.Translate(Vector3.up * Input.GetAxis("Mouse Y"));
    }
}
