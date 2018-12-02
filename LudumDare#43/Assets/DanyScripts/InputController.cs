using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float speed;
    bool isMove;
    public Transform cube;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {        
        cube.Translate(Vector3.back * Input.GetAxis("Mouse Y") * speed);
    }

    public void Fingers()
    {
        speed += speed/2;
    }
}
