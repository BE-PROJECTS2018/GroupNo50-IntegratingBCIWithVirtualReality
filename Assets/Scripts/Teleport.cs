using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    //public Transform portal_anim;
    public GameObject portal_Or1;
    public GameObject portal_Or2;
    public GameObject portal_B1;
    public GameObject portal_B2;
    public GameObject portal_G1;
    public GameObject portal_G2;
    public GameObject portal_R1;
    public GameObject portal_R2;
    public GameObject portal_Y1;
    public GameObject portal_Y2;
    //public Transform tpLoc;

    // Use this for initialization
    void Start ()
    {
        portal_Or1 = GameObject.FindGameObjectWithTag("Orange_1").transform.Find("Portal").gameObject;
        portal_Or2=GameObject.FindGameObjectWithTag("Orange_2").transform.Find("Portal").gameObject;
        portal_B1 = GameObject.FindGameObjectWithTag("Blue_1").transform.Find("Portal").gameObject;
        portal_B2 = GameObject.FindGameObjectWithTag("Blue_2").transform.Find("Portal").gameObject;
        portal_G1 = GameObject.FindGameObjectWithTag("Green_1").transform.Find("Portal").gameObject;
        portal_G2 = GameObject.FindGameObjectWithTag("Green_2").transform.Find("Portal").gameObject;
        portal_R1 = GameObject.FindGameObjectWithTag("Red_1").transform.Find("Portal").gameObject;
        portal_R2 = GameObject.FindGameObjectWithTag("Red_2").transform.Find("Portal").gameObject;
        portal_Y1 = GameObject.FindGameObjectWithTag("Yellow_1").transform.Find("Portal").gameObject;
        portal_Y2 = GameObject.FindGameObjectWithTag("Yellow_2").transform.Find("Portal").gameObject;
       
        portal_Or1.SetActive(false);
        portal_Or2.SetActive(false);
        portal_B1.SetActive(false);
        portal_B2.SetActive(false);
        portal_G1.SetActive(false);
        portal_G2.SetActive(false);
        portal_R1.SetActive(false);
        portal_R2.SetActive(false);
        portal_Y1.SetActive(false);
        portal_Y2.SetActive(false);
        
    }
    private void Update()
    {
        Debug.Log(portal_Y2);
    }
    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Yellow_1")
        {
            portal_Y1.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Yellow_2");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Yellow_2")
        {
            portal_Y2.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Yellow_1");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Orange_1")
        {
            portal_Or1.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Orange_2");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }
            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Orange_2")
        {
            portal_Or2.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Orange_1");

                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
                //StopPortal();
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Red_1")
        {
            portal_R1.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Red_2");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Red_2")
        {
            portal_R2.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Red_1");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Blue_1")
        {
            portal_B1.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Blue_2");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Blue_2")
        {
            portal_B2.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Blue_1");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Green_1")
        {
            portal_G1.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Green_2");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }

        if (other.gameObject.tag == "Green_2")
        {

           
            portal_G2.gameObject.SetActive(true);
            if (other.gameObject.transform.Find("Slider").GetComponent<Slider>().value == other.gameObject.transform.Find("Slider").GetComponent<Slider>().maxValue)
            {
                GameObject GO = GameObject.FindGameObjectWithTag("Green_1");
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 1)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x - 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 2)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x + 1.0f, 0.49f, GO.transform.parent.gameObject.transform.position.z);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 3)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z - 1.0f);
                }
                if (GO.transform.parent.gameObject.GetComponent<PortalDirectionIdentifier>().direction == 4)
                {
                    transform.position = new Vector3(GO.transform.parent.gameObject.transform.position.x, 0.49f, GO.transform.parent.gameObject.transform.position.z + 1.0f);
                }
            }

            other.gameObject.transform.Find("Slider").GetComponent<Slider>().value = 0;
        }
	}

    void OnTriggerExit (Collider other)
    {
        portal_Or1.gameObject.SetActive(false);
        portal_Or2.gameObject.SetActive(false);
        portal_B1.gameObject.SetActive(false);
        portal_B2.gameObject.SetActive(false);
        portal_G1.gameObject.SetActive(false);
        portal_G2.gameObject.SetActive(false);
        portal_R1.gameObject.SetActive(false);
        portal_R2.gameObject.SetActive(false);
        portal_Y1.gameObject.SetActive(false);
        portal_Y2.gameObject.SetActive(false);
    }
}
