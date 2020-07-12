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
        if (door != null)
        {
            door.SetActive(!isActivated);
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        isActivated = true;
    }

    private void OnTriggerEnter(Collider collider)
    {
        isActivated = true;
    }

    private void OnTriggerExit(Collider collider)
    {
        isActivated = false;
    }
}
