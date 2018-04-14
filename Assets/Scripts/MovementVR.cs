using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementVR : MonoBehaviour {
     float speed = 0.05f;
     int SoundTimer = 0;
    bool isWalking = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Shooter>().isAlive &&   !(GameObject.Find("Timer").GetComponent<Timer>().timeup))
           
        {
            if (Input.GetKey(KeyCode.W) || transform.Find("[CameraRig]").gameObject.transform.Find("Controller (left)").
                GetComponent<SteamVR_TrackedController>().triggerPressed)
            {
                transform.Translate(Camera.main.transform.forward * speed);
                isWalking = true;
            }
            else if (Input.GetKey(KeyCode.S) || transform.Find("[CameraRig]").gameObject.transform.Find("Controller (right)").
               GetComponent<SteamVR_TrackedController>().triggerPressed)
            {
                transform.Translate(-Camera.main.transform.forward * speed);
                isWalking = true;
            }
            else
            {
                isWalking = false;
            }
        }
        
        if(!GetComponent<Shooter>().isAlive || (GameObject.Find("Timer").GetComponent<Timer>().timeup))
        {
            transform.Find("EndGameCanvas").gameObject.SetActive(true);
            isWalking = false;
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    private void FixedUpdate()
    {
        if (isWalking)
        {
            SoundTimer++;
        }
        if (SoundTimer % 50 == 0)
        {
            GetComponent<SoundManager>().FootStepSound();
        }
    }
}
