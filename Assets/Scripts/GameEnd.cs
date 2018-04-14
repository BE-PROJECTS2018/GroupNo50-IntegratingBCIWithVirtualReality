using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {

    public bool GameEnded = false;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            GameEnded = true;
            transform.Find("Text").GetComponent<Text>().text = "You finished the game with " + GameObject.Find("Timer").GetComponent<Timer>().timer + "seconds remaining";
            
        }
    }
}
