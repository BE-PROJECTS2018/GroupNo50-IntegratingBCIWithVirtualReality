using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalCreator : MonoBehaviour
{
    public GameObject[] PortalPrefabs;
    public Vector3[] PortalPositions;
    int[] PortalDirections = { 2, 4, 2, 3, 1, 1, 1, 2, 3, 1 };
    int NumberOfPortalsCreated = 1;
    // Use this for initialization
    void Awake()
    {
        bool[] indextaken = new bool[10];
        while (NumberOfPortalsCreated <= 10)
        {
            int index = Random.Range(0, 10);
            if (!indextaken[index])
            {
                GameObject GO = GameObject.Instantiate(PortalPrefabs[NumberOfPortalsCreated - 1], PortalPositions[index], Quaternion.identity);

                int direction = PortalDirections[index];
                GO.GetComponent<PortalDirectionIdentifier>().direction = direction;
                if (direction == 1)
                {
                    GO.transform.eulerAngles = new Vector3(0, 90, 0);
                }
                if (direction == 2)
                {
                    GO.transform.eulerAngles = new Vector3(0, 270, 0);
                }
                if (direction == 3)
                {
                    GO.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                if (direction == 4)
                {
                    GO.transform.eulerAngles = new Vector3(0, 180, 0);
                }
                indextaken[index] = true;
                NumberOfPortalsCreated++;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
   
}
