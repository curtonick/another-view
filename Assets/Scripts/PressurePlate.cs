using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public Collider plate;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        door.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Do nothing for now
    }

    private void OnCollisionExit(Collision collision)
    {
        door.SetActive(true);
    }
}
