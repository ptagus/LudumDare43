using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public AudioSource maintheme;
    public GameObject Pause;
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause.SetActive(true);
        }
        if(Input.GetMouseButton(0) && Input.GetAxis("Mouse Y") > 0 && cube.transform.position.z > 8)
        {
            return;
        }
        if (Input.GetMouseButton(0) && Input.GetAxis("Mouse Y") < 0 && cube.transform.position.z < -1)
        {
            return;
        }
        if(Input.GetMouseButton(0))
            cube.Translate(Vector3.forward * Input.GetAxis("Mouse Y") * speed);
    }

    public void Fingers()
    {
        speed += speed/2;
    }
}
