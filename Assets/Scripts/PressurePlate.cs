using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject door;

    public bool isActivated = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay(Collider collider)
    {
        isActivated = true;

        if (door != null)
        {
            door.SetActive(!isActivated);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        // Do nothing for now
    }

    private void OnTriggerExit(Collider collider)
    {
        isActivated = false;

        if (door != null)
        {
            door.SetActive(!isActivated);
        }
    }
}
