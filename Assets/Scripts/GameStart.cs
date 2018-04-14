using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {
    public bool GameStarted=false;
    private void OnTriggerExit(Collider other)
    {
      
        if (other.gameObject.tag == "Player")
        {
            GameStarted = true;
            gameObject.transform.Find("Image").gameObject.SetActive(false);
            gameObject.transform.Find("Text").gameObject.SetActive(false);
        }
    }

}
