using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowMuchDone : MonoBehaviour {

    public Button done;
    public int i = 0;
    public AudioClip[] ac;
    AudioSource AudioSource;
	// Use this for initialization
	void Start ()
    {
        AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(i >= 3)
        {
            return;
        }
            AudioSource.clip = ac[i];
            AudioSource.Play();
            i++;
            if (i == 3)
            {
                done.image.color = Color.green;
                done.enabled = true;
            }
            Debug.Log(other.name);
    }
}
